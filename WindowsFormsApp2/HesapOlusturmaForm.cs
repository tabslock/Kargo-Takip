using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class HesapOlusturmaForm : Form
{
    public HesapOlusturmaForm()
    {
        InitializeComponent();
    }

    private void btnKayitOl_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            string query = "INSERT INTO Kullanici (Ad, Soyad, Email, Sifre, Telefon) " +
                           "VALUES (@Ad, @Soyad, @Email, @Sifre, @Telefon)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı! Lütfen email onayını tamamlayın.");
                new EmailOnayForm().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
