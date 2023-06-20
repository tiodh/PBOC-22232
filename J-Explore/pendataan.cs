using J_Explore.Services;
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
        public pendataan()
        {
            InitializeComponent();
            showWisataHarian();
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
    }
}
