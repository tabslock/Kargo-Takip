using System.Windows.Forms;

partial class KullaniciAnaSayfa
{
    private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
    private Guna.UI2.WinForms.Guna2HtmlLabel lblAd;
    private Guna.UI2.WinForms.Guna2TextBox txtTakipNo;
    private Guna.UI2.WinForms.Guna2Button btnSorgula;
    private Guna.UI2.WinForms.Guna2HtmlLabel lblGonderenAd;
    private Guna.UI2.WinForms.Guna2HtmlLabel lblAdres;
    private Guna.UI2.WinForms.Guna2HtmlLabel lblAgirlik;
    private Guna.UI2.WinForms.Guna2HtmlLabel lblDurum;
    private WebBrowser webBrowser1;

    private void InitializeComponent()
    {
        this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
        this.lblAd = new Guna.UI2.WinForms.Guna2HtmlLabel();
        this.txtTakipNo = new Guna.UI2.WinForms.Guna2TextBox();
        this.btnSorgula = new Guna.UI2.WinForms.Guna2Button();
        this.lblGonderenAd = new Guna.UI2.WinForms.Guna2HtmlLabel();
        this.lblAdres = new Guna.UI2.WinForms.Guna2HtmlLabel();
        this.lblAgirlik = new Guna.UI2.WinForms.Guna2HtmlLabel();
        this.lblDurum = new Guna.UI2.WinForms.Guna2HtmlLabel();
        this.webBrowser1 = new WebBrowser();

        // lblEmail
        this.lblEmail.Location = new System.Drawing.Point(10, 10);
        this.lblEmail.Size = new System.Drawing.Size(300, 30);

        // lblAd
        this.lblAd.Location = new System.Drawing.Point(10, 50);
        this.lblAd.Size = new System.Drawing.Size(300, 30);

        // txtTakipNo
        this.txtTakipNo.PlaceholderText = "Takip Numarası";
        this.txtTakipNo.Location = new System.Drawing.Point(10, 90);
        this.txtTakipNo.Size = new System.Drawing.Size(200, 36);

        // btnSorgula
        this.btnSorgula.Text = "Sorgula";
        this.btnSorgula.Location = new System.Drawing.Point(220, 90);
        this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);

        // lblGonderenAd
        this.lblGonderenAd.Location = new System.Drawing.Point(10, 140);

        // lblAdres
        this.lblAdres.Location = new System.Drawing.Point(10, 180);

        // lblAgirlik
        this.lblAgirlik.Location = new System.Drawing.Point(10, 220);

        // lblDurum
        this.lblDurum.Location = new System.Drawing.Point(10, 260);

        // webBrowser1
        this.webBrowser1.Location = new System.Drawing.Point(10, 300);
        this.webBrowser1.Size = new System.Drawing.Size(300, 300);

        // KullaniciAnaSayfa
        this.ClientSize = new System.Drawing.Size(400, 620);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblAd);
        this.Controls.Add(this.txtTakipNo);
        this.Controls.Add(this.btnSorgula);
        this.Controls.Add(this.lblGonderenAd);
        this.Controls.Add(this.lblAdres);
        this.Controls.Add(this.lblAgirlik);
        this.Controls.Add(this.lblDurum);
        this.Controls.Add(this.webBrowser1);
        this.Text = "Kullanıcı Ana Sayfa";
    }
}
