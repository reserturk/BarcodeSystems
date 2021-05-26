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
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("PROGRAMI KAPATMAK ÜZERESİNİZ... :::: !!! ", "HOOOOOOOOPSSS   DİKKAT", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
        Form3 fr3;
        Form4 fr4;
        Form5 fr5;
        Form6 fr6;
        
        private void btnUrunekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr3 = new Form3();
            fr3.MdiParent = this;
            fr3.Show();
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr4 = new Form4();
            fr4.MdiParent = this;
            fr4.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr5 = new Form5();
            fr5.MdiParent = this;
            fr5.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            fr6 = new Form6();
            fr6.MdiParent = this;
            fr6.Show();

        }
    }
}