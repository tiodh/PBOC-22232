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
    public partial class Pendapatan_Admin : UserControl
    {
        public Pendapatan_Admin()
        {
            InitializeComponent();
            ShowDataPendapatanMingguan();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            var reader = db.Select($"SELECT * FROM transaksi WHERE tanggal_transaksi LIKE '%{TB_Pendapatan.Text}%'");
            dGV_Pendapatan.Rows.Clear();
            while (reader.Read())
            {
                dGV_Pendapatan.Rows.Add((DateTime)reader["tanggal_transaksi"], (decimal)reader["nominal_transaksi"]);
            }
            reader.Close();
        }

        private void ShowDataPendapatanMingguan()
        {
            var db = new DatabaseHelper();
            var reader = db.Select("SELECT tanggal_transaksi, SUM(to_number(nominal_transaksi, '999999999')) AS pendapatan_mingguan FROM transaksi GROUP BY tanggal_transaksi;");
            dGV_Pendapatan.Rows.Clear();


            while (reader.Read())
            {
                dGV_Pendapatan.Rows.Add((DateTime)reader["tanggal_transaksi"], (decimal)reader["nominal_transaksi"]);
            }

            reader.Close();

        }
    }
}