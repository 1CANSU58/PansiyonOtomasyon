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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=AycicekPansiyon;Integrated Security=True;");


        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where AdminKADI = @kullaniciadi AND AdminKSIFRE = @kullanicisifre";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", txtKullaniciad.Text.Trim());
                SqlParameter prm2 = new SqlParameter("kullanicisifre", txtKullanicisifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                baglanti.Close();
                if(dt.Rows.Count > 0)
                {
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }

            /*
            if (txtKullaniciad.Text == "admin" && txtKullanicisifre.Text == "12345")
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            */
        }
    }
}
