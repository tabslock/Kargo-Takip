using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class GirisYapForm : Form
{
    public GirisYapForm()
    {
        InitializeComponent();
    }

    private void btnGirisYap_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM Kullanici WHERE Email = @Email AND Sifre = @Sifre AND EmailOnayli = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş başarılı!");
                new KullaniciAnaSayfa(reader["Email"].ToString(), reader["Ad"].ToString()).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }
    }
}
