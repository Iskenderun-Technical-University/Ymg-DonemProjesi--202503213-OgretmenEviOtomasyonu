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

            baglanti.Open();
            string sql = "select * from AdminGiris where Kullanici=@Kullanici AND Sifre=@Sifre";
            SqlParameter prm1 = new SqlParameter("Kullaici", TxtKullaniciAdi.Text.Trim());
            SqlParameter prm2 = new SqlParameter("Sifre", TxtSifre.Text.Trim());
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);

            //da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }


            else
            {

                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                baglanti.Close();
            }
           

        }
    }
}
