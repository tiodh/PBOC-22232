using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Read_Pendataan_Wisatawan_Mingguan
{
    public partial class Form1 : Form
    {

        private const string connectionString = "Host=localhost;Port=5432;Database=database-pbo-final;Username=admin;Password=admin123;";
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("mingguColumn", "Minggu");
            dataGridView1.Columns.Add("jumlahColumn", "Jumlah Pengunjung");

            dataGridView1.Columns["mingguColumn"].DataPropertyName = "minggu";
            dataGridView1.Columns["jumlahColumn"].DataPropertyName = "jumlah_pengunjung";


        }
        private void Read_Click(object sender, EventArgs e)
        {
            string query = "SELECT EXTRACT(WEEK FROM tanggal_transaksi) AS minggu, COUNT(*) AS jumlah_pengunjung " +
                           "FROM data_pengunjung " +
                           "JOIN detail_transaksi ON data_pengunjung.id_data_pengunjung = detail_transaksi.id_data_pengunjung " +
                           "JOIN transaksi ON detail_transaksi.id_transaksi = transaksi.id_transaksi " +
                           "GROUP BY minggu " +
                           "ORDER BY minggu";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }
    }
}


