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
            ShowDataPendapatanHarian();
        }


        private void ShowDataPendapatanHarian()
        {
            var db = new DatabaseHelper();
            var reader = db.Select("SELECT date(t.tanggal_transaksi) AS tanggal, sum(to_number(d.nominal_transaksi, '9999999999')) AS pendapatan_harian FROM transaksi t JOIN detail_transaksi d ON (t.id_transaksi = d.id_detail_transaksi) GROUP BY date(t.tanggal_transaksi);");
            dGV_pendapatan_harian.Rows.Clear();


            while (reader.Read())
            {
                dGV_pendapatan_harian.Rows.Add((DateTime)reader["tanggal"], (decimal)reader["pendapatan_harian"]);
            }

            reader.Close();

        }

        private void button_search_h_Click(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            var reader = db.Select($"SELECT * FROM transaksi WHERE tanggal LIKE '%{tb_pendapatan_harian.Text}%'");
            dGV_pendapatan_harian.Rows.Clear();
            while (reader.Read())
            {
                dGV_pendapatan_harian.Rows.Add((DateTime)reader["tanggal"], (decimal)reader["pendapatan_harian"]);
            }
            reader.Close();

        }
    }
}
