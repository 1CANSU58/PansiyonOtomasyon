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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void btnHurriyet1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.hurriyet.com.tr");
        }

        private void btnMilliyet1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.milliyet.com.tr");
        }

        private void btnSozcu1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sozcu.com.tr");
        }

        private void btnHaberTurk1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.haberturk.com");
        }

        private void btnFanatik1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.fanatik.com.tr");
        }

        private void btnOnedio1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.onedio.com/");
        }
    }
}
