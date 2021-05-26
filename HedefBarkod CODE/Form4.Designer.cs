namespace HedefBarkod
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSAdet = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARKOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUNADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SATISFIYATI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnVeresiye = new DevExpress.XtraEditors.SimpleButton();
            this.btnKredi = new DevExpress.XtraEditors.SimpleButton();
            this.btnNakit = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNakit = new System.Windows.Forms.Label();
            this.lblKredi = new System.Windows.Forms.Label();
            this.lblVeresiye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarih = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btnCikar);
            this.groupBox1.Controls.Add(this.txtSAdet);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BARKOD NO GİR";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(663, 60);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Adet Değiştir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCikar.Appearance.Options.UseFont = true;
            this.btnCikar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikar.ImageOptions.Image")));
            this.btnCikar.Location = new System.Drawing.Point(663, 10);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(169, 44);
            this.btnCikar.TabIndex = 1;
            this.btnCikar.Text = "Seçilen Ürünü Çıkar";
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // txtSAdet
            // 
            this.txtSAdet.Location = new System.Drawing.Point(749, 62);
            this.txtSAdet.Name = "txtSAdet";
            this.txtSAdet.Size = new System.Drawing.Size(83, 21);
            this.txtSAdet.TabIndex = 4;
            this.txtSAdet.TextChanged += new System.EventHandler(this.txtSAdet_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.lblTutar.Location = new System.Drawing.Point(799, 349);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(45, 48);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.BARKOD,
            this.URUNADI,
            this.SATISFIYATI,
            this.adet});
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(832, 238);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // UID
            // 
            this.UID.FillWeight = 13.63446F;
            this.UID.HeaderText = "Ürün ID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Width = 69;
            // 
            // BARKOD
            // 
            this.BARKOD.FillWeight = 75.29957F;
            this.BARKOD.HeaderText = "Barkod";
            this.BARKOD.Name = "BARKOD";
            this.BARKOD.ReadOnly = true;
            this.BARKOD.Width = 210;
            // 
            // URUNADI
            // 
            this.URUNADI.FillWeight = 479.2987F;
            this.URUNADI.HeaderText = "Ürün Adı";
            this.URUNADI.Name = "URUNADI";
            this.URUNADI.ReadOnly = true;
            this.URUNADI.Width = 370;
            // 
            // SATISFIYATI
            // 
            this.SATISFIYATI.FillWeight = 16.50724F;
            this.SATISFIYATI.HeaderText = "Fiyat";
            this.SATISFIYATI.Name = "SATISFIYATI";
            this.SATISFIYATI.ReadOnly = true;
            // 
            // adet
            // 
            this.adet.FillWeight = 8.620638F;
            this.adet.HeaderText = "Satış Adeti";
            this.adet.Name = "adet";
            this.adet.ReadOnly = true;
            this.adet.Width = 83;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIptal);
            this.groupBox2.Controls.Add(this.btnVeresiye);
            this.groupBox2.Controls.Add(this.btnKredi);
            this.groupBox2.Controls.Add(this.btnNakit);
            this.groupBox2.Location = new System.Drawing.Point(850, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 333);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış Seçenekleri";
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Cambria Math", 15F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.Appearance.Options.UseForeColor = true;
            this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
            this.btnIptal.Location = new System.Drawing.Point(6, 245);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(151, 69);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "Satış İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnVeresiye
            // 
            this.btnVeresiye.Appearance.Font = new System.Drawing.Font("Cambria Math", 15F, System.Drawing.FontStyle.Bold);
            this.btnVeresiye.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVeresiye.Appearance.Options.UseFont = true;
            this.btnVeresiye.Appearance.Options.UseForeColor = true;
            this.btnVeresiye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVeresiye.ImageOptions.Image")));
            this.btnVeresiye.Location = new System.Drawing.Point(6, 170);
            this.btnVeresiye.Name = "btnVeresiye";
            this.btnVeresiye.Size = new System.Drawing.Size(151, 69);
            this.btnVeresiye.TabIndex = 0;
            this.btnVeresiye.Text = "Defter";
            this.btnVeresiye.Click += new System.EventHandler(this.btnVeresiye_Click);
            // 
            // btnKredi
            // 
            this.btnKredi.Appearance.Font = new System.Drawing.Font("Cambria Math", 15F, System.Drawing.FontStyle.Bold);
            this.btnKredi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKredi.Appearance.Options.UseFont = true;
            this.btnKredi.Appearance.Options.UseForeColor = true;
            this.btnKredi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKredi.ImageOptions.Image")));
            this.btnKredi.Location = new System.Drawing.Point(6, 95);
            this.btnKredi.Name = "btnKredi";
            this.btnKredi.Size = new System.Drawing.Size(151, 69);
            this.btnKredi.TabIndex = 0;
            this.btnKredi.Text = "Kredi Kartı";
            this.btnKredi.Click += new System.EventHandler(this.btnKredi_Click);
            // 
            // btnNakit
            // 
            this.btnNakit.Appearance.Font = new System.Drawing.Font("Cambria Math", 15F, System.Drawing.FontStyle.Bold);
            this.btnNakit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNakit.Appearance.Options.UseFont = true;
            this.btnNakit.Appearance.Options.UseForeColor = true;
            this.btnNakit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNakit.ImageOptions.Image")));
            this.btnNakit.Location = new System.Drawing.Point(6, 20);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(151, 69);
            this.btnNakit.TabIndex = 0;
            this.btnNakit.Text = "Nakit";
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(420, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "GENEL TOPLAM : ";
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Location = new System.Drawing.Point(61, 377);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(37, 13);
            this.lblNakit.TabIndex = 3;
            this.lblNakit.Text = "NAKİT";
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.Location = new System.Drawing.Point(104, 377);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(70, 13);
            this.lblKredi.TabIndex = 3;
            this.lblKredi.Text = "KREDİ KARTI";
            // 
            // lblVeresiye
            // 
            this.lblVeresiye.AutoSize = true;
            this.lblVeresiye.Location = new System.Drawing.Point(180, 377);
            this.lblVeresiye.Name = "lblVeresiye";
            this.lblVeresiye.Size = new System.Drawing.Size(54, 13);
            this.lblVeresiye.TabIndex = 3;
            this.lblVeresiye.Text = "VERESİYE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(302, 377);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 13);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "label2";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form4
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 593);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblVeresiye);
            this.Controls.Add(this.lblKredi);
            this.Controls.Add(this.lblNakit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.Transparent;
            this.Name = "Form4";
            this.Text = "Satış Ekranı";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARKOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUNADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SATISFIYATI;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.SimpleButton btnVeresiye;
        private DevExpress.XtraEditors.SimpleButton btnKredi;
        private DevExpress.XtraEditors.SimpleButton btnNakit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.Label lblVeresiye;
        private DevExpress.XtraEditors.SimpleButton btnCikar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtSAdet;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Timer timer2;
    }
}