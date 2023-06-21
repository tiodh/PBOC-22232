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
            ExportHelper.ExportReportToExcel(new List<PrintingArgumentsTransaction>
                {
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 3, 1000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 4, 2, 2000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 3, 3000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 1, 1, 4000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 0, 5000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 0, 6000),
                }
            );
        }

        private void OnButtonExportPdfClick(object sender, EventArgs e)
        {
            ExportHelper.ExportReportToPdf(new List<PrintingArgumentsTransaction>
                {
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 3, 1000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 4, 2, 2000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 3, 3000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 1, 1, 4000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 0, 5000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 0, 6000),
                }
            );
        }

        private void Riwayat_Load(object sender, EventArgs e)
        {
            DataTable dt = DbHelper.GetInstance().ExecuteQuery($"select id_transaksi as \"ID TRANSAKSI\", tanggal_transaksi as \"TANGGAL\", nama_pengunjung as \"NAMA PEMBELI\", asal_pengunjung as \"ASAL\", sum(jumlah_pengunjung * harga_tiket) as total from transaksi join detail_transaksi using (id_transaksi) join jenis_pengunjung using (id_jenis_pengunjung) group by id_transaksi, tanggal_transaksi, nama_pengunjung, asal_pengunjung");
            dataGridViewRiwayat.DataSource = dt;
        }

        private void SearchData()
        {
            dataGridViewRiwayat.Rows.Clear();

            try
            {
                DataTable dt = DbHelper.GetInstance().ExecuteQuery($"select id_transaksi as \"ID TRANSAKSI\", tanggal_transaksi as \"TANGGAL\", nama_pengunjung as \"NAMA PEMBELI\", asal_pengunjung as \"ASAL\", sum(jumlah_pengunjung * harga_tiket) as total from transaksi join detail_transaksi using (id_transaksi) join jenis_pengunjung using (id_jenis_pengunjung) group by id_transaksi, tanggal_transaksi, nama_pengunjung, asal_pengunjung");
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
