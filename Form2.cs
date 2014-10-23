using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.VisualBasic;

namespace CheckIEFeatureControl {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        public RegistryKey rk;
        public String feat;

        private void Form2_Load(object sender, EventArgs e) {
            Reload();
        }

        private void Reload() {
            lvC.Items.Clear();
            if (rk != null) {
                using (RegistryKey rkFeat = rk.OpenSubKey(feat)) {
                    if (rkFeat != null) {
                        foreach (String k in rkFeat.GetValueNames()) {
                            ListViewItem lvi = new ListViewItem(k);
                            Object o = rkFeat.GetValue(k);
                            if (o is int || o is uint || o is long || o is ulong) {
                                lvi.SubItems.Add(o + "");
                                lvi.Tag = o;
                                lvi.Name = k;
                                lvC.Items.Add(lvi);
                            }
                        }
                    }
                }
            }
        }

        private void bEdit_Click(object sender, EventArgs e) {
            foreach (ListViewItem lvi in lvC.SelectedItems) {
                String s = Interaction.InputBox(lvi.Name + "\n\n" + "è\êiêîÇ≈", "", lvi.SubItems[1].Text, -1, -1);
                if (s.Length == 0) return;
                if (rk != null) {
                    using (RegistryKey rkFeat = rk.CreateSubKey(feat)) {
                        rkFeat.SetValue(lvi.Name, int.Parse(s));
                    }
                    Reload();
                }
                break;
            }
        }

        private void bNew_Click(object sender, EventArgs e) {
            String k = Interaction.InputBox("Value name?", "", "iexplore.exe", -1, -1);
            if (k.Length == 0) return;
            String v = Interaction.InputBox("Value data?", "", "1", -1, -1);
            if (v.Length == 0) return;

            if (rk != null) {
                using (RegistryKey rkFeat = rk.CreateSubKey(feat)) {
                    rkFeat.SetValue(k, int.Parse(v));
                }
                Reload();
            }
        }

        private void bDelete_Click(object sender, EventArgs e) {
            foreach (ListViewItem lvi in lvC.SelectedItems) {
                DialogResult r = MessageBox.Show(this, "Delete " + lvi.Name + "?", "CheckIEFeatureControl", MessageBoxButtons.YesNoCancel);
                if (r == DialogResult.Yes) {
                    if (rk != null) {
                        using (RegistryKey rkFeat = rk.CreateSubKey(feat)) {
                            rkFeat.DeleteValue(lvi.Name);
                        }
                        Reload();
                    }
                }
                else if (r != DialogResult.No) break;
            }
        }
    }
}