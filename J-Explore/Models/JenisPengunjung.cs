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
        public string KelompokUsia;

        public JenisPengunjung(int id, string kelompokUsia)
        {
            Id = id;
            KelompokUsia = kelompokUsia;
        }

        public static JenisPengunjung FromDataRow(DataRow row) => new JenisPengunjung
        (
            (int)row[Global.ColumnJenisPengunjungId],
            (string)row[Global.ColumnJenisPengunjungKelompokUsia]
        );

        public Dictionary<string, dynamic> ToDictionary() => new Dictionary<string, dynamic>
        {
            {Global.ColumnJenisPengunjungKelompokUsia, KelompokUsia}
        };
    }
}
