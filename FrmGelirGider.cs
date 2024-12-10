using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
//using System.Data.SqlClient;

namespace PansiyonOtomasyon
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=AycicekPansiyon;Integrated Security=True;");

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(MusteriUcret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasatoplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            if (txtGelirgider1.Text != "")
            {

                int personel;
                personel = Convert.ToInt16(txtGelirgider1.Text);
                lblPersonelmaas.Text = (personel * 1500).ToString();

                int sonuc;
                sonuc = Convert.ToInt32(lblKasatoplam.Text) - (Convert.ToInt32(lblPersonelmaas.Text) + Convert.ToInt32(lblAlinanurunler1.Text) + Convert.ToInt32(lblAlinanurunler2.Text) + Convert.ToInt32(lblAlinanurunler3.Text) + Convert.ToInt32(lblFaturalar1.Text) + Convert.ToInt32(lblFaturalar2.Text) +Convert.ToInt32(lblFaturalar3.Text));
                lblSonuc1.Text = sonuc.ToString();
            }
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            /*  KASADAKI TOPLAM TUTAR  */
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(MusteriUcret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasatoplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            /* GIDA GIDERLERI */
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gidalar) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlinanurunler1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            /* ICECEK GIDERLERI */
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Icecekler) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlinanurunler2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            /* CEREZ GIDERLERI */
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblAlinanurunler3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            /* ELEKTRIK GIDERLERI */
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFaturalar1.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            /* SU GIDERLERI */
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            /* INTERNET GIDERLERI */
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Internet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();


            /*
            int personel;
            personel = Convert.ToInt16(txtGelirgider1.Text);
            lblPersonelmaas.Text = (personel * 1500).ToString();
            */
        }
    }
}
