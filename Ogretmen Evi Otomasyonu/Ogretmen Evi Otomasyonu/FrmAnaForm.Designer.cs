
namespace Ogretmen_Evi_Otomasyonu
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.BtnKisiEkle = new System.Windows.Forms.Button();
            this.BtnOdalar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnAdminGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminGiris.Location = new System.Drawing.Point(12, 29);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(108, 77);
            this.BtnAdminGiris.TabIndex = 0;
            this.BtnAdminGiris.Text = "Admin Giriş";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.BtnAdminGiris_Click);
            // 
            // BtnKisiEkle
            // 
            this.BtnKisiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnKisiEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKisiEkle.Location = new System.Drawing.Point(185, 29);
            this.BtnKisiEkle.Name = "BtnKisiEkle";
            this.BtnKisiEkle.Size = new System.Drawing.Size(108, 77);
            this.BtnKisiEkle.TabIndex = 1;
            this.BtnKisiEkle.Text = "Kişi Ekle";
            this.BtnKisiEkle.UseVisualStyleBackColor = false;
            this.BtnKisiEkle.Click += new System.EventHandler(this.BtnKisiEkle_Click);
            // 
            // BtnOdalar
            // 
            this.BtnOdalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnOdalar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdalar.Location = new System.Drawing.Point(357, 29);
            this.BtnOdalar.Name = "BtnOdalar";
            this.BtnOdalar.Size = new System.Drawing.Size(108, 77);
            this.BtnOdalar.TabIndex = 2;
            this.BtnOdalar.Text = "Odalar";
            this.BtnOdalar.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(12, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 77);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(185, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 77);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(626, 452);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnOdalar);
            this.Controls.Add(this.BtnKisiEkle);
            this.Controls.Add(this.BtnAdminGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Button BtnKisiEkle;
        private System.Windows.Forms.Button BtnOdalar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}