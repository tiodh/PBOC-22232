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
    public partial class Pengunjung : UserControl
    {
        public Pengunjung()
        {
            InitializeComponent();
            ShowDataPendataanHarian();
        }

        private void btn_pendataan_harian_Click(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            var reader = db.Select($"SELECT * FROM transaksi WHERE  tanggal_transaksi LIKE '%{TB_pendataan_harian.Text}%'");
            dGV_pendataan_harian.Rows.Clear();
            while (reader.Read())
            {
                dGV_pendataan_harian.Rows.Add((DateTime)reader["tanggal_transaksi"], (int)reader["jumlah_pengunjung_harian"]);
            }
            reader.Close();
        
    }

        private void ShowDataPendataanHarian()
        {
            var db = new DatabaseHelper();
            var reader = db.Select("SELECT DATE(t.tanggal_transaksi), SUM(d.jumlah_pengunjung) AS total_pengunjung " +
                                  "FROM transaksi t " +
                                  "JOIN data_pengunjung d ON t.id_transaksi = d.id_data_pengunjung " +
                                  "GROUP BY DATE(t.tanggal_transaksi);");
            dGV_pendataan_harian.Rows.Clear();

            while (reader.Read())
            {
                dGV_pendataan_harian.Rows.Add((DateTime)reader["tanggal_transaksi"], (int)reader["jumlah_pengunjung_harian"]);
            }

            reader.Close();
        }
    }
}
