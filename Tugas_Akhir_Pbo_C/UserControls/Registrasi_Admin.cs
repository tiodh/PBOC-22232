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
    public partial class Registrasi_Admin : UserControl
    {
        public Registrasi_Admin()
        {
            InitializeComponent();
        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=fauza123;Database=project;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string username = kryptonTextBox5.Text;
                    string password = kryptonTextBox1.Text;
                    string email = kryptonTextBox2.Text;
                    string phoneNumber = kryptonTextBox3.Text;

                    string query = "INSERT INTO akun_admin (username, password, email, no_hp) " +
                                   "VALUES (@username, @password, @email, @no_hp)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("no_hp", phoneNumber);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Akun berhasil dibuat!");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void Registrasi_Admin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
