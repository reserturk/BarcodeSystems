namespace HedefBarkod
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.ppDiyalog = new System.Windows.Forms.PrintPreviewDialog();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // pdYazici
            // 
            this.pdYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdYazici_PrintPage);
            // 
            // ppDiyalog
            // 
            this.ppDiyalog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDiyalog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDiyalog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDiyalog.Document = this.pdYazici;
            this.ppDiyalog.Enabled = true;
            this.ppDiyalog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDiyalog.Icon")));
            this.ppDiyalog.Name = "ppDiyalog";
            this.ppDiyalog.Visible = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(785, 128);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnYazdir.TabIndex = 0;
            this.btnYazdir.Text = "simpleButton1";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 493);
            this.Controls.Add(this.btnYazdir);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument pdYazici;
        private System.Windows.Forms.PrintPreviewDialog ppDiyalog;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
    }
}