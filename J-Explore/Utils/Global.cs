using J_Explore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Utils
{
    public static class Global
    {
        public const string TableAdmin = "akun_admin";
        public const string ColumnAdminUsername = "username";
        public const string ColumnAdminPassword = "password";

        public const string TableAkunUser = "akun_user";
        public const string ColumnAkunUserId = "id_akun_user";
        public const string ColumnAkunUserUsername = "username";

        public const string TableDetailTransaksi = "detail_transaksi";
        public const string ColumnDetailTransaksiId = "id_detail_transaksi";
        // ColumnIdTransaksi
        // ColumnIdJenisPengunjung
        public const string ColumnDetailTransaksiJumlahPengunjung = "jumlah_pengunjung";

        public const string TableJenisPengunjung = "jenis_pengunjung";
        public const string ColumnJenisPengunjungId = "id_jenis_pengunjung";
        public const string ColumnJenisPengunjungJenisPengunjung = "jenis_pengunjung";
        public const string ColumnJenisPengunjungHargaTiket = "harga_tiket";

        public const string TableTransaksi = "transaksi";
        public const string ColumnTransaksiId = "id_transaksi";
        public const string ColumnTransaksiUsernameAdmin = "username_admin";
        public const string ColumnTransaksiTanggalTransaksi = "tanggal_transaksi";
        public const string ColumnTransaksiNamaPengunjung = "nama_pengunjung";
        public const string ColumnTransaksiAsalPengunjung = "asal_pengunjung";

        public static Admin CurrentAdmin = new Admin("admin", "admin123");

        // Konfigurasi Database
        public const string DbHost = "localhost";
        public const int DbPort = 5432;
        public const string DbUsername = "postgres";
        public const string DbPassword = "HELLOWORLD123";
        public const string DbName = "new_pbo";

        public static readonly Color OnHoverColor = Color.Lime;

        public static readonly PaperSize PaperSize58mm = new PaperSize("Custom", 201, 0);
        public static readonly PaperSize PaperSize80mm = new PaperSize("Custom", 283, 0);

        public const string PaperSize58mmName = "58mm";
        public const string PaperSize80mmName = "80mm";

        public static string TranslateDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "Senin";
                case DayOfWeek.Tuesday:
                    return "Selasa";
                case DayOfWeek.Wednesday:
                    return "Rabu";
                case DayOfWeek.Thursday:
                    return "Kamis";
                case DayOfWeek.Friday:
                    return "Jum'at";
                case DayOfWeek.Saturday:
                    return "Sabtu";
                default:
                    return "Minggu";
            }
        }

        public static string TranslateDayOfWeek(decimal dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 1:
                    return "Senin";
                case 2:
                    return "Selasa";
                case 3:
                    return "Rabu";
                case 4:
                    return "Kamis";
                case 5:
                    return "Jum'at";
                case 6:
                    return "Sabtu";
                default:
                    return "Minggu";
            }
        }

        public static string TranslateMonth(int month)
        {
            switch (month)
            {
                case 2:
                    return "Februari";
                case 3:
                    return "Maret";
                case 4:
                    return "April";
                case 5:
                    return "Mei";
                case 6:
                    return "Juni";
                case 7:
                    return "Juli";
                case 8:
                    return "Agustus";
                case 9:
                    return "September";
                case 10:
                    return "Oktober";
                case 11:
                    return "November";
                case 12:
                    return "Desember";
                default:
                    return "Januari";
            }
        }

        public static string PadLeft(long number) => number.ToString().PadLeft(2, '0');

        public static List<object> GetColumnData(DataTable dataTable, int columnIndex)
        {
            List<object> columnData = new List<object>();

            foreach (DataRow row in dataTable.Rows)
            {
                columnData.Add(row[columnIndex]);
            }

            return columnData;
        }

        public static string GetFormattedDate(DateTime date, bool withDayOfWeek = false, bool withMonthName = false, bool withHour = true) => $"{(withDayOfWeek ? $"{Global.TranslateDayOfWeek(date.DayOfWeek)}, " : "")}{PadLeft(date.Day)}{(withMonthName ? " " : "/")}{(withMonthName ? Global.TranslateMonth(date.Month) : PadLeft(date.Month))}{(withMonthName ? " " : "/")}{PadLeft(date.Year)}{(withHour ? $" {PadLeft(date.Hour)}:{PadLeft(date.Minute)}:{PadLeft(date.Second)}" : string.Empty)}";
    }
}
