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
using System.Data.OleDb;

namespace HedefBarkod
{
    public partial class Form5 : DevExpress.XtraEditors.XtraForm
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Data.accdb");
        private void baglantiAc()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        private void listele() {
            baglantiAc();
            string kayit = "SELECT * from tblSatis";
            OleDbCommand komut = new OleDbCommand(kayit, baglanti);
            DataTable tablo = new DataTable();
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblTarih.Visible = false;
            nowTarih();
            fiyatHesapla();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string nakit = "NAKİT";
                string bastan_arama = "SELECT * FROM tblSatis WHERE SKASA LIKE '%" + nakit + "%'";
                OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView1.DataSource = tablo;
                dataGridView1.Columns["SFIYAT"].DefaultCellStyle.Format = "C2";
                fiyatHesapla();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string kredi = "KREDİ KARTI";
                string bastan_arama = "SELECT * FROM tblSatis WHERE SKASA LIKE '%" + kredi + "%'";
                OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView1.DataSource = tablo;
                dataGridView1.Columns["SFIYAT"].DefaultCellStyle.Format = "C2";
                fiyatHesapla();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string veresiye = "VERESİYE";
                string bastan_arama = "SELECT * FROM tblSatis WHERE SKASA LIKE '%" + veresiye + "%'";
                OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView1.DataSource = tablo;
                dataGridView1.Columns["SFIYAT"].DefaultCellStyle.Format = "C2";
                fiyatHesapla();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns["SFIYAT"].DefaultCellStyle.Format = "C2";
            fiyatHesapla();
        }

       
        private void fiyatHesapla()
        {
            decimal toplamFiyat = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                toplamFiyat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            string tut = "";
            tut = string.Format("{0:0.00}", Math.Round(toplamFiyat, 2));
            lblTutar.Text = tut + " ₺";


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns["SFIYAT"].DefaultCellStyle.Format = "C2";
                string bastan_arama = "SELECT * FROM tblSatis WHERE STARIH LIKE '%" + dateTimePicker1.Value.ToLongDateString() + "%'";
                OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView1.DataSource = tablo;
                fiyatHesapla();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }

        }
        private void nowTarih()
        {
            lblTarih.Text = dateTimePicker1.Value.ToLongDateString();

            
            string bastan_arama = "SELECT * FROM tblSatis WHERE STARIH LIKE '%" + lblTarih.Text + "%'";
            OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns["SFIYAT"].DefaultCellStyle.Format = "C2";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("SEÇİLİ ÜRÜNÜ SİLECEKSİNİZ EMİN MİSİN... :::: !!! ", "BİLGİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                    {
                        int numara = Convert.ToInt32(drow.Cells[0].Value);
                        KayıtSil(numara);
                    }
                    listele();
                    fiyatHesapla();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ÜRÜN EKLEME ALAN'IN DAKİ YAZI VE SAYILARI SİLİNİZ..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void KayıtSil(int numara)
        {
            string sql = "DELETE FROM tblSatis WHERE SATISID=@numara";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@numara", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

     
    }
}