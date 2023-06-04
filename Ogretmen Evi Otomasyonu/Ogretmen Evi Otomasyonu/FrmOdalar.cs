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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FURUKI\SQLEXPRESS01;Initial Catalog=Ogretmen Evi Otomasyon;Integrated Security=True");
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //ODA101
            
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                Btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn101.Text != "101")
            {
                Btn101.BackColor = Color.Brown;
            }

            //ODA102

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                Btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn102.Text != "102")
            {
                Btn102.BackColor = Color.Brown;
            }

            //ODA103

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                Btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn103.Text != "103")
            {
                Btn103.BackColor = Color.Brown;
            }

            //ODA201

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                Btn201.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn201.Text != "201")
            {
                Btn201.BackColor = Color.Brown;
            }

            //ODA202

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                Btn202.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn202.Text != "202")
            {
                Btn202.BackColor = Color.Brown;
            }

            //ODA203

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                Btn203.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn203.Text != "203")
            {
                Btn203.BackColor = Color.Brown;
            }

            //ODA301

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda301", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                Btn301.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn301.Text != "301")
            {
                Btn301.BackColor = Color.Brown;
            }

            //ODA302

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda302", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                Btn302.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn302.Text != "302")
            {
                Btn302.BackColor = Color.Brown;
            }

            //ODA303

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda303", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                Btn303.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn303.Text != "303")
            {
                Btn303.BackColor = Color.Brown;
            }

            //ODA401

            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from Oda401", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();

            while (oku10.Read())
            {
                Btn401.Text = oku10["Adi"].ToString() + " " + oku10["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn401.Text != "401")
            {
                Btn401.BackColor = Color.Brown;
            }

            //ODA402

            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda402", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();

            while (oku11.Read())
            {
                Btn402.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn402.Text != "402")
            {
                Btn402.BackColor = Color.Brown;
            }

            //ODA403

            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("select * from Oda403", baglanti);
            SqlDataReader oku12 = komut12.ExecuteReader();

            while (oku12.Read())
            {
                Btn403.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString();
            }

            baglanti.Close();
            if (Btn403.Text != "403")
            {
                Btn403.BackColor = Color.Brown;
            }

        }
    }
}
