namespace HedefBarkod
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUrunekle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.ExpandCollapseItem.AllowRightClickInMenu = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnUrunekle,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem1,
            this.barButtonItem4,
            this.barSubItem1,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barStaticItem4,
            this.barStaticItem5});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(826, 116);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnUrunekle
            // 
            this.btnUrunekle.Caption = "ÜRÜN EKLE";
            this.btnUrunekle.Id = 1;
            this.btnUrunekle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunekle.ImageOptions.SvgImage")));
            this.btnUrunekle.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUrunekle.ItemAppearance.Hovered.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunekle.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUrunekle.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btnUrunekle.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnUrunekle.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnUrunekle.ItemAppearance.Normal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunekle.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrunekle.ItemAppearance.Pressed.Font = new System.Drawing.Font("Courier New", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunekle.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUrunekle.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnUrunekle.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnUrunekle.Name = "btnUrunekle";
            this.btnUrunekle.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnUrunekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunekle_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "BARKOD SATIŞ";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Gainsboro;
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem2.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem2.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "SATIŞ KONTROL";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Gainsboro;
            this.barButtonItem3.ItemAppearance.Hovered.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem3.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barButtonItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Pressed.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem3.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem3.VisibleInSearchMenu = false;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MENÜLER";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunekle);
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem5);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "                   ";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "ETİKET OLUŞTUR";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.ItemAppearance.Hovered.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem4.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem4.ItemAppearance.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barButtonItem4.ItemAppearance.Pressed.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem4.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barButtonItem4.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem4.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem4.ItemInMenuAppearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barButtonItem4.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem4.ItemInMenuAppearance.Hovered.Options.UseForeColor = true;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 6;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "          ";
            this.barStaticItem1.Id = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "          ";
            this.barStaticItem2.Id = 8;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "          ";
            this.barStaticItem3.Id = 9;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "          ";
            this.barStaticItem4.Id = 10;
            this.barStaticItem4.Name = "barStaticItem4";
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Caption = "          ";
            this.barStaticItem5.Id = 11;
            this.barStaticItem5.Name = "barStaticItem5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 367);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnUrunekle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarStaticItem barStaticItem5;
    }
}