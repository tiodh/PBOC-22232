using J_Explore.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Models
{
    public class DataPengunjung
    {
        public int Id;
        public string Nama;
        public string Alamat;
        public int Jumlah;
        public JenisPengunjung JenisPengunjung;

        public DataPengunjung(int id, string nama, string alamat, int jumlah, JenisPengunjung jenisPengunjung)
        {
            Id = id;
            Nama = nama;
            Alamat = alamat;
            Jumlah = jumlah;
            JenisPengunjung = jenisPengunjung;
        }

        public static DataPengunjung FromDataRow(DataRow row) => new DataPengunjung
        (
            (int)row[Global.ColumnDataPengunjungId],
            (string)row[Global.ColumnDataPengunjungNama],
            (string)row[Global.ColumnDataPengunjungAlamat],
            (int)row[Global.ColumnDataPengunjungJumlah],
            JenisPengunjung.FromDataRow(row)
        );

        public Dictionary<string, dynamic> ToDictionary() => new Dictionary<string, dynamic>
        {
            {Global.ColumnDataPengunjungId, Id},
            {Global.ColumnDataPengunjungNama, Nama},
            {Global.ColumnDataPengunjungAlamat, Alamat},
            {Global.ColumnDataPengunjungJumlah, Jumlah},
        };
    }
}
