using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonOtomasyon
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=AycicekPansiyon;Integrated Security=True;");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //oda101
            baglanti.Open();
            SqlCommand komut101 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku101 = komut101.ExecuteReader();

            while (oku101.Read())
            {
                btnOda101.Text = oku101["oda_ad"].ToString() + " " + oku101["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
            }

            //oda102
            baglanti.Open();
            SqlCommand komut102 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku102 = komut102.ExecuteReader();

            while (oku102.Read())
            {
                btnOda101.Text = oku102["oda_ad"].ToString() + " " + oku102["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
            }

            //oda103
            baglanti.Open();
            SqlCommand komut103 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku103 = komut103.ExecuteReader();

            while (oku103.Read())
            {
                btnOda103.Text = oku103["oda_ad"].ToString() + " " + oku103["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
            }

            //oda104
            baglanti.Open();
            SqlCommand komut104 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku104 = komut104.ExecuteReader();

            while (oku104.Read())
            {
                btnOda104.Text = oku104["oda_ad"].ToString() + " " + oku104["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
            }

            //oda105
            baglanti.Open();
            SqlCommand komut105 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku105 = komut105.ExecuteReader();

            while (oku105.Read())
            {
                btnOda105.Text = oku105["oda_ad"].ToString() + " " + oku105["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
            }

            //oda106
            baglanti.Open();
            SqlCommand komut106 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku106 = komut106.ExecuteReader();

            while (oku106.Read())
            {
                btnOda106.Text = oku106["oda_ad"].ToString() + " " + oku106["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
            }

            //oda107
            baglanti.Open();
            SqlCommand komut107 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku107 = komut107.ExecuteReader();

            while (oku107.Read())
            {
                btnOda107.Text = oku107["oda_ad"].ToString() + " " + oku107["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
            }

            //oda108
            baglanti.Open();
            SqlCommand komut108 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku108 = komut108.ExecuteReader();

            while (oku108.Read())
            {
                btnOda108.Text = oku108["oda_ad"].ToString() + " " + oku108["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
            }

            //oda109
            baglanti.Open();
            SqlCommand komut109 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku109 = komut109.ExecuteReader();

            while (oku109.Read())
            {
                btnOda109.Text = oku109["oda_ad"].ToString() + " " + oku109["oda_soyad"];
            }
            baglanti.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
            }
        }
    }
}
