using System;
using Guna.UI2.WinForms;

namespace WindowsFormsApp2
{
    partial class KargoTakipForm
    {
        private Guna2TextBox txtTakipNo;
        private Guna2Button btnSorgula;
        private Guna2HtmlLabel lblDurum;
        private Guna2Button btnAnaSayfa;

        private void InitializeComponent()
        {
            this.txtTakipNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSorgula = new Guna.UI2.WinForms.Guna2Button();
            this.lblDurum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAnaSayfa = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtTakipNo
            // 
            this.txtTakipNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTakipNo.DefaultText = "";
            this.txtTakipNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTakipNo.Location = new System.Drawing.Point(50, 50);
            this.txtTakipNo.Name = "txtTakipNo";
            this.txtTakipNo.PasswordChar = '\0';
            this.txtTakipNo.PlaceholderText = "Takip Numarası";
            this.txtTakipNo.SelectedText = "";
            this.txtTakipNo.Size = new System.Drawing.Size(200, 36);
            this.txtTakipNo.TabIndex = 0;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSorgula.ForeColor = System.Drawing.Color.White;
            this.btnSorgula.Location = new System.Drawing.Point(50, 100);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(180, 45);
            this.btnSorgula.TabIndex = 1;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.Color.Transparent;
            this.lblDurum.Location = new System.Drawing.Point(50, 150);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 0);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = null;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfa.Location = new System.Drawing.Point(50, 200);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(180, 45);
            this.btnAnaSayfa.TabIndex = 3;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // KargoTakipForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 571);
            this.Controls.Add(this.txtTakipNo);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnAnaSayfa);
            this.Name = "KargoTakipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Takip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
