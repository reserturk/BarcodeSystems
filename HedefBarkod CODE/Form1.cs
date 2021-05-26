using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HedefBarkod
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.Focus();
            
        }
        
        OleDbDataReader dr;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
            OleDbCommand cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "Select * from tblAdmin where KULLANICI='" + txtKullanici.Text + "' AND SIFRE='" + txtSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 f2 = new Form2();
                
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ");
            }
            baglanti.Close();
        }

       
    }
}
