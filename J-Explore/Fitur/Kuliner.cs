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
using J_Explore.Utils;
using Npgsql;
using J_Explore.Services;

namespace J_Explore.Fitur
{
    public partial class Kuliner : Form
    {
        private string ConnectionString = $"Host={Global.DbHost};Port={Global.DbPort};Database={Global.DbName};Username={Global.DbUsername};Password={Global.DbPassword}";

        public Kuliner()
        {
            InitializeComponent();
        }

        private void Kuliner_Load(object sender, EventArgs e)
        {
            LoadKulinerData();
        }

        private void LoadKulinerData()
        {
            dataGridViewKuliner.Rows.Clear();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT k.id_kuliner, nt.nama_tempat, nt.deskripsi_nama_tempat, k.nama_kuliner, k.harga_kuliner
                                    FROM nama_tempat nt
                                    INNER JOIN kuliner k ON nt.id_nama_tempat = k.id_nama_tempat
                                    ORDER BY k.id_kuliner";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string namaTempat = reader.GetString(1);
                                string deskripsiTempat = reader.GetString(2);
                                string namaKuliner = reader.GetString(3);
                                int hargaKuliner = reader.GetInt32(4);

                                dataGridViewKuliner.Rows.Add(id, namaTempat, namaKuliner, hargaKuliner);
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

        private void SearchData()
        {
            dataGridViewKuliner.Rows.Clear();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = $@"SELECT k.id_kuliner, nt.nama_tempat, nt.deskripsi_nama_tempat, k.nama_kuliner, k.harga_kuliner
                                    FROM nama_tempat nt
                                    INNER JOIN kuliner k ON nt.id_nama_tempat = k.id_nama_tempat
                                    where nama_kuliner ilike '%{textBox1.Text}%'
                                    ORDER BY k.id_kuliner";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string namaTempat = reader.GetString(1);
                                string deskripsiTempat = reader.GetString(2);
                                string namaKuliner = reader.GetString(3);
                                int hargaKuliner = reader.GetInt32(4);

                                dataGridViewKuliner.Rows.Add(id, namaTempat, namaKuliner, hargaKuliner);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewKuliner.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewKuliner.Rows[selectedRowIndex].Cells[0].Value);
            string namaTempat = Convert.ToString(dataGridViewKuliner.Rows[selectedRowIndex].Cells[1].Value);
            string namaMakanan = dataGridViewKuliner.Rows[selectedRowIndex].Cells[2].Value.ToString();
            int harga = Convert.ToInt32(dataGridViewKuliner.Rows[selectedRowIndex].Cells[3].Value);

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("UPDATE kuliner SET nama_kuliner = @nama, harga_kuliner = @harga WHERE id_kuliner = @id", connection))
                {
                    cmd.Parameters.AddWithValue("nama", namaMakanan);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil diperbarui.");

            LoadKulinerData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadKulinerData();
        }

        public void DeleteData()
        {
            string connString = $"Server={Global.DbHost};Port={Global.DbPort};Database={Global.DbName};User Id={Global.DbUsername};Password={Global.DbPassword};";
            int selectedRowIndex = dataGridViewKuliner.SelectedCells[0].RowIndex;
            int idKuliner = Convert.ToInt32(dataGridViewKuliner.Rows[selectedRowIndex].Cells[0].Value);
            Console.WriteLine("INDEX" + selectedRowIndex);
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM kuliner WHERE id_kuliner = @id;";
                    using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", idKuliner);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine("Jumlah baris terpengaruh: " + rowsAffected);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void OnButtonCreateClick(object sender, EventArgs e)
        {
            DataTable namaTempat = DbHelper.GetInstance().ExecuteQuery($"SELECT id_nama_tempat FROM nama_tempat WHERE nama_tempat = '{textBoxNamaTempat.Text.Trim()}'");

            if (namaTempat.Rows.Count < 1)
            {
                MessageBox.Show("Nama tempat tidak ditemukan!", "Gagal menambahkan kuliner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int lastIdKuliner = (int)DbHelper.GetInstance().ExecuteQuery("SELECT id_kuliner FROM kuliner ORDER BY id_kuliner DESC LIMIT 1").Rows[0][0];

            int affectedRows = DbHelper.GetInstance().Create("kuliner", new Dictionary<string, dynamic>
            {
                {"id_kuliner", ++lastIdKuliner},
                {"nama_kuliner", textBoxNamaMakanan.Text.Trim()},
                {"harga_kuliner", textBoxHarga.Text.Trim()},
                {"id_nama_tempat", namaTempat.Rows[0][0]}
            }
            );

            if (affectedRows > 0)
            {
                LoadKulinerData();
                textBoxNamaTempat.Text = "";
                textBoxNamaMakanan.Text = "";
                textBoxHarga.Text = "";
                return;
            }
            MessageBox.Show("Data gagal ditambahkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
