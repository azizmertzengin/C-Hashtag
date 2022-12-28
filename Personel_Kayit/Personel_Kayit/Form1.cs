using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=AZIZGAMING\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbSehir.SelectedIndex = 0;
            mskMaas.Text = "";
            txtMeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();

        }


        void listele()
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            cmbSehir.SelectedIndex = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.SelectedItem);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", lblDurum.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
            listele();
            temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lblDurum.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblDurum.Text = "False";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void lblDurum_TextChanged(object sender, EventArgs e)
        {
            if (lblDurum.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (lblDurum.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1, PerSoyad=@a2, PerSehir=@a3, PerMaas=@a4, PerDurum=@a5, PerMeslek=@a6 where Perid=@a7",baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", lblDurum.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgisi Güncellendi");
            listele();
            temizle();
        }
    }
}
