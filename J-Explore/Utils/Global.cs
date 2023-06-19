﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Utils
{
    public static class Global
    {
        public const string TableAkunAdmin = "akun_admin";
        public const string ColumnAkunAdminId = "id_akun_admin";
        public const string ColumnAkunAdminUsername = "username";
        public const string ColumnAkunAdminPassword = "password";
        public const string ColumnAkunAdminEmail = "email";
        public const string ColumnAkunAdminNoHp = "no_hp";

        public const string TableAkunUser = "akun_user";
        public const string ColumnAkunUserId = "id_akun_user";
        public const string ColumnAkunUserUsername = "username";

        public const string TableDataPengunjung = "data_pengunjung";
        public const string ColumnDataPengunjungId = "id_data_pengunjung";
        public const string ColumnDataPengunjungNama = "nama_pengunjung";
        public const string ColumnDataPengunjungAlamat = "alamat_pengunjung";
        public const string ColumnDataPengunjungJumlah = "jumlah_pengunjung";

        public const string TableJenisPengunjung = "jenis_pengunjung";
        public const string ColumnJenisPengunjungId = "id_jenis_pengunjung";
        public const string ColumnJenisPengunjungKelompokUsia = "kelompok_usia";

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

        public static string PadLeft(int number) => number.ToString().PadLeft(2, '0');

        public static string GetFormattedDate(DateTime date, bool withDayOfWeek = false, bool withMonthName = false) => $"{(withDayOfWeek ? $"{Global.TranslateDayOfWeek(date.DayOfWeek)}, " : "")}{PadLeft(date.Day)}{(withMonthName ? " " : "/")}{(withMonthName ? Global.TranslateMonth(date.Month) : PadLeft(date.Month))}{(withMonthName ? " " : "/")}{PadLeft(date.Year)} {PadLeft(date.Hour)}:{PadLeft(date.Minute)}:{PadLeft(date.Second)}";
    }
}
