namespace CheckIEFeatureControl {
    partial class Form2 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tsc = new System.Windows.Forms.ToolStripContainer();
            this.lvC = new System.Windows.Forms.ListView();
            this.chK = new System.Windows.Forms.ColumnHeader();
            this.chV = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bEdit = new System.Windows.Forms.ToolStripButton();
            this.bNew = new System.Windows.Forms.ToolStripButton();
            this.bDelete = new System.Windows.Forms.ToolStripButton();
            this.tsc.ContentPanel.SuspendLayout();
            this.tsc.TopToolStripPanel.SuspendLayout();
            this.tsc.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsc
            // 
            // 
            // tsc.ContentPanel
            // 
            this.tsc.ContentPanel.Controls.Add(this.lvC);
            this.tsc.ContentPanel.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tsc.ContentPanel.Size = new System.Drawing.Size(409, 200);
            this.tsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc.Location = new System.Drawing.Point(0, 0);
            this.tsc.Name = "tsc";
            this.tsc.Size = new System.Drawing.Size(409, 225);
            this.tsc.TabIndex = 0;
            // 
            // tsc.TopToolStripPanel
            // 
            this.tsc.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // lvC
            // 
            this.lvC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chK,
            this.chV});
            this.lvC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvC.FullRowSelect = true;
            this.lvC.GridLines = true;
            this.lvC.Location = new System.Drawing.Point(0, 0);
            this.lvC.MultiSelect = false;
            this.lvC.Name = "lvC";
            this.lvC.Size = new System.Drawing.Size(409, 200);
            this.lvC.TabIndex = 0;
            this.lvC.UseCompatibleStateImageBehavior = false;
            this.lvC.View = System.Windows.Forms.View.Details;
            // 
            // chK
            // 
            this.chK.Text = "Key";
            this.chK.Width = 150;
            // 
            // chV
            // 
            this.chV.Text = "Value";
            this.chV.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bEdit,
            this.bNew,
            this.bDelete});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(213, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // bEdit
            // 
            this.bEdit.Image = ((System.Drawing.Image)(resources.GetObject("bEdit.Image")));
            this.bEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(50, 22);
            this.bEdit.Text = "&Edit";
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bNew
            // 
            this.bNew.Image = ((System.Drawing.Image)(resources.GetObject("bNew.Image")));
            this.bNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(54, 22);
            this.bNew.Text = "&New";
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bDelete
            // 
            this.bDelete.Image = ((System.Drawing.Image)(resources.GetObject("bDelete.Image")));
            this.bDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(66, 22);
            this.bDelete.Text = "&Delete";
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 225);
            this.Controls.Add(this.tsc);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit FeatureControl";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tsc.ContentPanel.ResumeLayout(false);
            this.tsc.TopToolStripPanel.ResumeLayout(false);
            this.tsc.TopToolStripPanel.PerformLayout();
            this.tsc.ResumeLayout(false);
            this.tsc.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsc;
        private System.Windows.Forms.ListView lvC;
        private System.Windows.Forms.ColumnHeader chK;
        private System.Windows.Forms.ColumnHeader chV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bEdit;
        private System.Windows.Forms.ToolStripButton bNew;
        private System.Windows.Forms.ToolStripButton bDelete;
    }
}