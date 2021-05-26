namespace HedefBarkod
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnBesaz = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txturunara = new System.Windows.Forms.TextBox();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARKODNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUNADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SATISFIYATI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPTANCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALISFIYATI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunekle = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtToptanci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtSatisfiyati = new System.Windows.Forms.TextBox();
            this.txtAlisfiyati = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtUrunadi = new System.Windows.Forms.TextBox();
            this.txtBarkodno = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl5);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl6);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(750, 478);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "ARAMA";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.simpleButton4);
            this.groupControl5.Controls.Add(this.btnGizle);
            this.groupControl5.Controls.Add(this.btnBesaz);
            this.groupControl5.Controls.Add(this.simpleButton3);
            this.groupControl5.Location = new System.Drawing.Point(382, 23);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(358, 100);
            this.groupControl5.TabIndex = 3;
            this.groupControl5.Text = "LİSTE DETAYLARI";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(5, 59);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(189, 36);
            this.simpleButton4.TabIndex = 14;
            this.simpleButton4.Text = "(HEPSİ) ÜRÜN GETİR";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btnGizle
            // 
            this.btnGizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnGizle.Appearance.Options.UseFont = true;
            this.btnGizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGizle.ImageOptions.Image")));
            this.btnGizle.Location = new System.Drawing.Point(200, 62);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(145, 30);
            this.btnGizle.TabIndex = 15;
            this.btnGizle.Text = "ÜRÜNLERİ GİZLE ";
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // btnBesaz
            // 
            this.btnBesaz.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnBesaz.Appearance.Options.UseFont = true;
            this.btnBesaz.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBesaz.ImageOptions.SvgImage")));
            this.btnBesaz.Location = new System.Drawing.Point(200, 23);
            this.btnBesaz.Name = "btnBesaz";
            this.btnBesaz.Size = new System.Drawing.Size(145, 33);
            this.btnBesaz.TabIndex = 13;
            this.btnBesaz.Text = "5 DEN AZ GÖSTER";
            this.btnBesaz.Click += new System.EventHandler(this.btnBesaz_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(5, 23);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(189, 33);
            this.simpleButton3.TabIndex = 12;
            this.simpleButton3.Text = "BİTMİŞ ÜRÜNLERİ GÖSTER";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.simpleButton2);
            this.groupControl4.Controls.Add(this.txturunara);
            this.groupControl4.Location = new System.Drawing.Point(193, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(183, 100);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "ÜRÜN ADI İLE ARA";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(5, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(167, 38);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "ÜRÜN ADI İLE ARA";
            // 
            // txturunara
            // 
            this.txturunara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txturunara.Location = new System.Drawing.Point(5, 67);
            this.txturunara.Name = "txturunara";
            this.txturunara.Size = new System.Drawing.Size(167, 21);
            this.txturunara.TabIndex = 11;
            this.txturunara.TextChanged += new System.EventHandler(this.txturunara_TextChanged);
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.dataGridView1);
            this.groupControl6.Location = new System.Drawing.Point(5, 129);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(735, 344);
            this.groupControl6.TabIndex = 3;
            this.groupControl6.Text = "ÜRÜNLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.BARKODNO,
            this.URUNADI,
            this.SATISFIYATI,
            this.ADET,
            this.KDV,
            this.TARIH,
            this.TOPTANCI,
            this.ALISFIYATI});
            this.dataGridView1.Location = new System.Drawing.Point(5, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // UID
            // 
            this.UID.DataPropertyName = "UID";
            this.UID.HeaderText = "*";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Width = 50;
            // 
            // BARKODNO
            // 
            this.BARKODNO.DataPropertyName = "BARKODNO";
            this.BARKODNO.HeaderText = "Barkod No";
            this.BARKODNO.Name = "BARKODNO";
            this.BARKODNO.ReadOnly = true;
            this.BARKODNO.Width = 200;
            // 
            // URUNADI
            // 
            this.URUNADI.DataPropertyName = "URUNADI";
            this.URUNADI.HeaderText = "Ürün Adı";
            this.URUNADI.Name = "URUNADI";
            this.URUNADI.ReadOnly = true;
            this.URUNADI.Width = 375;
            // 
            // SATISFIYATI
            // 
            this.SATISFIYATI.DataPropertyName = "SATISFIYATI";
            this.SATISFIYATI.HeaderText = "Fiyatı";
            this.SATISFIYATI.Name = "SATISFIYATI";
            this.SATISFIYATI.ReadOnly = true;
            this.SATISFIYATI.Width = 75;
            // 
            // ADET
            // 
            this.ADET.DataPropertyName = "ADET";
            this.ADET.HeaderText = "Stok";
            this.ADET.Name = "ADET";
            this.ADET.ReadOnly = true;
            this.ADET.Width = 50;
            // 
            // KDV
            // 
            this.KDV.DataPropertyName = "KDV";
            this.KDV.HeaderText = "Kdv\'si";
            this.KDV.Name = "KDV";
            this.KDV.ReadOnly = true;
            this.KDV.Width = 75;
            // 
            // TARIH
            // 
            this.TARIH.DataPropertyName = "TARIH";
            this.TARIH.HeaderText = "Tarih";
            this.TARIH.Name = "TARIH";
            this.TARIH.ReadOnly = true;
            this.TARIH.Width = 200;
            // 
            // TOPTANCI
            // 
            this.TOPTANCI.DataPropertyName = "TOPTANCI";
            this.TOPTANCI.HeaderText = "TEDARİKCİ";
            this.TOPTANCI.Name = "TOPTANCI";
            this.TOPTANCI.ReadOnly = true;
            this.TOPTANCI.Width = 200;
            // 
            // ALISFIYATI
            // 
            this.ALISFIYATI.DataPropertyName = "ALISFIYATI";
            this.ALISFIYATI.HeaderText = "";
            this.ALISFIYATI.Name = "ALISFIYATI";
            this.ALISFIYATI.ReadOnly = true;
            this.ALISFIYATI.Width = 50;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Controls.Add(this.textBox1);
            this.groupControl3.Location = new System.Drawing.Point(5, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(182, 100);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "BARKOD İLE ARA";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(5, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(168, 38);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "BARKODNO İLE ARA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 21);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.lblid);
            this.groupControl2.Controls.Add(this.txtid);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnUrunsil);
            this.groupControl2.Controls.Add(this.btnUrunekle);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtTarih);
            this.groupControl2.Controls.Add(this.txtToptanci);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txtKdv);
            this.groupControl2.Controls.Add(this.txtSatisfiyati);
            this.groupControl2.Controls.Add(this.txtAlisfiyati);
            this.groupControl2.Controls.Add(this.txtAdet);
            this.groupControl2.Controls.Add(this.txtUrunadi);
            this.groupControl2.Controls.Add(this.txtBarkodno);
            this.groupControl2.Location = new System.Drawing.Point(768, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(474, 478);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "ÜRÜN EKLEME";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(82, 441);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(322, 32);
            this.simpleButton5.TabIndex = 14;
            this.simpleButton5.Text = "Temizle (VAZGEÇ)";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(238, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "%";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(403, 285);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "label9";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(358, 307);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 21);
            this.txtid.TabIndex = 11;
            this.txtid.TabStop = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(317, 334);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(148, 101);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnUrunsil
            // 
            this.btnUrunsil.Appearance.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.btnUrunsil.Appearance.Options.UseFont = true;
            this.btnUrunsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunsil.ImageOptions.Image")));
            this.btnUrunsil.Location = new System.Drawing.Point(166, 334);
            this.btnUrunsil.Name = "btnUrunsil";
            this.btnUrunsil.Size = new System.Drawing.Size(145, 101);
            this.btnUrunsil.TabIndex = 8;
            this.btnUrunsil.Text = "SİL";
            this.btnUrunsil.Click += new System.EventHandler(this.btnUrunsil_Click);
            // 
            // btnUrunekle
            // 
            this.btnUrunekle.Appearance.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.btnUrunekle.Appearance.Options.UseFont = true;
            this.btnUrunekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunekle.ImageOptions.Image")));
            this.btnUrunekle.Location = new System.Drawing.Point(22, 334);
            this.btnUrunekle.Name = "btnUrunekle";
            this.btnUrunekle.Size = new System.Drawing.Size(138, 101);
            this.btnUrunekle.TabIndex = 7;
            this.btnUrunekle.Text = "EKLE";
            this.btnUrunekle.Click += new System.EventHandler(this.btnUrunekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(71, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "TARİH :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(37, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "TEDARİKCİ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(89, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "KDV :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(18, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "SATIŞ FİYATI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(95, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "A.F : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(78, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADET :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜN ADI :";
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTarih.Location = new System.Drawing.Point(145, 276);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(197, 26);
            this.txtTarih.TabIndex = 7;
            this.txtTarih.TabStop = false;
            this.txtTarih.TextChanged += new System.EventHandler(this.txtTarih_TextChanged);
            // 
            // txtToptanci
            // 
            this.txtToptanci.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtToptanci.Location = new System.Drawing.Point(145, 244);
            this.txtToptanci.Multiline = true;
            this.txtToptanci.Name = "txtToptanci";
            this.txtToptanci.Size = new System.Drawing.Size(260, 26);
            this.txtToptanci.TabIndex = 6;
            this.txtToptanci.Enter += new System.EventHandler(this.txtToptanci_Enter);
            this.txtToptanci.Leave += new System.EventHandler(this.txtToptanci_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "BARKOD NO :";
            // 
            // txtKdv
            // 
            this.txtKdv.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtKdv.Location = new System.Drawing.Point(145, 210);
            this.txtKdv.Multiline = true;
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(87, 26);
            this.txtKdv.TabIndex = 5;
            this.txtKdv.Enter += new System.EventHandler(this.txtKdv_Enter);
            this.txtKdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKdv_KeyPress);
            this.txtKdv.Leave += new System.EventHandler(this.txtKdv_Leave);
            // 
            // txtSatisfiyati
            // 
            this.txtSatisfiyati.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSatisfiyati.Location = new System.Drawing.Point(145, 178);
            this.txtSatisfiyati.Multiline = true;
            this.txtSatisfiyati.Name = "txtSatisfiyati";
            this.txtSatisfiyati.Size = new System.Drawing.Size(87, 26);
            this.txtSatisfiyati.TabIndex = 4;
            this.txtSatisfiyati.Enter += new System.EventHandler(this.txtSatisfiyati_Enter);
            this.txtSatisfiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisfiyati_KeyPress);
            this.txtSatisfiyati.Leave += new System.EventHandler(this.txtSatisfiyati_Leave);
            // 
            // txtAlisfiyati
            // 
            this.txtAlisfiyati.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAlisfiyati.Location = new System.Drawing.Point(145, 146);
            this.txtAlisfiyati.Multiline = true;
            this.txtAlisfiyati.Name = "txtAlisfiyati";
            this.txtAlisfiyati.Size = new System.Drawing.Size(87, 26);
            this.txtAlisfiyati.TabIndex = 3;
            this.txtAlisfiyati.TextChanged += new System.EventHandler(this.txtAlisfiyati_TextChanged);
            this.txtAlisfiyati.Enter += new System.EventHandler(this.txtAlisfiyati_Enter);
            this.txtAlisfiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlisfiyati_KeyPress);
            this.txtAlisfiyati.Leave += new System.EventHandler(this.txtAlisfiyati_Leave);
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAdet.Location = new System.Drawing.Point(145, 114);
            this.txtAdet.Multiline = true;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(87, 26);
            this.txtAdet.TabIndex = 2;
            this.txtAdet.Enter += new System.EventHandler(this.txtAdet_Enter);
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            this.txtAdet.Leave += new System.EventHandler(this.txtAdet_Leave);
            // 
            // txtUrunadi
            // 
            this.txtUrunadi.Font = new System.Drawing.Font("Turkish Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunadi.Location = new System.Drawing.Point(145, 82);
            this.txtUrunadi.Multiline = true;
            this.txtUrunadi.Name = "txtUrunadi";
            this.txtUrunadi.Size = new System.Drawing.Size(260, 26);
            this.txtUrunadi.TabIndex = 1;
            this.txtUrunadi.TextChanged += new System.EventHandler(this.txtUrunadi_TextChanged);
            this.txtUrunadi.Enter += new System.EventHandler(this.txtUrunadi_Enter);
            this.txtUrunadi.Leave += new System.EventHandler(this.txtUrunadi_Leave);
            // 
            // txtBarkodno
            // 
            this.txtBarkodno.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBarkodno.Location = new System.Drawing.Point(145, 50);
            this.txtBarkodno.Name = "txtBarkodno";
            this.txtBarkodno.Size = new System.Drawing.Size(260, 24);
            this.txtBarkodno.TabIndex = 0;
            this.txtBarkodno.Enter += new System.EventHandler(this.txtBarkodno_Enter);
            this.txtBarkodno.Leave += new System.EventHandler(this.txtBarkodno_Leave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.Appearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1253, 502);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "ÜRÜN EKLEME EKRANI";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtToptanci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtSatisfiyati;
        private System.Windows.Forms.TextBox txtAlisfiyati;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtUrunadi;
        private System.Windows.Forms.TextBox txtBarkodno;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnUrunsil;
        private DevExpress.XtraEditors.SimpleButton btnUrunekle;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btnBesaz;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txturunara;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton btnGizle;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARKODNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUNADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SATISFIYATI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADET;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPTANCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALISFIYATI;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}