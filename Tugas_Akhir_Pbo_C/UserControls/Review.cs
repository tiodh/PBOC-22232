using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Review : UserControl
    {
        private const string connectionString = "Server = localhost; Port = 5432; User Id = postgres; Password = 123456; Database = Laptop;";
        public Review()
        {
            InitializeComponent();
            kryptonButton1.Click += kryptonButton1_Click;
        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string nama = kryptonTextBox1.Text;
            string email = kryptonTextBox2.Text;
            string ulasan = kryptonRichTextBox1.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Gunakan variabel lokal untuk menyimpan nama dan email pengguna
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO feedback_user (Nama, Email, IsiUlasan) VALUES (@Nama, @Email, @IsiUlasan)", connection);
                    command.Parameters.AddWithValue("@Nama", nama);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@IsiUlasan", ulasan);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Ulasan berhasil ditambahkan ke database.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }
    }
}
