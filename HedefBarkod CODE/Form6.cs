using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HedefBarkod
{
    public partial class Form6 : DevExpress.XtraEditors.XtraForm
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        Font Baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font yazi = new Font("Verdana", 12);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sformat = new StringFormat();
            sformat.Alignment = StringAlignment.Near;

            e.Graphics.DrawString("hesap" , Baslik,sb,200,150);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            ppDiyalog.ShowDialog();
        }

       
    }
}