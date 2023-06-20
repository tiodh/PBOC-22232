using J_Explore.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Models
{
    public class Transaksi
    {
        public int Id;
        public Admin Admin;
        public DateTime Tanggal;
        public string? NamaPengunjung;
        public string? AsalPengunjung;

        public Transaksi(int id, Admin admin, DateTime tanggal, string? namaPengunjung, string? asalPengunjung)
        {
            Id = id;
            Admin = admin;
            Tanggal = tanggal;
            NamaPengunjung = namaPengunjung;
            AsalPengunjung = asalPengunjung;
        }

        public static Transaksi FromDataRow(DataRow row) => new Transaksi
        (
            (int)row[Global.ColumnTransaksiId],
            Admin.FromDataRow(row),
            (DateTime)row[Global.ColumnTransaksiTanggalTransaksi],
            (string)row[Global.ColumnTransaksiNamaPengunjung],
            (string)row[Global.ColumnTransaksiAsalPengunjung]
        );

        public Dictionary<string, dynamic> ToDictionary() => new Dictionary<string, dynamic>
        {
            {Global.ColumnTransaksiUsernameAdmin, Admin.Username},
            {Global.ColumnTransaksiTanggalTransaksi, Tanggal.ToString("yyyy-MM-dd HH:mm:ss")},
            {Global.ColumnTransaksiNamaPengunjung, NamaPengunjung},
            {Global.ColumnTransaksiAsalPengunjung, AsalPengunjung}
        };
    }
}
