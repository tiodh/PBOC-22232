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
    public partial class pendataan : Form
    {
        private string connString = $"Host={Global.DbHost};Port={Global.DbPort};Database={Global.DbName};Username={Global.DbUsername};Password={Global.DbPassword}";
        private NpgsqlConnection conn;
        private DataTable dt;
        private NpgsqlCommand cmd;
        public pendataan()
        {
            InitializeComponent();
            showWisataHarian();
            ShowWisatawanMingguan();
        }

        private void showWisataHarian()
        {
            DataTable table = DbHelper.GetInstance().ExecuteQuery("SELECT tanggal_transaksi, COUNT(*) AS jumlah_pengunjung FROM transaksi GROUP BY tanggal_transaksi ORDER BY tanggal_transaksi;");
            pendataanHari.DataSource = table;

            foreach (DataRow row in table.Rows)
            {
                DateTime TanggalTransaksi = (DateTime)row["tanggal_transaksi"];
                long JumlahWisatawanHarian = (long)row["jumlah_pengunjung"];
            }
        }

        private void ShowWisatawanMingguan()
        {
            pendataanMinggu.Rows.Clear();

            DataTable table = DbHelper.GetInstance().ExecuteQuery("SELECT EXTRACT(DOW FROM tanggal_transaksi) AS weekday_number, count(*) AS total FROM transaksi WHERE tanggal_transaksi >= DATE_TRUNC('week', CURRENT_DATE) AND tanggal_transaksi < DATE_TRUNC('week', CURRENT_DATE) + INTERVAL '1 week' GROUP BY weekday_number");

            foreach (DataRow row in table.Rows)
            {
                pendataanMinggu.Rows.Add(new[] { Global.TranslateDayOfWeek(Convert.ToDecimal(row[0])), row[1] });
            }
        }

        private void searchDataharian_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_pendataanHari.Text))
            {
                showWisataHarian();
                return;
            }

            DataTable table = DbHelper.GetInstance().ExecuteQuery($"SELECT tanggal_transaksi, COUNT(*) AS jumlah_pengunjung FROM transaksi WHERE DATE(tanggal_transaksi) = '{tb_pendataanHari.Text}' GROUP BY tanggal_transaksi ORDER BY tanggal_transaksi;");
            pendataanHari.DataSource = table;
            pendataanHari.RowHeadersVisible = false;

            foreach (DataRow row in table.Rows)
            {
                DateTime TanggalTransaksi = (DateTime)row["tanggal_transaksi"];
                long JumlahWisatawanHarian = (long)row["jumlah_pengunjung"];
            }
        }

        private void pendataan_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
        }

        private void pendataanBulan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = @"SELECT EXTRACT(MONTH FROM tanggal_transaksi) AS bulan, COUNT(*) AS jumlah_pengunjung FROM transaksi WHERE EXTRACT(MONTH FROM tanggal_transaksi) = '" + textBox3.Text + "' GROUP BY bulan ORDER BY bulan;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            pendataanBulan.DataSource = dt;
            MessageBox.Show("Data berhasil ditampilkan!");
        }

        private void OnButtonMingguIniClick(object sender, EventArgs e)
        {
            pendataanMinggu.Rows.Clear();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                ShowWisatawanMingguan();
                return;
            }

            DataTable table = DbHelper.GetInstance().ExecuteQuery($"SELECT EXTRACT(DOW FROM tanggal_transaksi) AS weekday_number, count(*) AS total FROM transaksi WHERE tanggal_transaksi >= DATE_TRUNC('week', CURRENT_DATE) AND tanggal_transaksi < DATE_TRUNC('week', CURRENT_DATE) + INTERVAL '1 week' AND EXTRACT(DOW FROM tanggal_transaksi) = {textBox2.Text.Trim()} GROUP BY weekday_number");

            foreach (DataRow row in table.Rows)
            {
                pendataanMinggu.Rows.Add(new[] { Global.TranslateDayOfWeek(Convert.ToDecimal(row[0])), row[1] });
            }
        }
    }
}
