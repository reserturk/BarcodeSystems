namespace HedefBarkod
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SATISID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBARKOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SFIYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SADET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKASA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STARIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(18, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATILAN ÜRÜNLER LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SATISID,
            this.SBARKOD,
            this.SURUN,
            this.SFIYAT,
            this.SADET,
            this.SKASA,
            this.STARIH});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(917, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // SATISID
            // 
            this.SATISID.DataPropertyName = "SATISID";
            this.SATISID.HeaderText = "ID";
            this.SATISID.Name = "SATISID";
            this.SATISID.ReadOnly = true;
            this.SATISID.Width = 50;
            // 
            // SBARKOD
            // 
            this.SBARKOD.DataPropertyName = "SBARKOD";
            this.SBARKOD.HeaderText = "ÜRÜN BARKOD";
            this.SBARKOD.Name = "SBARKOD";
            this.SBARKOD.ReadOnly = true;
            this.SBARKOD.Width = 200;
            // 
            // SURUN
            // 
            this.SURUN.DataPropertyName = "SURUN";
            this.SURUN.HeaderText = "ÜRÜNLER";
            this.SURUN.Name = "SURUN";
            this.SURUN.ReadOnly = true;
            this.SURUN.Width = 300;
            // 
            // SFIYAT
            // 
            this.SFIYAT.DataPropertyName = "SFIYAT";
            this.SFIYAT.HeaderText = "FİYATI";
            this.SFIYAT.Name = "SFIYAT";
            this.SFIYAT.ReadOnly = true;
            this.SFIYAT.Width = 50;
            // 
            // SADET
            // 
            this.SADET.DataPropertyName = "SADET";
            this.SADET.HeaderText = "SATIŞ ADETİ";
            this.SADET.Name = "SADET";
            this.SADET.ReadOnly = true;
            this.SADET.Width = 50;
            // 
            // SKASA
            // 
            this.SKASA.DataPropertyName = "SKASA";
            this.SKASA.HeaderText = "KASA GİRİŞİ";
            this.SKASA.Name = "SKASA";
            this.SKASA.ReadOnly = true;
            this.SKASA.Width = 75;
            // 
            // STARIH
            // 
            this.STARIH.DataPropertyName = "STARIH";
            this.STARIH.HeaderText = "SATILMA TARİHİ";
            this.STARIH.Name = "STARIH";
            this.STARIH.ReadOnly = true;
            this.STARIH.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(725, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TARİH ARAMA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 21);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton4);
            this.groupBox3.Controls.Add(this.simpleButton3);
            this.groupBox3.Controls.Add(this.simpleButton2);
            this.groupBox3.Controls.Add(this.simpleButton1);
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 196);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(509, 41);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(157, 107);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Hepsini Göster";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(346, 41);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(157, 107);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Veresiye Göster";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(183, 41);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(157, 107);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Kredi Göster";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(20, 41);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(157, 107);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Nakit Göster";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTutar.Location = new System.Drawing.Point(1143, 516);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(72, 24);
            this.lblTutar.TabIndex = 3;
            this.lblTutar.Text = "label1";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(1144, 260);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 13);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(964, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOPLAM FİYAT : ";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(968, 224);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(139, 98);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Seçilen Ürünü Sil";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 568);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Satılan Ürünler";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SATISID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBARKOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFIYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SADET;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKASA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STARIH;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}