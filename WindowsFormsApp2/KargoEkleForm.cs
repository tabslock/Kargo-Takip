using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class KargoEkleForm : Form
    {
        public KargoEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string_here";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Kargolar (KargoAdi, Gonderen, Alici) VALUES (@KargoAdi, @Gonderen, @Alici)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KargoAdi", txtKargoAdi.Text);
                cmd.Parameters.AddWithValue("@Gonderen", txtGonderen.Text);
                cmd.Parameters.AddWithValue("@Alici", txtAlici.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kargo başarıyla eklendi.");
            }
        }
    }
}
