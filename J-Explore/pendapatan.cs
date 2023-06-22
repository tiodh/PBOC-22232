using J_Explore.Services;
using J_Explore.Utils;
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

namespace J_Explore
{
    public partial class pendapatan : Form
    {
        private string connString = $"Host={Global.DbHost};Port={Global.DbPort};Database={Global.DbName};Username={Global.DbUsername};Password={Global.DbPassword}";
        private NpgsqlConnection conn;
        private DataTable dt;
        private NpgsqlCommand cmd;
        public pendapatan()
        {
            InitializeComponent();
            showWisataHarian();
            ShowWisatawanMingguan();
            showWisatawanBulanan();
        }

        private void showWisataHarian()
        {
            DataTable table = DbHelper.GetInstance().ExecuteQuery("SELECT tanggal_transaksi, SUM(harga_tiket * jumlah_pengunjung) AS pendapatan_harian\r\nFROM transaksi\r\nJOIN detail_transaksi ON transaksi.id_transaksi = detail_transaksi.id_transaksi\r\nJOIN jenis_pengunjung ON detail_transaksi.id_jenis_pengunjung = jenis_pengunjung.id_jenis_pengunjung\r\nWHERE tanggal_transaksi::date = CURRENT_DATE\r\nGROUP BY tanggal_transaksi;\r\n");
            pendapatanHari.DataSource = table;

            //foreach (DataRow row in table.Rows)
            //{
            //    DateTime TanggalTransaksi = (DateTime)row["tanggal_transaksi"];
            //    long JumlahWisatawanHarian = (long)row["jumlah_pengunjung"];
            //}
        }

        private void ShowWisatawanMingguan()
        {
            pendapatanMinggu.Rows.Clear();

            DataTable table = DbHelper.GetInstance().ExecuteQuery("SELECT DATE_TRUNC('week', tanggal_transaksi) AS minggu, SUM(harga_tiket * jumlah_pengunjung) AS pendapatan_mingguan\r\nFROM transaksi\r\nJOIN detail_transaksi ON transaksi.id_transaksi = detail_transaksi.id_transaksi\r\nJOIN jenis_pengunjung ON detail_transaksi.id_jenis_pengunjung = jenis_pengunjung.id_jenis_pengunjung\r\nWHERE DATE_TRUNC('week', tanggal_transaksi) = DATE_TRUNC('week', CURRENT_DATE)\r\nGROUP BY minggu;\r\n");

            //foreach (DataRow row in table.Rows)
            //{
            //    pendapatanMinggu.Rows.Add(new[] { row[0], row[1] });
            //}

            pendapatanMinggu.DataSource = table;
        }
        private void showWisatawanBulanan()
        {
            pendapatanBulan.Rows.Clear();
            DataTable table = DbHelper.GetInstance().ExecuteQuery("SELECT DATE_TRUNC('month', tanggal_transaksi) AS bulan, SUM(harga_tiket * jumlah_pengunjung) AS pendapatan_bulanan\r\nFROM transaksi\r\nJOIN detail_transaksi ON transaksi.id_transaksi = detail_transaksi.id_transaksi\r\nJOIN jenis_pengunjung ON detail_transaksi.id_jenis_pengunjung = jenis_pengunjung.id_jenis_pengunjung\r\nWHERE DATE_TRUNC('month', tanggal_transaksi) = DATE_TRUNC('month', CURRENT_DATE)\r\nGROUP BY bulan;\r\n");

            //foreach (DataRow row in table.Rows)
            //{
            //    pendapatanBulan.Rows.Add(new[] { row[0], row[1] });
            //}

            pendapatanBulan.DataSource = table;
        }
        private void pendataan_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = @"SELECT EXTRACT(MONTH FROM tanggal_transaksi) AS bulan, COUNT(*) AS jumlah_pengunjung FROM transaksi WHERE EXTRACT(MONTH FROM tanggal_transaksi) = '" + textBox3.Text + "' GROUP BY bulan ORDER BY bulan;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            pendapatanBulan.DataSource = dt;
            MessageBox.Show("Data berhasil ditampilkan!");
        }

        private void OnButtonMingguIniClick(object sender, EventArgs e)
        {
            pendapatanMinggu.Rows.Clear();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                ShowWisatawanMingguan();
                return;
            }

            DataTable table = DbHelper.GetInstance().ExecuteQuery($"SELECT EXTRACT(DOW FROM tanggal_transaksi) AS weekday_number, count(*) AS total FROM transaksi WHERE tanggal_transaksi >= DATE_TRUNC('week', CURRENT_DATE) AND tanggal_transaksi < DATE_TRUNC('week', CURRENT_DATE) + INTERVAL '1 week' AND EXTRACT(DOW FROM tanggal_transaksi) = {textBox2.Text.Trim()} GROUP BY weekday_number");

            foreach (DataRow row in table.Rows)
            {
                pendapatanMinggu.Rows.Add(new[] { Global.TranslateDayOfWeek(Convert.ToDecimal(row[0])), row[1] });
            }
        }
        private void pendataanMinggu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pendapatan_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pendapatanBulan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
