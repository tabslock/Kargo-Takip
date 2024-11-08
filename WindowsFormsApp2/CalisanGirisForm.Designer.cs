using WindowsFormsApp2;

partial class CalisanGirisForm
{
    private Guna.UI2.WinForms.Guna2TextBox txtKullaniciAdi;
    private Guna.UI2.WinForms.Guna2TextBox txtSifre;
    private Guna.UI2.WinForms.Guna2Button btnGirisYap;
    private Guna.UI2.WinForms.Guna2Button btnAnaSayfa;

    private void InitializeComponent()
    {
        this.txtKullaniciAdi = new Guna.UI2.WinForms.Guna2TextBox();
        this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
        this.btnGirisYap = new Guna.UI2.WinForms.Guna2Button();
        this.btnAnaSayfa = new Guna.UI2.WinForms.Guna2Button();

        // txtKullaniciAdi
        this.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
        this.txtKullaniciAdi.Location = new System.Drawing.Point(50, 50);
        this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 36);

        // txtSifre
        this.txtSifre.PlaceholderText = "Şifre";
        this.txtSifre.PasswordChar = '*';
        this.txtSifre.Location = new System.Drawing.Point(50, 100);
        this.txtSifre.Size = new System.Drawing.Size(200, 36);

        // btnGirisYap
        this.btnGirisYap.Text = "Giriş Yap";
        this.btnGirisYap.Location = new System.Drawing.Point(50, 150);
        this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);

        // btnAnaSayfa
        this.btnAnaSayfa.Text = "Ana Sayfa";
        this.btnAnaSayfa.Location = new System.Drawing.Point(50, 200);
        this.btnAnaSayfa.Click += (s, e) =>
        {
            new AnaSayfa().Show();
            this.Hide();
        };

        // CalisanGirisForm
        this.ClientSize = new System.Drawing.Size(300, 300);
        this.Controls.Add(this.txtKullaniciAdi);
        this.Controls.Add(this.txtSifre);
        this.Controls.Add(this.btnGirisYap);
        this.Controls.Add(this.btnAnaSayfa);
        this.Text = "Çalışan Giriş";
    }
}
