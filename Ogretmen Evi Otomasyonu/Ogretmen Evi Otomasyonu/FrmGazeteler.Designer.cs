
namespace Ogretmen_Evi_Otomasyonu
{
    partial class FrmGazeteler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGazeteler));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnFanatik = new System.Windows.Forms.Button();
            this.BtnSözcü = new System.Windows.Forms.Button();
            this.BtnHaberTürk = new System.Windows.Forms.Button();
            this.BtnMilliyet = new System.Windows.Forms.Button();
            this.BtnMilliGazete = new System.Windows.Forms.Button();
            this.BtnSabah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 72);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 32);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(689, 384);
            this.webBrowser1.TabIndex = 0;
            // 
            // BtnFanatik
            // 
            this.BtnFanatik.Location = new System.Drawing.Point(12, 12);
            this.BtnFanatik.Name = "BtnFanatik";
            this.BtnFanatik.Size = new System.Drawing.Size(110, 52);
            this.BtnFanatik.TabIndex = 1;
            this.BtnFanatik.Text = "Fanatik";
            this.BtnFanatik.UseVisualStyleBackColor = true;
            this.BtnFanatik.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSözcü
            // 
            this.BtnSözcü.Location = new System.Drawing.Point(128, 12);
            this.BtnSözcü.Name = "BtnSözcü";
            this.BtnSözcü.Size = new System.Drawing.Size(110, 52);
            this.BtnSözcü.TabIndex = 2;
            this.BtnSözcü.Text = "Sözcü";
            this.BtnSözcü.UseVisualStyleBackColor = true;
            this.BtnSözcü.Click += new System.EventHandler(this.BtnSözcü_Click);
            // 
            // BtnHaberTürk
            // 
            this.BtnHaberTürk.Location = new System.Drawing.Point(244, 12);
            this.BtnHaberTürk.Name = "BtnHaberTürk";
            this.BtnHaberTürk.Size = new System.Drawing.Size(110, 52);
            this.BtnHaberTürk.TabIndex = 3;
            this.BtnHaberTürk.Text = "HaberTürk";
            this.BtnHaberTürk.UseVisualStyleBackColor = true;
            this.BtnHaberTürk.Click += new System.EventHandler(this.BtnHaberTürk_Click);
            // 
            // BtnMilliyet
            // 
            this.BtnMilliyet.Location = new System.Drawing.Point(360, 12);
            this.BtnMilliyet.Name = "BtnMilliyet";
            this.BtnMilliyet.Size = new System.Drawing.Size(110, 52);
            this.BtnMilliyet.TabIndex = 4;
            this.BtnMilliyet.Text = "Milliyet";
            this.BtnMilliyet.UseVisualStyleBackColor = true;
            this.BtnMilliyet.Click += new System.EventHandler(this.BtnMilliyet_Click);
            // 
            // BtnMilliGazete
            // 
            this.BtnMilliGazete.Location = new System.Drawing.Point(476, 12);
            this.BtnMilliGazete.Name = "BtnMilliGazete";
            this.BtnMilliGazete.Size = new System.Drawing.Size(110, 52);
            this.BtnMilliGazete.TabIndex = 5;
            this.BtnMilliGazete.Text = "Milli Gazete";
            this.BtnMilliGazete.UseVisualStyleBackColor = true;
            this.BtnMilliGazete.Click += new System.EventHandler(this.BtnMilliGazete_Click);
            // 
            // BtnSabah
            // 
            this.BtnSabah.Location = new System.Drawing.Point(592, 12);
            this.BtnSabah.Name = "BtnSabah";
            this.BtnSabah.Size = new System.Drawing.Size(110, 52);
            this.BtnSabah.TabIndex = 6;
            this.BtnSabah.Text = "Sabah";
            this.BtnSabah.UseVisualStyleBackColor = true;
            this.BtnSabah.Click += new System.EventHandler(this.BtnSabah_Click);
            // 
            // FrmGazeteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(717, 470);
            this.Controls.Add(this.BtnSabah);
            this.Controls.Add(this.BtnMilliGazete);
            this.Controls.Add(this.BtnMilliyet);
            this.Controls.Add(this.BtnHaberTürk);
            this.Controls.Add(this.BtnSözcü);
            this.Controls.Add(this.BtnFanatik);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGazeteler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gazeteler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnFanatik;
        private System.Windows.Forms.Button BtnSözcü;
        private System.Windows.Forms.Button BtnHaberTürk;
        private System.Windows.Forms.Button BtnMilliyet;
        private System.Windows.Forms.Button BtnMilliGazete;
        private System.Windows.Forms.Button BtnSabah;
    }
}