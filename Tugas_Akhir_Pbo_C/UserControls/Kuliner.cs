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
    public partial class Kuliner : UserControl
    {
        private const string ConnectionString = "Host=localhost;Port=5432;Database=nama_database;Username=nama_pengguna;Password=sandi_pengguna";

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

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM kuliner", connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nama = reader.GetString(1);
                            int harga = reader.GetInt32(2);
                            int tempatId = reader.GetInt32(3);

                            dataGridViewKuliner.Rows.Add(id, nama, harga, tempatId);
                        }
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewKuliner.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewKuliner.Rows[selectedRowIndex].Cells[0].Value);
            string nama = dataGridViewKuliner.Rows[selectedRowIndex].Cells[1].Value.ToString();
            int harga = Convert.ToInt32(dataGridViewKuliner.Rows[selectedRowIndex].Cells[2].Value);
            int tempatId = Convert.ToInt32(dataGridViewKuliner.Rows[selectedRowIndex].Cells[3].Value);

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("UPDATE kuliner SET nama_kuliner = @nama, harga_kuliner = @harga, id_nama_tempat = @tempatId WHERE id_kuliner = @id", connection))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("tempatId", tempatId);
                    cmd.Parameters.AddWithValue("id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil diperbarui.");

            LoadKulinerData();
        }
    }
}
