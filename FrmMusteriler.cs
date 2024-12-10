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


namespace PansiyonOtomasyon
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        //Trust Server Certificate=True
        SqlConnection baglanti = new SqlConnection(@"Data Source =.; Initial Catalog = AycicekPansiyon; Integrated Security = True;");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["MusteriAD"].ToString());
                ekle.SubItems.Add(oku["MusteriSOYAD"].ToString());
                ekle.SubItems.Add(oku["MusteriCINSIYET"].ToString());
                ekle.SubItems.Add(oku["MusteriTELEFON"].ToString());
                ekle.SubItems.Add(oku["MusteriMAIL"].ToString());
                ekle.SubItems.Add(oku["MusteriTC"].ToString());
                ekle.SubItems.Add(oku["MusteriODANO"].ToString());
                ekle.SubItems.Add(oku["MusteriUCRET"].ToString());
                ekle.SubItems.Add(oku["MusteriGIRISTARIH"].ToString());
                ekle.SubItems.Add(oku["MusteriCIKISTARIH"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnMusterilerigetir_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msktxtTelefonu.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMaili.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTCsi.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdasi.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcreti.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGiristarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCikistarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

            DateTime KucukTarih = Convert.ToDateTime(dtpGiristarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikistarihi.Text);
            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label11.Text = "Gün : " + Sonuc.TotalDays.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set MusteriAD = '" + txtAdi.Text + "', MusteriSOYAD = '" + txtSoyadi.Text + "', MusteriCINSIYET = '" + cbCinsiyet.Text + "', MusteriTELEFON = '" + msktxtTelefonu.Text + "', MusteriMAIL = '" + txtMaili.Text + "', MusteriTC = '" + txtTCsi.Text + "', MusteriODANO = '" + txtOdasi.Text + "', MusteriUCRET = '" + txtUcreti.Text + "', MusteriGIRISTARIH = '" + DateTime.Parse(dtpGiristarihi.Text) + "', MusteriCIKISTARIH = '" + DateTime.Parse(dtpCikistarihi.Text) + "' where MusteriID = " + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            label11.Text = "Güncellendi";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOdasi.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 101 Silindi";
            }

            if (txtOdasi.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 102 Silindi";
            }

            if (txtOdasi.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 103 Silindi";
            }

            if (txtOdasi.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 104 Silindi";
            }

            if (txtOdasi.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 105 Silindi";
            }

            if (txtOdasi.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 106 Silindi";
            }

            if (txtOdasi.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 107 Silindi";
            }

            if (txtOdasi.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 108 Silindi";
            }

            if (txtOdasi.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109 where oda_ad = '" + txtAdi.Text + "' and oda_soyad = '" + txtSoyadi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                label11.Text = "Oda 109 Silindi";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where MusteriAD like '%" + txtISIM.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["MusteriAD"].ToString());
                ekle.SubItems.Add(oku["MusteriSOYAD"].ToString());
                ekle.SubItems.Add(oku["MusteriCINSIYET"].ToString());
                ekle.SubItems.Add(oku["MusteriTELEFON"].ToString());
                ekle.SubItems.Add(oku["MusteriMAIL"].ToString());
                ekle.SubItems.Add(oku["MusteriTC"].ToString());
                ekle.SubItems.Add(oku["MusteriODANO"].ToString());
                ekle.SubItems.Add(oku["MusteriUCRET"].ToString());
                ekle.SubItems.Add(oku["MusteriGIRISTARIH"].ToString());
                ekle.SubItems.Add(oku["MusteriCIKISTARIH"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cbCinsiyet.Text = "";
            msktxtTelefonu.Clear();
            txtMaili.Clear();
            txtTCsi.Clear();
            txtOdasi.Clear();
            txtUcreti.Clear();
            dtpGiristarihi.Text = "";
            dtpCikistarihi.Text = "";
            label11.Text = "Temizlendi";
        }
    }
}
