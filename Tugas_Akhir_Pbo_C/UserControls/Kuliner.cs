using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Npgsql;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Kuliner : UserControl
    {
        string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=Daffa2005;Database=Database PBO";

        public Kuliner()
        {
            InitializeComponent();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Kuliner_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT nt.nama_tempat, nt.deskripsi_nama_tempat, k.nama_kuliner, k.harga_kuliner, k.foto_kuliner 
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
                                string fotoKuliner = reader.GetString(4);

                                kryptonDataGridView1.Rows.Add(namaTempat, deskripsiTempat, namaKuliner, hargaKuliner, fotoKuliner);
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

        
    }
}
