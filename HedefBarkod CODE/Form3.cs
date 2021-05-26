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
    public partial class Form3 : DevExpress.XtraEditors.XtraForm
    {
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Data.accdb");
        public Form3()
        {
            InitializeComponent();
        }
        void listele() {
            baglantiAc();
            string kayit = "SELECT UID,BARKODNO,URUNADI,SATISFIYATI,ADET,KDV,TARIH,TOPTANCI,ALISFIYATI from tblUrunler";
            OleDbCommand komut = new OleDbCommand(kayit, baglanti);
            DataTable tablo = new DataTable();
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        private void baglantiAc()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        bool durum;
        void mukerrer()
        {

            baglantiAc();
            OleDbCommand kmt = new OleDbCommand("select * from tblUrunler where BARKODNO=@p1", baglanti);
            kmt.Parameters.AddWithValue("@p1", txtBarkodno.Text);
            OleDbDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        private void btnUrunekle_Click(object sender, EventArgs e)
        {
            try
            {
                mukerrer();
                if (durum == true)
                {
                    baglantiAc();
                    OleDbCommand komut = new OleDbCommand("insert into tblUrunler (BARKODNO,URUNADI,ADET,ALISFIYATI,SATISFIYATI,TOPTANCI,TARIH,KDV)" +
                        " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtBarkodno.Text);
                    komut.Parameters.AddWithValue("@p2", txtUrunadi.Text);
                    komut.Parameters.AddWithValue("@p3", int.Parse(txtAdet.Text).ToString());
                    komut.Parameters.AddWithValue("@p4", txtAlisfiyati.Text.ToString());
                    komut.Parameters.AddWithValue("@p5", txtSatisfiyati.Text.ToString());
                    komut.Parameters.AddWithValue("@p6", txtToptanci.Text);
                    komut.Parameters.AddWithValue("@p7", txtTarih.Text);
                    komut.Parameters.AddWithValue("@p8", int.Parse(txtKdv.Text).ToString());
                    komut.ExecuteNonQuery();
                    listele();
                    baglanti.Close();
                    txtBarkodno.Clear();
                    txtUrunadi.Clear();
                    txtAdet.Clear();
                    txtAlisfiyati.Clear();
                    txtToptanci.Clear();
                    txtSatisfiyati.Clear();
                    txtKdv.Clear();
                    txtBarkodno.Focus();
                }
                else
                {
                    MessageBox.Show("Bu Ürün Zaten Var ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBarkodno.Clear();
                    txtUrunadi.Clear();
                    txtAdet.Clear();
                    txtAlisfiyati.Clear();
                    txtToptanci.Clear();
                    txtSatisfiyati.Clear();
                    txtKdv.Clear();
                    txtBarkodno.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Birşeyler ters gitti..", "HOOOOPS HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Test"+ex);

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            dataGridView1.Columns["SATISFIYATI"].DefaultCellStyle.Format = "C2";
            listele();
            txtid.Visible = false;
            lblid.Visible = false;
            timer1.Interval = 1000;
            timer1.Start();
            txtBarkodno.Focus();

        }

        private void btnUrunsil_Click(object sender, EventArgs e)
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
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ÜRÜN EKLEME ALAN'IN DAKİ YAZI VE SAYILARI SİLİNİZ..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void KayıtSil(int numara)
        {
            string sql = "DELETE FROM tblUrunler WHERE UID=@numara";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@numara", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {


                baglantiAc();

                // SqlCommand komut = new SqlCommand("UPDATE tblUrunler SET UID='"+int.Parse(textBox1.Text)+"',BARKODNO='" + txtBarkodno.Text + "', URUNADI=" + txtUrunadi.Text + ", ADET='" + int.Parse(txtAdet.Text).ToString() + "',ALISFIYATI='" + decimal.Parse(txtAlisfiyati.Text).ToString() + "',SATISFIYATI='" + decimal.Parse(txtSatisfiyati.Text).ToString() + "',TOPTANCI='" + txtToptanci.Text + "',TARIH='" + txtTarih.Text + "',KDV='" + int.Parse(txtKdv.Text).ToString() + "'where UID='" +id+ "'",baglanti);
                OleDbCommand komut = new OleDbCommand("update tblUrunler set BARKODNO='" + txtBarkodno.Text + "',URUNADI='" + txtUrunadi.Text + "',ADET='" + txtAdet.Text + "',ALISFIYATI='" + txtAlisfiyati.Text + "',SATISFIYATI='" + txtSatisfiyati.Text + "',TOPTANCI='" + txtToptanci.Text + "',KDV='" + txtKdv.Text + "'where UID=" + txtid.Text + "", baglanti);
                komut.ExecuteNonQuery();
                listele();
                baglanti.Close();
                txtBarkodno.Clear();
                txtUrunadi.Clear();
                txtAdet.Clear();
                txtAlisfiyati.Clear();
                txtToptanci.Clear();
                txtSatisfiyati.Clear();
                txtKdv.Clear();
                txtBarkodno.Focus();


            }
            catch (Exception)
            {

                MessageBox.Show("EKSİK BİRŞEYLER VAR.....", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            baglantiAc();
            txtid.Text = dataGridView1.CurrentRow.Cells["UID"].Value.ToString();
            txtBarkodno.Text = dataGridView1.CurrentRow.Cells["BARKODNO"].Value.ToString();
            txtUrunadi.Text = dataGridView1.CurrentRow.Cells["URUNADI"].Value.ToString();
            txtSatisfiyati.Text = dataGridView1.CurrentRow.Cells["SATISFIYATI"].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells["ADET"].Value.ToString();
            txtKdv.Text = dataGridView1.CurrentRow.Cells["KDV"].Value.ToString();
            //txtTarih.Text = dataGridView1.CurrentRow.Cells["TARIH"].Value.ToString();
            txtToptanci.Text = dataGridView1.CurrentRow.Cells["TOPTANCI"].Value.ToString();
            txtAlisfiyati.Text = dataGridView1.CurrentRow.Cells["ALISFIYATI"].Value.ToString();
            lblid.Text = txtid.Text;
            baglanti.Close();
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible==true)
            {
                string bastan_arama = "SELECT * FROM tblUrunler WHERE BARKODNO LIKE '%" + textBox1.Text + "%'";
                OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                textBox1.Clear();
                textBox1.Focus();
                MessageBox.Show("ARAMA YAPMAK İÇİN LİSTEYİ GÖSTERİNİZ", "BİRŞEYLER TERS GİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        public void arama(string aranan)
        {
            //string sondan_arama = "select * from isimler where isim like'%" + aranan + "'";
            string bastan_arama = "select * from tblUrunler where BARKODNO like'" + aranan + "'%";
            //string ortadan_arama = "select * from isimler where isim like'%" + aranan + "%'";
            //hangi arama türünü kullancaksak onu seçeceğiz. Ben örnekte ortadan aramayı kullandım.
            OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;


        }

        private void txturunara_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible==true)
            {
                string bastan_arama = "SELECT * FROM tblUrunler WHERE URUNADI LIKE '%" + txturunara.Text + "%'";
                OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                txturunara.Clear();
                txturunara.Focus();
                MessageBox.Show("ARAMA YAPMAK İÇİN LİSTEYİ GÖSTERİNİZ", "BİRŞEYLER TERS GİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                
                try
                {
                    string bastan_arama = "SELECT * FROM tblUrunler WHERE ADET between -50 and 1";
                    OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
                    DataTable tablo = new DataTable();
                    adaptor.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("BİRŞEYLER TERS GİTTİ", "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView1.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("BİRŞEYLER TERS GİTTİ", "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnBesaz_Click(object sender, EventArgs e)
        {
            try
            {
                string bastan_arama = "SELECT * FROM tblUrunler WHERE ADET between 0 and 5";
                OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_arama, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView1.DataSource = tablo;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.GreenYellow;
                }
                dataGridView1.Visible = true;

            }
            catch (Exception)
            {

                MessageBox.Show("BİRŞEYLER TERS GİTTİ", "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            listele();
        }

        private void txtBarkodno_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void txtUrunadi_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void txtAdet_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void txtAlisfiyati_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void txtSatisfiyati_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void txtKdv_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void txtToptanci_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void txtBarkodno_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = SystemColors.Window;
        }

        private void txtUrunadi_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = SystemColors.Window;
        }

        private void txtAdet_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = SystemColors.Window;
        }

        private void txtAlisfiyati_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = SystemColors.Window;
        }

        private void txtSatisfiyati_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = SystemColors.Window;
        }

        private void txtKdv_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = SystemColors.Window;
        }

        private void txtToptanci_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = SystemColors.Window;
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtAlisfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
             {
                 e.Handled = false;
             }
             else if ((int)e.KeyChar == 8)
             {
                 e.Handled = false;
             }
             else
             {
                 e.Handled = true;
             }*/
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtSatisfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                /* if (e.KeyChar =="," && txtSatisfiyati.Text.IndexOf(",") > -1)
                 {
                     e.Handled = true;
                 }*/
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';

            }
            catch (Exception ex)
            {
                MessageBox.Show("Yazı Girmeyiniz. "+ex);

            }
        }

        private void txtKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
             {
                 e.Handled = false;
             }
             else if ((int)e.KeyChar == 8)
             {
                 e.Handled = false;
             }
             else
             {
                 e.Handled = true;
             }
            /*if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != '\b')
                    e.Handled = true;*/
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            txtBarkodno.Clear();
            txtUrunadi.Clear();
            txtAdet.Clear();
            txtAlisfiyati.Clear();
            txtToptanci.Clear();
            txtSatisfiyati.Clear();
            txtKdv.Clear();
            txtBarkodno.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUrunadi_TextChanged(object sender, EventArgs e)
        {
            TextBox txBox = (TextBox)sender;
            int pos = txBox.SelectionStart;
            int slen = txBox.SelectionLength;
            txBox.Text = txBox.Text.ToUpper();
            txBox.SelectionStart = pos;
            txBox.SelectionLength = slen;
            txBox.Focus();
        }

        private void txtAlisfiyati_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}