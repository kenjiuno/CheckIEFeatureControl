using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CheckIEFeatureControl.Properties;
using Microsoft.Win32;
using System.Diagnostics;
using System.Web;
using System.IO;

namespace CheckIEFeatureControl {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bReload_Click(object sender, EventArgs e) {
            ReloadIt();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Text += " " + Application.ProductVersion;
            ReloadIt();
        }

        private void ReloadIt() {
            lvF.Items.Clear();

            List<String> rows = new List<string>(Resources.Feat.Replace("\r\n", "\n").Split('\n'));
            UtFeat fe = new UtFeat();
            rows.AddRange(fe.GetFeats());
            SortedDictionary<string, string> dictDone = new SortedDictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            foreach (String row in rows) {
                String[] cols = row.Trim().Split('\t');
                bool gone = (cols.Length >= 2) && cols[1] == "x";
                String feat = cols[0];
                if (feat.StartsWith(";") || feat.StartsWith("//") || feat.StartsWith("#")) continue;
                if (feat.Length == 0) continue;
                if (dictDone.ContainsKey(feat)) continue;
                dictDone[feat] = null;

                ListViewItem lvi = new ListViewItem((gone ? "x " : "") + feat);
                for (int x = 0; x < 8; x++) lvi.SubItems.Add("");

                lvi.Name = feat;

                for (int x = 0; x < 8; x++) {
                    String v = fe.Inspect(feat, 0 != (x & 4), 0 == (x & 2), 0 == (x & 1));
                    lvi.SubItems[1 + x].Text = v;
                }

                lvF.Items.Add(lvi);
            }
        }

        class UtFeat : IDisposable {
            SortedDictionary<String, RegistryKey> dict = new SortedDictionary<string, RegistryKey>();

            public String[] GetFeats() {
                List<String> al = new List<string>();
                for (int x = 0; x < 8; x++) {
                    RegistryKey rk = Getrk2(0 != (x & 1), 0 != (x & 2), 0 != (x & 4), false);
                    if (rk != null) {
                        al.AddRange(rk.GetSubKeyNames());
                    }
                }
                return al.ToArray();
            }

            public String Inspect(String feat, bool policy, bool hklm, bool x64) {
                RegistryKey rk = Getrk2(policy, hklm, x64, false);

                if (rk != null) {
                    using (RegistryKey rkFeat = rk.OpenSubKey(feat, false)) {
                        if (rkFeat != null) {
                            String s = "";
                            s += Fv("IE", rkFeat.GetValue("iexplore.exe"));
                            s += Fv("E", rkFeat.GetValue("explore.exe"));
                            s += Fv("U", rkFeat.GetValue("ieuser.exe"));
                            s += Fv("*", rkFeat.GetValue("*"));
                            return s.TrimEnd(',');
                        }
                    }
                }

                return "-";
            }

            private string Fv(String app, Object o) {
                int i;
                if (int.TryParse("" + o, out i) && i != 0) {
                    return app + ((i != 1) ? "=" + i.ToString("X") : "") + ",";
                }
                return "";
            }

            public RegistryKey Getrk2(bool policy, bool hklm, bool x64, bool writable) {
                String k = policy + "," + hklm + "," + x64 + "," + writable;
                RegistryKey rk = null;
                if (!dict.TryGetValue(k, out rk)) {
                    dict[k] = rk = Getrk(policy, hklm, x64, false);
                }
                return rk;
            }

            RegistryKey Getrk(bool policy, bool hklm, bool x64, bool writable) {
                bool os64 = IntPtr.Size == 8;

                if (os64) {
                    if (policy)
                        if (x64)
                            if (hklm)
                                return Registry.LocalMachine.OpenSubKey(@"Software\Policies\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                            else
                                return Registry.CurrentUser.OpenSubKey(@"Software\Policies\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                        else
                            if (hklm)
                                return Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Policies\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                            else
                                return Registry.CurrentUser.OpenSubKey(@"Software\Wow6432Node\Policies\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                    else
                        if (x64)
                            if (hklm)
                                return Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                            else
                                return Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                        else
                            if (hklm)
                                return Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                            else
                                return Registry.CurrentUser.OpenSubKey(@"Software\Wow6432Node\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                }
                else {
                    if (x64)
                        return null;
                    if (policy)
                        if (hklm)
                            return Registry.LocalMachine.OpenSubKey(@"Software\Policies\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                        else
                            return Registry.CurrentUser.OpenSubKey(@"Software\Policies\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                    else
                        if (hklm)
                            return Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                        else
                            return Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl", writable);
                }
            }

            #region IDisposable メンバ

            public void Dispose() {
                foreach (IDisposable o in dict.Values) {
                    if (o != null) o.Dispose();
                }
            }

            #endregion
        }

        class Sorts : System.Collections.IComparer {
            int x, ord;

            public Sorts(int x, bool asc) {
                this.x = x;
                this.ord = asc ? 1 : -1;
            }

            #region IComparer メンバ

            public int Compare(object ax, object ay) {
                ListViewItem vx = ax as ListViewItem;
                ListViewItem vy = ay as ListViewItem;
                bool fx = vx != null;
                bool fy = vy != null;
                if (!fx || fx != fy) return ord * fx.CompareTo(fy);
                return ord * vx.SubItems[x].Text.CompareTo(vy.SubItems[x].Text);
            }

            #endregion
        }

        private void lvF_ColumnClick(object sender, ColumnClickEventArgs e) {
            lvF.ListViewItemSorter = new Sorts(e.Column, 0 == (ModifierKeys & Keys.Shift));
        }

        private void mCopyName_Click(object sender, EventArgs e) {
            ListViewItem lvi = lvF.FocusedItem;
            if (lvi == null) return;
            Clipboard.SetText(lvi.Text);
        }

        private void mGoogle_Click(object sender, EventArgs e) {
            ListViewItem lvi = lvF.FocusedItem;
            if (lvi == null) return;
            Process.Start("http://www.google.co.jp/?q=" + HttpUtility.UrlEncode(lvi.Text));
        }

        private void mCopycsv_Click(object sender, EventArgs e) {
            StringWriter wr = new StringWriter();
            for (int y = 0; y < lvF.Items.Count; y++) {
                ListViewItem lvi = lvF.Items[y];
                for (int x = 0; x < lvi.SubItems.Count; x++) {
                    if (x != 0)
                        wr.Write(",");
                    wr.Write("\"" + lvi.SubItems[x].Text.Replace("\"", "\"\"") + "\"");
                }
                wr.WriteLine();
            }
            Clipboard.SetText(wr.ToString());
        }

        private void mHKLM64_Click(object sender, EventArgs e) {
            ToolStripItem[] al = new ToolStripItem[] {
                mHKLM64, mHKLM32, mHKCU64, mHKCU32,
            };
            using (UtFeat fe = new UtFeat()) {
                RegistryKey rk = fe.Getrk2(false
                    , 0 == (Array.IndexOf(al, sender) & 2)
                    , 0 == (Array.IndexOf(al, sender) & 1)
                    , true
                    );
                using (Form2 form = new Form2()) {
                    form.rk = rk;
                    form.feat = lvF.FocusedItem.Name;
                    form.ShowDialog(this);
                }
            }
        }
    }
}