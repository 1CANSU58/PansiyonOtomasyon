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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=AycicekPansiyon;Integrated Security=True;");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gidalar"].ToString();
                ekle.SubItems.Add(oku["Icecekler"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = oku2["Elektrik"].ToString();
                ekle2.SubItems.Add(oku2["Su"].ToString());
                ekle2.SubItems.Add(oku2["Internet"].ToString());
                listView2.Items.Add(ekle2);
            }
            baglanti.Close();
        }

        private void btnKayitet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gidalar, Icecekler, Cerezler) values ('" + txtGida1.Text + "', '" + txtIcecek1.Text + "', '" + txtAtistirmalik1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            lblStokkayit1.Visible = true ;
            listView1.Items.Clear();
            veriler() ;
            txtGida1.Clear();
            txtIcecek1.Clear();
            txtAtistirmalik1.Clear();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            lblStokkayit1.Visible = false;
            lblStokkayit2.Visible = false;
            veriler();
            veriler2();
        }

        private void btnKayitet3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektrik, Su, Internet) values ('" + txtElektrik1.Text + "', '" + txtSu1.Text + "', '" + txtInternet1.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            lblStokkayit2.Visible = true;
            listView2.Items.Clear();
            veriler2();
            txtElektrik1.Clear();
            txtSu1.Clear();
            txtInternet1.Clear();
        }
    }
}
