﻿using System;
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
    public partial class FrmYeniKisiEkle : Form
    {
        public FrmYeniKisiEkle()
        {
            InitializeComponent();
        }

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
    }
}