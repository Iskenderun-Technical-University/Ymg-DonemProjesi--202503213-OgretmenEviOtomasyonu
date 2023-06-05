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
using System.Security.Cryptography;

namespace Ogretmen_Evi_Otomasyonu
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=FURUKI\SQLEXPRESS01;Initial Catalog=Ogretmen Evi Otomasyon;Integrated Security=True");
        DataSet ds = new DataSet();
          public static string MD5Hash(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(text);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {

           if( TxtKullaniciAdi.Text=="umut" && TxtSifre.Text == "1234")
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
           

        }
    }
}
