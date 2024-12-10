using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonOtomasyon
{
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //KRAL FM
            axWindowsMediaPlayer1.URL = "http://46.20.3.204/;type = mp3";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //PINAR FM SAKARYA
            axWindowsMediaPlayer1.URL = "http://95.173.162.182:9882/;";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //DENIZLI DOSTLAR FM
            axWindowsMediaPlayer1.URL = "http://95.173.188.166:9848/;";
        }
    }
}
