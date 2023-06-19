using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Data_Harga : UserControl
    {
        public Data_Harga()
        {
            InitializeComponent();
        }

        string connectionString = "Host=localhost;Port=5432;Database=jexplore fix;Username=postgres;Password=12345";
        void tampil_anak()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "select harga_tiket from harga_tiket where id_harga_tiket = 1";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        string result2 = command.ExecuteScalar()?.ToString();

                        textBox2.Text = result2;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        void tampil_dewasa()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "select harga_tiket from harga_tiket where id_harga_tiket = 2";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        string result = command.ExecuteScalar()?.ToString();

                        textBox1.Text = result;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            tampil_anak();
            tampil_dewasa();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "update harga_tiket set harga_tiket = '" + textBox2.Text + "' where id_harga_tiket = 1";
                    string query2 = "update harga_tiket set harga_tiket = '" + textBox1.Text + "' where id_harga_tiket = 2";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(query, textBox2.Text);
                        command.Parameters.AddWithValue(query2, textBox1.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui.");
                        }
                        else
                        {
                            MessageBox.Show("Tidak ada data yang diperbarui.");
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
