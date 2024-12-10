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
using System.Reflection.Emit;

namespace PansiyonOtomasyon
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=AycicekPansiyon;Integrated Security=True;");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set AdminKADI = '" + txtKullaniciad.Text + "', AdminKSIFRE = '" + txtKullanicisifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            lblSifre1.Visible = true;
            lblSifre1.Text = "Güncellendi";
            txtKullaniciad.Text = "";
            txtKullanicisifre.Text = "";
        }

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {
            lblSifre1.Visible = false;
        }
    }
}
