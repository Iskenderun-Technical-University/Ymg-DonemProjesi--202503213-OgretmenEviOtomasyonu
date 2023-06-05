using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogretmen_Evi_Otomasyonu
{
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
        }

        private void BtnSözcü_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void BtnHaberTürk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void BtnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void BtnMilliGazete_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milligazete.com.tr/");
        }

        private void BtnSabah_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sabah.com.tr/");
        }
    }
}
