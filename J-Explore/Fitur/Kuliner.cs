using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J_Explore;

namespace J_Explore.Fitur
{
    public partial class Kuliner : Form
    {
        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=jexplore fix";
        public Kuliner()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT nt.nama_tempat, nt.deskripsi_nama_tempat, k.nama_kuliner, k.harga_kuliner
                                    FROM nama_tempat nt
                                    INNER JOIN kuliner k ON nt.id_nama_tempat = k.id_nama_tempat";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string namaTempat = reader.GetString(0);
                                string deskripsiTempat = reader.GetString(1);
                                string namaKuliner = reader.GetString(2);
                                int hargaKuliner = reader.GetInt32(3);

                                dataGridView1.Rows.Add(namaTempat, deskripsiTempat, namaKuliner, hargaKuliner);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT c.nama_tempat, c.deskripsi_nama_tempat, d.nama_kuliner, d.harga_kuliner " +
                    "FROM nama_tempat c JOIN kuliner d ON c.id_nama_tempat = d.id_nama_tempat " +
                    "WHERE d.nama_kuliner LIKE '%' || @keyword || '%'";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@keyword", keyword);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();

                        while (reader.Read())
                        {
                            string namaTempat = reader.GetString(0);
                            string deskripsiTempat = reader.GetString(1);
                            string namaKuliner = reader.GetString(2);
                            int hargaKuliner = reader.GetInt32(3);

                            dataGridView1.Rows.Add(namaTempat, deskripsiTempat, namaKuliner, hargaKuliner);
                        }
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
