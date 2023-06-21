using J_Explore.Services;
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

namespace J_Explore.Properties
{
    public partial class Riwayat : Form
    {
        public Riwayat()
        {
            InitializeComponent();
        }

        private void OnButtonExportExcelClick(object sender, EventArgs e)
        {
            List<PrintingArgumentsTransaction> printingArgumentsTransactions = new List<PrintingArgumentsTransaction>();

            foreach (DataGridViewRow riwayat in dataGridViewRiwayat.Rows)
            {
                int id = (int)riwayat.Cells[0].Value;
                string admin = (string)riwayat.Cells[1].Value;
                DateTime tanggal = (DateTime)riwayat.Cells[2].Value;
                string? nama;
                try
                {
                    nama = (string)riwayat.Cells[3].Value;
                }
                catch
                {
                    nama = null;
                }
                string? asal;
                try
                {
                    asal = (string)riwayat.Cells[4].Value;
                }
                catch
                {
                    asal = null;
                }
                long jumlahAnakAnak = (long)riwayat.Cells[5].Value;
                long jumlahOrangDewasa = (long)riwayat.Cells[6].Value;
                long total = (long)riwayat.Cells[7].Value;

                printingArgumentsTransactions.Add(new PrintingArgumentsTransaction(id, admin, tanggal, nama, asal, jumlahAnakAnak, jumlahOrangDewasa, total));
            }

            ExportHelper.ExportHistoryToExcel(printingArgumentsTransactions);
        }

        private void OnButtonExportPdfClick(object sender, EventArgs e)
        {
            List<PrintingArgumentsTransaction> printingArgumentsTransactions = new List<PrintingArgumentsTransaction>();

            foreach (DataGridViewRow riwayat in dataGridViewRiwayat.Rows)
            {
                int id = (int)riwayat.Cells[0].Value;
                string admin = (string)riwayat.Cells[1].Value;
                DateTime tanggal = (DateTime)riwayat.Cells[2].Value;
                string? nama;
                try
                {
                    nama = (string)riwayat.Cells[3].Value;
                }
                catch
                {
                    nama = null;
                }
                string? asal;
                try
                {
                    asal = (string)riwayat.Cells[4].Value;
                }
                catch
                {
                    asal = null;
                }
                long jumlahAnakAnak = (long)riwayat.Cells[5].Value;
                long jumlahOrangDewasa = (long)riwayat.Cells[6].Value;
                long total = (long)riwayat.Cells[7].Value;

                printingArgumentsTransactions.Add(new PrintingArgumentsTransaction(id, admin, tanggal, nama, asal, jumlahAnakAnak, jumlahOrangDewasa, total));
            }

            ExportHelper.ExportHistoryToPdf(printingArgumentsTransactions);
        }

        private void Riwayat_Load(object sender, EventArgs e)
        {
            DataTable dt = DbHelper.GetInstance().ExecuteQuery($"select id_transaksi as \"ID TRANSAKSI\", username_admin as \"ADMIN\", tanggal_transaksi as \"TANGGAL\", nama_pengunjung as \"NAMA PEMBELI\", asal_pengunjung as \"ASAL\", sum(CASE WHEN id_jenis_pengunjung = '1' THEN jumlah_pengunjung ELSE 0 END) AS \"JUMLAH PENGUNJUNG ANAK-ANAK\", sum(CASE WHEN id_jenis_pengunjung = '2' THEN jumlah_pengunjung ELSE 0 END) AS \"JUMLAH PENGUNJUNG DEWASA\", sum(jumlah_pengunjung * harga_tiket) as \"TOTAL\" from transaksi join detail_transaksi using (id_transaksi) join jenis_pengunjung using (id_jenis_pengunjung) group by id_transaksi, tanggal_transaksi, nama_pengunjung, asal_pengunjung order by id_transaksi");
            dataGridViewRiwayat.DataSource = dt;
        }

        private void SearchData()
        {
            dataGridViewRiwayat.Rows.Clear();

            try
            {
                DataTable dt = DbHelper.GetInstance().ExecuteQuery($"select id_transaksi as \"ID TRANSAKSI\", username_admin as \"ADMIN\", tanggal_transaksi as \"TANGGAL\", nama_pengunjung as \"NAMA PEMBELI\", asal_pengunjung as \"ASAL\", sum(CASE WHEN id_jenis_pengunjung = '1' THEN jumlah_pengunjung ELSE 0 END) AS \"JUMLAH PENGUNJUNG ANAK-ANAK\", sum(CASE WHEN id_jenis_pengunjung = '2' THEN jumlah_pengunjung ELSE 0 END) AS \"JUMLAH PENGUNJUNG DEWASA\", sum(jumlah_pengunjung * harga_tiket) as \"TOTAL\" from transaksi join detail_transaksi using (id_transaksi) join jenis_pengunjung using (id_jenis_pengunjung) group by id_transaksi, tanggal_transaksi, nama_pengunjung, asal_pengunjung order by id_transaksi");
                dataGridViewRiwayat.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
