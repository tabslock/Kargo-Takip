using System;
using System.Windows.Forms;
using WindowsFormsApp2;

public partial class CalisanGirisForm : Form
{
    public CalisanGirisForm()
    {
        InitializeComponent();
    }

    private void btnGirisYap_Click(object sender, EventArgs e)
    {
        string kullaniciAdi = txtKullaniciAdi.Text;
        string sifre = txtSifre.Text;

        if (kullaniciAdi == "admin" && sifre == "admin")
        {
            MessageBox.Show("Giriş Başarılı!");
            new CalisanAnaSayfa().Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
        }
    }
}
