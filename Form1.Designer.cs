namespace CheckIEFeatureControl {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsc = new System.Windows.Forms.ToolStripContainer();
            this.lvF = new System.Windows.Forms.ListView();
            this.chFeat = new System.Windows.Forms.ColumnHeader();
            this.chHKLM64 = new System.Windows.Forms.ColumnHeader();
            this.chHKLM32 = new System.Windows.Forms.ColumnHeader();
            this.chHKCU64 = new System.Windows.Forms.ColumnHeader();
            this.chHKCU32 = new System.Windows.Forms.ColumnHeader();
            this.chPHKLM64 = new System.Windows.Forms.ColumnHeader();
            this.chPHKLM32 = new System.Windows.Forms.ColumnHeader();
            this.chPHKCU64 = new System.Windows.Forms.ColumnHeader();
            this.chPHKCU32 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCopyName = new System.Windows.Forms.ToolStripMenuItem();
            this.mGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bReload = new System.Windows.Forms.ToolStripButton();
            this.bCopyCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mHKLM64 = new System.Windows.Forms.ToolStripMenuItem();
            this.mHKLM32 = new System.Windows.Forms.ToolStripMenuItem();
            this.mHKCU64 = new System.Windows.Forms.ToolStripMenuItem();
            this.mHKCU32 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc.ContentPanel.SuspendLayout();
            this.tsc.TopToolStripPanel.SuspendLayout();
            this.tsc.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsc
            // 
            // 
            // tsc.ContentPanel
            // 
            this.tsc.ContentPanel.Controls.Add(this.lvF);
            this.tsc.ContentPanel.Controls.Add(this.label1);
            this.tsc.ContentPanel.Size = new System.Drawing.Size(860, 479);
            this.tsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc.Location = new System.Drawing.Point(0, 0);
            this.tsc.Name = "tsc";
            this.tsc.Size = new System.Drawing.Size(860, 504);
            this.tsc.TabIndex = 0;
            // 
            // tsc.TopToolStripPanel
            // 
            this.tsc.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // lvF
            // 
            this.lvF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFeat,
            this.chHKLM64,
            this.chHKLM32,
            this.chHKCU64,
            this.chHKCU32,
            this.chPHKLM64,
            this.chPHKLM32,
            this.chPHKCU64,
            this.chPHKCU32});
            this.lvF.ContextMenuStrip = this.contextMenuStrip1;
            this.lvF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvF.FullRowSelect = true;
            this.lvF.GridLines = true;
            this.lvF.Location = new System.Drawing.Point(0, 12);
            this.lvF.MultiSelect = false;
            this.lvF.Name = "lvF";
            this.lvF.Size = new System.Drawing.Size(860, 467);
            this.lvF.TabIndex = 1;
            this.lvF.UseCompatibleStateImageBehavior = false;
            this.lvF.View = System.Windows.Forms.View.Details;
            this.lvF.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvF_ColumnClick);
            // 
            // chFeat
            // 
            this.chFeat.Text = "Feature";
            this.chFeat.Width = 300;
            // 
            // chHKLM64
            // 
            this.chHKLM64.Text = "HKLM64";
            this.chHKLM64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHKLM64.Width = 66;
            // 
            // chHKLM32
            // 
            this.chHKLM32.Text = "HKLM32";
            this.chHKLM32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHKLM32.Width = 66;
            // 
            // chHKCU64
            // 
            this.chHKCU64.Text = "HKCU64";
            this.chHKCU64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHKCU64.Width = 66;
            // 
            // chHKCU32
            // 
            this.chHKCU32.Text = "HKCU32";
            this.chHKCU32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHKCU32.Width = 66;
            // 
            // chPHKLM64
            // 
            this.chPHKLM64.Text = "PHKLM64";
            this.chPHKLM64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPHKLM64.Width = 66;
            // 
            // chPHKLM32
            // 
            this.chPHKLM32.Text = "PHKLM32";
            this.chPHKLM32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPHKLM32.Width = 66;
            // 
            // chPHKCU64
            // 
            this.chPHKCU64.Text = "PHKCU64";
            this.chPHKCU64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPHKCU64.Width = 66;
            // 
            // chPHKCU32
            // 
            this.chPHKCU32.Text = "PHKCU32";
            this.chPHKCU32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPHKCU32.Width = 66;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCopyName,
            this.mGoogle,
            this.toolStripSeparator1,
            this.mHKLM64,
            this.mHKLM32,
            this.mHKCU64,
            this.mHKCU32});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 164);
            // 
            // mCopyName
            // 
            this.mCopyName.Name = "mCopyName";
            this.mCopyName.Size = new System.Drawing.Size(172, 22);
            this.mCopyName.Text = "&Copy feature";
            this.mCopyName.Click += new System.EventHandler(this.mCopyName_Click);
            // 
            // mGoogle
            // 
            this.mGoogle.Name = "mGoogle";
            this.mGoogle.Size = new System.Drawing.Size(172, 22);
            this.mGoogle.Text = "&Googling feature";
            this.mGoogle.Click += new System.EventHandler(this.mGoogle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FeatureControl:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bReload,
            this.bCopyCSV});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(164, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // bReload
            // 
            this.bReload.Image = ((System.Drawing.Image)(resources.GetObject("bReload.Image")));
            this.bReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(67, 22);
            this.bReload.Text = "&Reload";
            this.bReload.Click += new System.EventHandler(this.bReload_Click);
            // 
            // bCopyCSV
            // 
            this.bCopyCSV.Image = ((System.Drawing.Image)(resources.GetObject("bCopyCSV.Image")));
            this.bCopyCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCopyCSV.Name = "bCopyCSV";
            this.bCopyCSV.Size = new System.Drawing.Size(85, 22);
            this.bCopyCSV.Text = "&Copy CSV";
            this.bCopyCSV.Click += new System.EventHandler(this.mCopycsv_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // mHKLM64
            // 
            this.mHKLM64.Name = "mHKLM64";
            this.mHKLM64.Size = new System.Drawing.Size(172, 22);
            this.mHKLM64.Text = "HKLM64";
            this.mHKLM64.Click += new System.EventHandler(this.mHKLM64_Click);
            // 
            // mHKLM32
            // 
            this.mHKLM32.Name = "mHKLM32";
            this.mHKLM32.Size = new System.Drawing.Size(172, 22);
            this.mHKLM32.Text = "HKLM32";
            this.mHKLM32.Click += new System.EventHandler(this.mHKLM64_Click);
            // 
            // mHKCU64
            // 
            this.mHKCU64.Name = "mHKCU64";
            this.mHKCU64.Size = new System.Drawing.Size(172, 22);
            this.mHKCU64.Text = "HKCU64";
            this.mHKCU64.Click += new System.EventHandler(this.mHKLM64_Click);
            // 
            // mHKCU32
            // 
            this.mHKCU32.Name = "mHKCU32";
            this.mHKCU32.Size = new System.Drawing.Size(172, 22);
            this.mHKCU32.Text = "HKCU32";
            this.mHKCU32.Click += new System.EventHandler(this.mHKLM64_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 504);
            this.Controls.Add(this.tsc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckIEFeatureControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsc.ContentPanel.ResumeLayout(false);
            this.tsc.ContentPanel.PerformLayout();
            this.tsc.TopToolStripPanel.ResumeLayout(false);
            this.tsc.TopToolStripPanel.PerformLayout();
            this.tsc.ResumeLayout(false);
            this.tsc.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvF;
        private System.Windows.Forms.ColumnHeader chFeat;
        private System.Windows.Forms.ColumnHeader chHKLM64;
        private System.Windows.Forms.ColumnHeader chHKLM32;
        private System.Windows.Forms.ColumnHeader chHKCU64;
        private System.Windows.Forms.ColumnHeader chHKCU32;
        private System.Windows.Forms.ColumnHeader chPHKLM64;
        private System.Windows.Forms.ColumnHeader chPHKLM32;
        private System.Windows.Forms.ColumnHeader chPHKCU64;
        private System.Windows.Forms.ColumnHeader chPHKCU32;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bReload;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mCopyName;
        private System.Windows.Forms.ToolStripMenuItem mGoogle;
        private System.Windows.Forms.ToolStripButton bCopyCSV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mHKLM64;
        private System.Windows.Forms.ToolStripMenuItem mHKLM32;
        private System.Windows.Forms.ToolStripMenuItem mHKCU64;
        private System.Windows.Forms.ToolStripMenuItem mHKCU32;
    }
}

