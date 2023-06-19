using J_Explore.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Models
{
    public class DetailTransaksi
    {
        public int Id;
        public Transaksi Transaksi;
        public JenisPengunjung JenisPengunjung;
        public int JumlahPengunjung;

        public DetailTransaksi(int id, Transaksi transaksi, JenisPengunjung jenisPengunjung, int jumlahPengunjung)
        {
            Id = id;
            Transaksi = transaksi;
            JenisPengunjung = jenisPengunjung;
            JumlahPengunjung = jumlahPengunjung;
        }

        public static DetailTransaksi FromDataRow(DataRow row) => new DetailTransaksi
        (
            (int)row[Global.ColumnDetailTransaksiId],
            Transaksi.FromDataRow(row),
            JenisPengunjung.FromDataRow(row),
            (int)row[Global.ColumnDetailTransaksiJumlahPengunjung]
        );

        public Dictionary<string, dynamic> ToDictionary() => new Dictionary<string, dynamic>
        {
            {Global.ColumnTransaksiId, Transaksi.Id},
            {Global.ColumnJenisPengunjungId, JenisPengunjung.Id},
            {Global.ColumnDetailTransaksiJumlahPengunjung, JumlahPengunjung}
        };
    }
}
