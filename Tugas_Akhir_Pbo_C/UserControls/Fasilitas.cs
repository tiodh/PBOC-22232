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

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Fasilitas : UserControl
    {
        private string connectionString = "Host=localhost;Database=nama_database;Username=nama_pengguna;Password=kata_sandi";

        public Fasilitas()
        {
            InitializeComponent();
        }

        private void Fasilitas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM jenis_fasilitas";
                    command.CommandType = CommandType.Text;

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void UpdateData(int id, string nama, string deskripsi)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE jenis_fasilitas SET nama_jenis_fasilitas = @nama, deskripsi_jenis_fasilitas = @deskripsi WHERE id_jenis_fasilitas = @id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("nama", nama);
                    command.Parameters.AddWithValue("deskripsi", deskripsi);
                    command.ExecuteNonQuery();
                }
            }

            LoadData();
        }

        // Event handler untuk tombol Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            int id = Convert.ToInt32(selectedRow.Cells["id_jenis_fasilitas"].Value);
            string nama = selectedRow.Cells["nama_jenis_fasilitas"].Value.ToString();
            string deskripsi = selectedRow.Cells["deskripsi_jenis_fasilitas"].Value.ToString();

            UpdateData(id, nama, deskripsi);
        }
    }
}
