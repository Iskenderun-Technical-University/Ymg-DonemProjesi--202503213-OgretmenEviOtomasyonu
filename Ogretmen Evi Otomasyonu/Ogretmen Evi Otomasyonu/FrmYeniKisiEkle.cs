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

namespace Ogretmen_Evi_Otomasyonu
{
    public partial class FrmYeniKisiEkle : Form
    {
        public FrmYeniKisiEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FURUKI\SQLEXPRESS01;Initial Catalog=Ogretmen Evi Otomasyon;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void Btn201_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "201";
        }

        private void Btn202_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "202";
        }

        private void Btn203_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "203";
        }

        private void Btn301_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "301";
        }

        private void Btn302_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "302";
        }

        private void Btn303_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "303";
        }

        private void Btn401_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "401";
        }

        private void Btn402_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "402";
        }

        private void Btn403_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "403";
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Göstermektedir.");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Göstermektedir.");
        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;

            //Misafirler için ücret 400, öğretmenler için 250 lira olarak belirlenmiştir.

            label12.Text = sonuc.TotalDays.ToString();
            if(CmbBoxKisi.Text=="Öğretmen"){

                ucret = Convert.ToInt32(label12.Text) * 250;
                TxtUcret.Text = ucret.ToString();
            }
            else if(CmbBoxKisi.Text=="Misafir")
            {
                ucret = Convert.ToInt32(label12.Text) * 400;
                TxtUcret.Text = ucret.ToString();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KisiEkle (Adi,Soyadi,Telefon,TC,Mail,OdaNo,GirisTarihi,CikisTarihi,Kisi,Ucret,Cinsiyet) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + MskTxtTelefon.Text + "','" + MskTxtTCKimlikNo.Text + "','" + TxtMail.Text + "','" + TxtOdaNo.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + CmbBoxKisi.Text + "','" + TxtUcret.Text + "','" + CmbBoxCinsiyet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı başarıyla yapıldı.");

        }
    }
}
