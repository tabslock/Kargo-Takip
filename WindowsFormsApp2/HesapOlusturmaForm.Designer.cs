partial class HesapOlusturmaForm
{
    private Guna.UI2.WinForms.Guna2TextBox txtAd;
    private Guna.UI2.WinForms.Guna2TextBox txtSoyad;
    private Guna.UI2.WinForms.Guna2TextBox txtEmail;
    private Guna.UI2.WinForms.Guna2TextBox txtSifre;
    private Guna.UI2.WinForms.Guna2TextBox txtTelefon;
    private Guna.UI2.WinForms.Guna2Button btnKayitOl;
    private Guna.UI2.WinForms.Guna2Button btnGirisYap;

    private void InitializeComponent()
    {
        this.txtAd = new Guna.UI2.WinForms.Guna2TextBox();
        this.txtSoyad = new Guna.UI2.WinForms.Guna2TextBox();
        this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
        this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
        this.txtTelefon = new Guna.UI2.WinForms.Guna2TextBox();
        this.btnKayitOl = new Guna.UI2.WinForms.Guna2Button();
        this.btnGirisYap = new Guna.UI2.WinForms.Guna2Button();

        // 
        // txtAd
        // 
        this.txtAd.PlaceholderText = "Ad";
        this.txtAd.Location = new System.Drawing.Point(50, 30);
        this.txtAd.Size = new System.Drawing.Size(200, 36);

        // 
        // txtSoyad
        // 
        this.txtSoyad.PlaceholderText = "Soyad";
        this.txtSoyad.Location = new System.Drawing.Point(50, 80);
        this.txtSoyad.Size = new System.Drawing.Size(200, 36);

        // 
        // txtEmail
        // 
        this.txtEmail.PlaceholderText = "Email";
        this.txtEmail.Location = new System.Drawing.Point(50, 130);
        this.txtEmail.Size = new System.Drawing.Size(200, 36);

        // 
        // txtSifre
        // 
        this.txtSifre.PlaceholderText = "Şifre";
        this.txtSifre.PasswordChar = '*';
        this.txtSifre.Location = new System.Drawing.Point(50, 180);
        this.txtSifre.Size = new System.Drawing.Size(200, 36);

        // 
        // txtTelefon
        // 
        this.txtTelefon.PlaceholderText = "Telefon Numarası";
        this.txtTelefon.Location = new System.Drawing.Point(50, 230);
        this.txtTelefon.Size = new System.Drawing.Size(200, 36);

        // 
        // btnKayitOl
        // 
        this.btnKayitOl.Text = "Kayıt Ol";
        this.btnKayitOl.Location = new System.Drawing.Point(50, 280);
        this.btnKayitOl.Size = new System.Drawing.Size(200, 45);
        this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);

        // 
        // btnGirisYap
        // 
        this.btnGirisYap.Text = "Giriş Yap";
        this.btnGirisYap.Location = new System.Drawing.Point(50, 340);
        this.btnGirisYap.Size = new System.Drawing.Size(200, 45);
        this.btnGirisYap.Click += (s, e) =>
        {
            new GirisYapForm().Show();
            this.Hide();
        };

        // 
        // HesapOlusturmaForm
        // 
        this.ClientSize = new System.Drawing.Size(300, 400);
        this.Controls.Add(this.txtAd);
        this.Controls.Add(this.txtSoyad);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtSifre);
        this.Controls.Add(this.txtTelefon);
        this.Controls.Add(this.btnKayitOl);
        this.Controls.Add(this.btnGirisYap);
        this.Text = "Hesap Oluşturma";
    }
}
