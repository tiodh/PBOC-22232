using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Npgsql;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Kuliner : UserControl
    {
        private NpgsqlConnection connection;

        string connString = "Server=localhost;Port=5432;Database=LitBang;User Id=postgres;Password=Bismillah1.;";
        public Kuliner()
        {
            InitializeComponent();
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            LoadData();

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Kuliner_Load_1(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connString))
                {
                    connection.Open();

                    string query = @"SELECT k.id_kuliner, nt.nama_tempat, nt.deskripsi_nama_tempat, k.nama_kuliner, k.harga_kuliner
                                    FROM nama_tempat nt
                                    INNER JOIN kuliner k ON nt.id_nama_tempat = k.id_nama_tempat";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            kryptonDataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                string id_kuliner = Convert.ToString(reader[0]);
                                string namaTempat = reader.GetString(1);
                                string deskripsiTempat = reader.GetString(2);
                                string namaKuliner = reader.GetString(3);
                                int hargaKuliner = reader.GetInt32(4);

                                kryptonDataGridView1.Rows.Add(id_kuliner, namaTempat, deskripsiTempat, namaKuliner, hargaKuliner);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadData();
        }

        public void DeleteData()
        {
            int selectedRowIndex = kryptonDataGridView1.SelectedCells[0].RowIndex;
            int idKuliner = Convert.ToInt32(kryptonDataGridView1.Rows[selectedRowIndex].Cells[0].Value);
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteData();
            LoadData();
        }
    }
}