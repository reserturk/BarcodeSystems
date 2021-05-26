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
    public partial class Form4 : DevExpress.XtraEditors.XtraForm
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        DataTable dataTable = new DataTable();

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (textBox1.Text == dataTable.Rows[i][1].ToString()) 
                {
                    if (DataGridView_VeriKontrol(Convert.ToInt64(textBox1.Text)) != -1) 
                    {
                       dataGridView1.Rows[Convert.ToInt32(DataGridView_VeriKontrol(Convert.ToInt64(textBox1.Text)))].Cells[4].Value = adetHesapla(Convert.ToInt32(DataGridView_VeriKontrol(Convert.ToInt64(textBox1.Text))));
                      
                  
                    }
                    else
                    {
                        dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], 1);
                    }
                    fiyatHesapla();
                    textBox1.Clear();
                }
            }
        }
          
          public int adetHesapla(int row)
        {
     
                if (Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value) > 0)
                    return Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value) + 1;
                else
                    return 1;
         
        }
        private void fiyatHesapla() 
        {
            double toplamFiyat = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
              
                toplamFiyat += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                
            }
            string tut = "";
            tut= string.Format("{0:0.00}", Math.Round(toplamFiyat, 2));
            lblTutar.Text = tut + " ₺";


        }
        public void stokeksilt()
        {
            int eksilt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                eksilt -= Convert.ToInt32(dataGridView1.Rows[i].Cells["ADET"].Value) - Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
        }

        private void Form4_Load(object sender, EventArgs e) 
        {
            
            Sqlbaglantisi sqlbaglan = new Sqlbaglantisi();
            OleDbConnection conn = sqlbaglan.baglanti();

            OleDbCommand sqlCommand = new OleDbCommand("SELECT UID,BARKODNO,URUNADI,SATISFIYATI FROM tblUrunler", conn);
            OleDbDataReader veri = sqlCommand.ExecuteReader();
            dataTable.Columns.Add("UID", typeof(int));
            dataTable.Columns.Add("BARKODNO", typeof(string));
            dataTable.Columns.Add("URUNADI", typeof(string));
            dataTable.Columns.Add("SATISFIYATI", typeof(decimal));
            while (veri.Read())
            {
                dataTable.Rows.Add(Convert.ToInt32(veri[0]), veri[1].ToString(), veri[2].ToString(), Convert.ToDecimal(veri[3]));
            }
            lblTutar.Text = "0 ₺";
            dataGridView1.Columns["SATISFIYATI"].DefaultCellStyle.Format = "C2";
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.GreenYellow;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.GreenYellow;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri Light", 9,FontStyle.Bold);
            lblKredi.Visible = false;
            lblNakit.Visible = false;
            lblVeresiye.Visible = false;
            lblTarih.Visible = false;
            timer1.Interval = 1000;
            timer1.Start();
            textBox1.Focus();
            

        }
        private void baglantiAc()
        {
            Sqlbaglantisi sqlbaglan = new Sqlbaglantisi();
            OleDbConnection baglanti = sqlbaglan.baglanti();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        
        public void pvnakit()
        {
            string nbarkod, nurun;
            int  nadet;
            decimal nfiyat;
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    nbarkod = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    nurun = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    //nfiyat = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    nfiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    nadet = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into tblSatis (SBARKOD,SURUN,SFIYAT,SADET,SKASA,STARIH)" +
                             " values (@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                    komut.Parameters.AddWithValue("@p2", nbarkod);
                    komut.Parameters.AddWithValue("@p3", nurun.ToString());
                    komut.Parameters.AddWithValue("@p4", nfiyat.ToString());
                    komut.Parameters.AddWithValue("@p5", nadet.ToString());
                    komut.Parameters.AddWithValue("@p6", lblNakit.Text);
                    komut.Parameters.AddWithValue("@p7", lblTarih.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    textBox1.Focus();

                }
                dataGridView1.Rows.Clear();
                lblTutar.Text = "0 ₺";
                MessageBox.Show("( NAKİT ) SATIŞ GERÇEKLEŞTİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("( NAKİT ) SATIŞ BAŞARISIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        public void pvkredi()
        {
            string nbarkod, nurun;
            int  nadet;
            decimal nfiyat;
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    nbarkod = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    nurun = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    // nfiyat = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    nfiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    nadet = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into tblSatis (SBARKOD,SURUN,SFIYAT,SADET,SKASA,STARIH)" +
                             " values (@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                    komut.Parameters.AddWithValue("@p2", nbarkod);
                    komut.Parameters.AddWithValue("@p3", nurun.ToString());
                    komut.Parameters.AddWithValue("@p4", nfiyat.ToString());
                    komut.Parameters.AddWithValue("@p5", nadet.ToString());
                    komut.Parameters.AddWithValue("@p6", lblKredi.Text);
                    komut.Parameters.AddWithValue("@p7", lblTarih.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    textBox1.Focus();

                }
                dataGridView1.Rows.Clear();
                lblTutar.Text = "0 ₺";
                MessageBox.Show("( Kredi Kartı ) SATIŞ GERÇEKLEŞTİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("( Kredi Kartı ) SATIŞ BAŞARISIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void pvveresiye()
        {
            string nbarkod, nurun;
            int  nadet;
            decimal nfiyat;
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    nbarkod = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    nurun = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    // nfiyat =Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    nfiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    nadet = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into tblSatis (SBARKOD,SURUN,SFIYAT,SADET,SKASA,STARIH)" +
                             " values (@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                    komut.Parameters.AddWithValue("@p2", nbarkod);
                    komut.Parameters.AddWithValue("@p3", nurun.ToString());
                    komut.Parameters.AddWithValue("@p4", nfiyat.ToString());
                    komut.Parameters.AddWithValue("@p5", nadet.ToString());
                    komut.Parameters.AddWithValue("@p6", lblVeresiye.Text);
                    komut.Parameters.AddWithValue("@p7", lblTarih.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    textBox1.Focus();

                }
                dataGridView1.Rows.Clear();
                lblTutar.Text = "0 ₺";
                MessageBox.Show("( Veresiye ) SATIŞ GERÇEKLEŞTİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("( Veresiye ) SATIŞ BAŞARISIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void btnNakit_Click(object sender, EventArgs e)
        {
           
                if (dataGridView1.CurrentCell != null)
                {
                    int id = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        int adet = Convert.ToInt32(dataGridView1.Rows[i].Cells["ADET"].Value);
                        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                        OleDbCommand eksilt = new OleDbCommand("update  tblUrunler set ADET=ADET-" + adet + " where UID=" + id + "", baglanti);
                        eksilt.Parameters.AddWithValue("@UID", id);
                        eksilt.Parameters.AddWithValue("@ADET", adet);
                        eksilt.ExecuteNonQuery();
                        baglanti.Close();
                    textBox1.Focus();
                }
                pvnakit();
                    
                }
                else
                {
                    MessageBox.Show("ÜRÜN GİRİNİZ..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

   
        long DataGridView_VeriKontrol(long barkodno)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox1.Text)
                    return i;
            }
            return -1;  
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            lblTutar.Text = "0 ₺";
            textBox1.Focus();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                if
                              (dataGridView1.SelectedRows.Count > 0)

                {

                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                }

                else

                {

                    MessageBox.Show("Lüffen Silinecek Satırı Seçin!");

                }
                fiyatHesapla();
                textBox1.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Silinecek Ürünü Seçin "+ex);
            }
           
        }

        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int id = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    int adet = Convert.ToInt32(dataGridView1.Rows[i].Cells["ADET"].Value);
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    OleDbCommand eksilt = new OleDbCommand("update  tblUrunler set ADET=ADET-" + adet + " where UID=" + id + "", baglanti);
                    eksilt.Parameters.AddWithValue("@UID", id);
                    eksilt.Parameters.AddWithValue("@ADET", adet);
                    eksilt.ExecuteNonQuery();
                    baglanti.Close();
                    textBox1.Focus();
                }
                pvveresiye();

            }
            else
            {
                MessageBox.Show("ÜRÜN GİRİNİZ..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKredi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int id = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    int adet = Convert.ToInt32(dataGridView1.Rows[i].Cells["ADET"].Value);
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    OleDbCommand eksilt = new OleDbCommand("update  tblUrunler set ADET=ADET-" + adet + " where UID=" + id + "", baglanti);
                     eksilt.Parameters.AddWithValue("@UID", id);
                    eksilt.Parameters.AddWithValue("@ADET", adet);
                    eksilt.ExecuteNonQuery();
                    baglanti.Close();
                    textBox1.Focus();
                }
                pvkredi();

            }
            else
            {
                MessageBox.Show("ÜRÜN GİRİNİZ..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = SystemColors.Window;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int deger = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ADET"].Value);
            txtSAdet.Text = deger.ToString();
        }

        private void txtSAdet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
              
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = txtSAdet.Text;
                        
                    }
                }


               /* double toplamFiyat = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    toplamFiyat += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDouble(txtSAdet.Text);

                }
                string tut = "";
                tut = string.Format("{0:0.00}", Math.Round(toplamFiyat, 2));
                lblTutar.Text = tut + " ₺";
                */





                
                dataGridView1.Enabled = false;
                dataGridView1.Enabled = true;
                dataGridView1.Refresh();
                txtSAdet.Clear();
                fiyatHesapla();
                baglanti.Close();

                textBox1.Focus();
                textBox1.Clear();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex+"   Adet Butonundaki hata alamaktadır.  ");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
