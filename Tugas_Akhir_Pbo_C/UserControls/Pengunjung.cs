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
    public partial class Pengunjung : UserControl
    {
        private string connectionString = "Host=localhost;Port=5432;Database=CRUD;Username=postgres;Password=1234";

        public Pengunjung()
        {
            InitializeComponent();
        }

        private void Pengunjung_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            comboBoxBulan.Items.Add("Januari");
            comboBoxBulan.Items.Add("Februari");
            comboBoxBulan.Items.Add("Maret");
            comboBoxBulan.Items.Add("April");
            comboBoxBulan.Items.Add("Mei");
            comboBoxBulan.Items.Add("Juni");
            comboBoxBulan.Items.Add("Juli");
            comboBoxBulan.Items.Add("Agustus");
            comboBoxBulan.Items.Add("September");
            comboBoxBulan.Items.Add("Oktober");
            comboBoxBulan.Items.Add("November");
            comboBoxBulan.Items.Add("Desember");

            comboBoxBulan.SelectedItem = DateTime.Now.ToString("MMMM");
        }

        private void Pengunjung_Load_1(object sender, EventArgs e)
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

                    string keuanganQuery = @"SELECT tanggal, SUM(nominal) as total_pendapatan
                                             FROM detail_transaksi
                                             WHERE tipe_transaksi = 'pendapatan'
                                             GROUP BY tanggal";
                    using (NpgsqlCommand keuanganCommand = new NpgsqlCommand(keuanganQuery, connection))
                    {
                        using (NpgsqlDataReader keuanganReader = keuanganCommand.ExecuteReader())
                        {
                            while (keuanganReader.Read())
                            {
                                DateTime tanggal = keuanganReader.GetDateTime(0);
                                decimal totalPendapatan = keuanganReader.GetDecimal(1);

                                // Tambahkan baris baru ke DataGridView
                                dataGridViewKeuangan.Rows.Add(tanggal, totalPendapatan);
                            }
                        }
                    }

                    string pengunjungQuery = @"SELECT nama, asal, umur 
                                               FROM pengunjung";
                    using (NpgsqlCommand pengunjungCommand = new NpgsqlCommand(pengunjungQuery, connection))
                    {
                        using (NpgsqlDataReader pengunjungReader = pengunjungCommand.ExecuteReader())
                        {
                            while (pengunjungReader.Read())
                            {
                                string nama = pengunjungReader.GetString(0);
                                string asal = pengunjungReader.GetString(1);
                                int umur = pengunjungReader.GetInt32(2);

                                dataGridViewPengunjung.Rows.Add(nama, asal, umur);
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
