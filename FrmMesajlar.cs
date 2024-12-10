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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source =.; Initial Catalog = AycicekPansiyon; Integrated Security = True;");

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesaj_id"].ToString();
                ekle.SubItems.Add(oku["Mesaj_adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaji"].ToString());


                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btnKayitet4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar (Mesaj_adsoyad, Mesaji) values ('" + txtAdsoyad.Text + "', '" + rtbMesaj.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            verilergoster();
            txtAdsoyad.Text = "";
            rtbMesaj.Text = "";
            MessageBox.Show("Mesaj Başarıyla Kayıt Edildi");
            verilergoster() ;
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilergoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdsoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            rtbMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
