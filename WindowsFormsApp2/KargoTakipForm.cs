using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class KargoTakipForm : Form
    {
        public KargoTakipForm()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Durum FROM Kargo WHERE TakipNumarasi = @TakipNumarasi";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TakipNumarasi", txtTakipNo.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblDurum.Text = "Durum: " + reader["Durum"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz takip numarası!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            new AnaSayfa().Show();
            this.Hide();
        }
    }
}
