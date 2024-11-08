using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class KullaniciAnaSayfa : Form
{
    private string email;
    private string ad;

    public KullaniciAnaSayfa(string kullaniciEmail, string kullaniciAdi)
    {
        InitializeComponent();
        email = kullaniciEmail;
        ad = kullaniciAdi;
        lblEmail.Text = $"Email: {email}";
        lblAd.Text = $"Hoşgeldin, {ad}";
    }

    private void btnSorgula_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            string query = "SELECT GonderenAd, TeslimatAdresi, KargoAgirligi, Durum, SonKonum " +
                           "FROM Kargo WHERE TakipNumarasi = @TakipNumarasi";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TakipNumarasi", txtTakipNo.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblGonderenAd.Text = "Gönderen: " + reader["GonderenAd"].ToString();
                lblAdres.Text = "Adres: " + reader["TeslimatAdresi"].ToString();
                lblAgirlik.Text = "Ağırlık: " + reader["KargoAgirligi"].ToString() + " kg";
                lblDurum.Text = "Durum: " + reader["Durum"].ToString();
                webBrowser1.Navigate(reader["SonKonum"].ToString());
            }
            else
            {
                MessageBox.Show("Geçersiz takip numarası!");
            }
        }
    }
}
