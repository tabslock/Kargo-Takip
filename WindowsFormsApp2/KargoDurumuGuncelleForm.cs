using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class KargoDurumuGuncelleForm : Form
    {
        public KargoDurumuGuncelleForm()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string_here";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Kargolar SET Durum = @Durum WHERE KargoID = @KargoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KargoID", txtKargoID.Text);
                cmd.Parameters.AddWithValue("@Durum", txtDurum.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kargo durumu başarıyla güncellendi.");
            }
        }
    }
}
