using J_Explore.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Models
{
    public class JenisPengunjung
    {
        public int Id;
        public string Jenis;
        public int HargaTiket;

        public JenisPengunjung(int id, string jenis, int hargaTiket)
        {
            Id = id;
            Jenis = jenis;
            HargaTiket = hargaTiket;
        }

        public static JenisPengunjung FromDataRow(DataRow row) => new JenisPengunjung
        (
            (int)row[Global.ColumnJenisPengunjungId],
            (string)row[Global.ColumnJenisPengunjungJenisPengunjung],
            (int)row[Global.ColumnJenisPengunjungHargaTiket]
        );

        public Dictionary<string, dynamic> ToDictionary() => new Dictionary<string, dynamic>
        {
            {Global.ColumnJenisPengunjungJenisPengunjung, Jenis},
            {Global.ColumnJenisPengunjungHargaTiket, HargaTiket}
        };
    }
}
