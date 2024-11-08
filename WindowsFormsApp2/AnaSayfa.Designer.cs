using System;
using System.ComponentModel;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WindowsFormsApp2
{
    partial class AnaSayfa
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.gunaPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCalisanGiris = new Guna.UI2.WinForms.Guna2Button();
            this.btnKargoTakibi = new Guna.UI2.WinForms.Guna2Button();
            this.btnGirisYap = new Guna.UI2.WinForms.Guna2Button();
            this.btnHesapOlustur = new Guna.UI2.WinForms.Guna2Button();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.Controls.Add(this.btnCalisanGiris);
            this.gunaPanel1.Controls.Add(this.btnKargoTakibi);
            this.gunaPanel1.Controls.Add(this.btnGirisYap);
            this.gunaPanel1.Controls.Add(this.btnHesapOlustur);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(984, 571);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnCalisanGiris
            // 
            this.btnCalisanGiris.AutoRoundedCorners = true;
            this.btnCalisanGiris.BorderRadius = 12;
            this.btnCalisanGiris.FillColor = System.Drawing.Color.Transparent;
            this.btnCalisanGiris.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalisanGiris.ForeColor = System.Drawing.Color.White;
            this.btnCalisanGiris.Location = new System.Drawing.Point(495, 35);
            this.btnCalisanGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalisanGiris.Name = "btnCalisanGiris";
            this.btnCalisanGiris.Size = new System.Drawing.Size(133, 26);
            this.btnCalisanGiris.TabIndex = 3;
            this.btnCalisanGiris.Text = "Çalışan Giriş";
            this.btnCalisanGiris.Click += new System.EventHandler(this.btnCalisanGiris_Click);
            // 
            // btnKargoTakibi
            // 
            this.btnKargoTakibi.AutoRoundedCorners = true;
            this.btnKargoTakibi.BorderRadius = 12;
            this.btnKargoTakibi.FillColor = System.Drawing.Color.Transparent;
            this.btnKargoTakibi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKargoTakibi.ForeColor = System.Drawing.Color.White;
            this.btnKargoTakibi.Location = new System.Drawing.Point(632, 34);
            this.btnKargoTakibi.Margin = new System.Windows.Forms.Padding(2);
            this.btnKargoTakibi.Name = "btnKargoTakibi";
            this.btnKargoTakibi.Size = new System.Drawing.Size(133, 27);
            this.btnKargoTakibi.TabIndex = 2;
            this.btnKargoTakibi.Text = "Kargo Takibi";
            this.btnKargoTakibi.Click += new System.EventHandler(this.btnKargoTakibi_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Animated = true;
            this.btnGirisYap.AnimatedGIF = true;
            this.btnGirisYap.AutoRoundedCorners = true;
            this.btnGirisYap.BorderRadius = 12;
            this.btnGirisYap.FillColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(221, 34);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(2);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(133, 27);
            this.btnGirisYap.TabIndex = 1;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.AutoRoundedCorners = true;
            this.btnHesapOlustur.BorderRadius = 12;
            this.btnHesapOlustur.FillColor = System.Drawing.Color.Transparent;
            this.btnHesapOlustur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapOlustur.ForeColor = System.Drawing.Color.White;
            this.btnHesapOlustur.Location = new System.Drawing.Point(358, 34);
            this.btnHesapOlustur.Margin = new System.Windows.Forms.Padding(2);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(133, 27);
            this.btnHesapOlustur.TabIndex = 0;
            this.btnHesapOlustur.Text = "Hesap Oluştur";
            this.btnHesapOlustur.Click += new System.EventHandler(this.btnHesapOlustur_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 571);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna2Panel gunaPanel1;
        private Guna2Button btnHesapOlustur;
        private Guna2Button btnGirisYap;
        private Guna2Button btnKargoTakibi;
        private Guna2Button btnCalisanGiris;
    }
}
