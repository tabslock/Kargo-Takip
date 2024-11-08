using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp2;

public partial class EmailOnayForm : Form
{
    private string email;

    public EmailOnayForm()
    {
    }

    public EmailOnayForm(string kullaniciEmail)
    {
        InitializeComponent();
        email = kullaniciEmail;
    }

    private void btnOnayla_Click(object sender, EventArgs e)
    {
        if (txtKod.Text == "1234")  // Simülasyon amaçlı statik kod kullandık.
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Kullanici SET EmailOnayli = 1 WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Hesap başarıyla onaylandı!");
                new AnaSayfa().Show();
                this.Hide();
            }
        }
        else
        {
            MessageBox.Show("Onay kodu yanlış!");
        }
    }
}
