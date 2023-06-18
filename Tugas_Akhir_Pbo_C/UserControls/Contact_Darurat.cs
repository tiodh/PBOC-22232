using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Contact_Darurat : UserControl
    {
        private const string connectionString = "Server = localhost; Port = 5432; User Id = postgres; Password = 123456; Database = Laptop;";
        public Contact_Darurat()
        {
            InitializeComponent();
        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {
            {
                string name = nama_layanan_darurat.Text;
                string email = email_layanan_darurat.Text;
                string phone = no_telp.Text;
                string deskripsi = deskripsi_layanan_darurat.Text;

                // Membuat koneksi ke database
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Membuat perintah SQL untuk insert data
                    string sql = "INSERT INTO your_table (name, email, phone, address) VALUES (@name, @email, @phone, @address)";

                    // Membuat objek perintah dengan SQL dan koneksi
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        // Menambahkan parameter ke perintah SQL
                        command.Parameters.AddWithValue("name", name);
                        command.Parameters.AddWithValue("email", email);
                        command.Parameters.AddWithValue("phone", phone);
                        command.Parameters.AddWithValue("address", deskripsi);

                        // Menjalankan perintah SQL
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

            }
                nama_layanan_darurat.Text = string.Empty;
                email_layanan_darurat.Text = string.Empty;
                no_telp.Text = string.Empty;
                deskripsi_layanan_darurat.Text = string.Empty;
            
        }
    }
}   
