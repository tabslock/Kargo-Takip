using WindowsFormsApp2;

partial class GirisYapForm
{
    private Guna.UI2.WinForms.Guna2TextBox txtEmail;
    private Guna.UI2.WinForms.Guna2TextBox txtSifre;
    private Guna.UI2.WinForms.Guna2Button btnGirisYap;
    private Guna.UI2.WinForms.Guna2CheckBox chkBeniHatirla;
    private Guna.UI2.WinForms.Guna2Button btnAnaSayfa;

    private void InitializeComponent()
    {
        this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
        this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
        this.btnGirisYap = new Guna.UI2.WinForms.Guna2Button();
        this.chkBeniHatirla = new Guna.UI2.WinForms.Guna2CheckBox();
        this.btnAnaSayfa = new Guna.UI2.WinForms.Guna2Button();

        // 
        // txtEmail
        // 
        this.txtEmail.PlaceholderText = "Email";
        this.txtEmail.Location = new System.Drawing.Point(50, 50);
        this.txtEmail.Size = new System.Drawing.Size(200, 36);

        // 
        // txtSifre
        // 
        this.txtSifre.PlaceholderText = "Şifre";
        this.txtSifre.PasswordChar = '*';
        this.txtSifre.Location = new System.Drawing.Point(50, 100);
        this.txtSifre.Size = new System.Drawing.Size(200, 36);

        // 
        // btnGirisYap
        // 
        this.btnGirisYap.Text = "Giriş Yap";
        this.btnGirisYap.Location = new System.Drawing.Point(50, 190);
        this.btnGirisYap.Size = new System.Drawing.Size(200, 45);
        this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);

        // 
        // chkBeniHatirla
        // 
        this.chkBeniHatirla.Text = "Beni Hatırla";
        this.chkBeniHatirla.Location = new System.Drawing.Point(50, 150);
        this.chkBeniHatirla.Size = new System.Drawing.Size(200, 20);

        // 
        // btnAnaSayfa
        // 
        this.btnAnaSayfa.Text = "Ana Sayfa";
        this.btnAnaSayfa.Location = new System.Drawing.Point(50, 250);
        this.btnAnaSayfa.Size = new System.Drawing.Size(200, 45);
        System.EventHandler value1 = (s, e) =>
                        {
                            new AnaSayfa().Show();
                            this.Hide();
                        };
        System.EventHandler value = value1;
        this.btnAnaSayfa.Click += value;

        // 
        // GirisYapForm
        // 
        this.ClientSize = new System.Drawing.Size(300, 350);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtSifre);
        this.Controls.Add(this.btnGirisYap);
        this.Controls.Add(this.chkBeniHatirla);
        this.Controls.Add(this.btnAnaSayfa);
        this.Text = "Giriş Yap";
    }
}
