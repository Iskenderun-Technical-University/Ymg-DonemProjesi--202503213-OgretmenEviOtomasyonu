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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FURUKI\SQLEXPRESS01;Initial Catalog=Ogretmen Evi Otomasyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KisiEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kisiid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Kisi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = (listView1.SelectedItems[0].SubItems[1].Text);
            TxtSoyadi.Text = (listView1.SelectedItems[0].SubItems[2].Text);
            MskTxtTelefon.Text = (listView1.SelectedItems[0].SubItems[3].Text);
            MskTxtTCKimlikNo.Text = (listView1.SelectedItems[0].SubItems[4].Text);
            TxtMail.Text = (listView1.SelectedItems[0].SubItems[5].Text);
            TxtOdaNo.Text = (listView1.SelectedItems[0].SubItems[6].Text);
            DtpGirisTarihi.Text = (listView1.SelectedItems[0].SubItems[7].Text);
            DtpCikisTarihi.Text = (listView1.SelectedItems[0].SubItems[8].Text);
            CmbBoxKisi.Text = (listView1.SelectedItems[0].SubItems[9].Text);
            TxtUcret.Text = (listView1.SelectedItems[0].SubItems[10].Text);
            CmbBoxCinsiyet.Text = (listView1.SelectedItems[0].SubItems[11].Text);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            if (TxtOdaNo.Text == "101")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "102")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "103")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "201")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda201", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "202")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda202", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "203")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda203", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "301")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda301", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "302")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda302", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "303")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda303", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "401")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda401", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "402")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda402", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "403")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda403", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            MskTxtTelefon.Clear();
            MskTxtTCKimlikNo.Clear();
            TxtMail.Clear();
            TxtOdaNo.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
            CmbBoxKisi.Text = "";
            TxtUcret.Clear();
            CmbBoxCinsiyet.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update KisiEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Telefon='" + MskTxtTelefon + "',TC='" + MskTxtTCKimlikNo.Text + "',Mail='" + TxtMail.Text + "',OdaNo='" + TxtOdaNo.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "',Kisi='" + CmbBoxKisi.Text + "',Ucret='" + TxtUcret.Text + "',Cinsiyet='" + CmbBoxCinsiyet.Text + "'where Kisiid=(" + id + "')", baglanti);
            baglanti.Close();
            verilerigoster();
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KisiEkle where Adi like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kisiid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Kisi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
    }
}
