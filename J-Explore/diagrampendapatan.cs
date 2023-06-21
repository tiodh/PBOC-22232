using J_Explore.Services;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml.Style.Dxf;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using J_Explore.Utils;

namespace J_Explore
{
    public partial class diagrampendapatan : Form
    {
        public diagrampendapatan()
        {
            InitializeComponent();
            ReadIncomeV2();
        }

        private void diagrampendapatan_Load(object sender, EventArgs e)
        {

        }

        private void readDaysIncome()
        {
            label1.Text = DateTime.Now.ToString("MMM yyyy");
            label2.Text = DateTime.Now.ToString("yyyy");
            ObservableCollection<int> totalDays = new ObservableCollection<int>();
            ObservableCollection<int> totalMonth = new ObservableCollection<int>();
            List<string> month = new List<string>();
            List<string> days = new List<string>();
            DataTable data = DbHelper.GetInstance().ExecuteQuery("select date(tanggal_transaksi) as tanggal, sum(to_number(nominal_transaksi, '9999999999')) as nominal from transaksi\r\njoin detail_transaksi using (id_transaksi)\r\ngroup by date(tanggal_transaksi)");

            //foreach (DataRow row in data.Rows)
            //{
            //    DateTime dateIncome = Convert.ToDateTime(row["tanggal"]);
            //    if (DateTime.Now.Month == dateIncome.Month)
            //    {
            //        totalDays.Add(Convert.ToInt32(row["nominal"]));
            //        days.Add(dateIncome.ToString("dd MMM"));
            //    }
            //}

            //cartDataHari.Series = new ISeries[] {
            //    new ColumnSeries<int>
            //    {
            //        Name = "Jumlah",
            //        Values = totalDays
            //    }
            //};

            foreach (DataRow row in data.Rows)
            {
                int tmp_total_Month = 0;
                DateTime dateIncome = Convert.ToDateTime(row["tanggal"]);
                int bulan = dateIncome.Month;
                if (Convert.ToDateTime(row["tanggal"]).Month == DateTime.Now.Month)
                {
                    totalDays.Add(Convert.ToInt32(row["nominal"]));
                    days.Add(dateIncome.ToString("dd MMM"));
                }
                else
                {
                    int existingIndex = month.IndexOf(dateIncome.ToString("MMM"));
                    if (existingIndex != -1)
                    {
                        // Jika bulan sudah ada, tambahkan nilai ke bulan yang ada
                        totalMonth[existingIndex] += Convert.ToInt32(row["nominal"]);
                    }
                    else
                    {
                        // Jika bulan belum ada, tambahkan bulan dan nilai ke totalMonth
                        totalMonth.Add(Convert.ToInt32(row["nominal"]));
                        month.Add(dateIncome.ToString("MMM"));
                    }
                }
            }

            cartDataBulan.Series = new ISeries[] {
                new ColumnSeries<int>
                {
                    Name = "Jumlah",
                    Values = totalDays
                }
            };

            cartDataTahun.Series = new ISeries[] {
                new ColumnSeries<int>
                {
                    Name = "Jumlah",
                    Values = totalMonth
                }
            };

            cartDataBulan.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = (value) => "Rp " + value.ToString("N0"),
                    Labels = days
                }
            };

            cartDataTahun.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = (value) => "Rp " + value.ToString("N0"),
                    Labels = month
                }
            };
        }

        private void ReadIncomeV2()
        {
            // Ambil data per bulan
            DataTable dataPerBulan = DbHelper.GetInstance().ExecuteQuery("SELECT EXTRACT(MONTH FROM tanggal_transaksi) AS bulan, SUM(jumlah_pengunjung * harga_tiket) AS total_pendapatan FROM transaksi JOIN detail_transaksi USING (id_transaksi) JOIN jenis_pengunjung USING (id_jenis_pengunjung) WHERE EXTRACT(YEAR FROM tanggal_transaksi) = EXTRACT(YEAR FROM CURRENT_DATE) GROUP BY EXTRACT(MONTH FROM tanggal_transaksi) ORDER BY bulan");

            List<long> bulanValues = new List<long> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Axis bulanAxis = new Axis
            {
                Labeler = (value) => "Rp " + value.ToString("N0"),
                Labels = new string[] { Global.TranslateMonth(1), Global.TranslateMonth(2), Global.TranslateMonth(3), Global.TranslateMonth(4), Global.TranslateMonth(5), Global.TranslateMonth(6), Global.TranslateMonth(7), Global.TranslateMonth(8), Global.TranslateMonth(9), Global.TranslateMonth(10), Global.TranslateMonth(11), Global.TranslateMonth(12) }
            };

            foreach (DataRow row in dataPerBulan.Rows)
            {
                bulanValues[Convert.ToInt32((decimal)row[0]) - 1] = (long)row[1];
            }

            cartDataBulan.Series = new ISeries[]
            {
                new ColumnSeries<long>
                {
                    TooltipLabelFormatter = (value) => $"Rp {value.PrimaryValue.ToString("N0")}",
                    Name = "Jumlah",
                    Values = bulanValues
                }
            };

            cartDataBulan.XAxes = new Axis[]
            {
                bulanAxis
            };

            // Ambil data per tahun
            DataTable dataPerTahun = DbHelper.GetInstance().ExecuteQuery("SELECT EXTRACT(YEAR FROM tanggal_transaksi) AS tahun, SUM(jumlah_pengunjung * harga_tiket) AS total_pendapatan FROM transaksi JOIN detail_transaksi USING (id_transaksi) JOIN jenis_pengunjung USING (id_jenis_pengunjung) GROUP BY EXTRACT(YEAR FROM tanggal_transaksi) ORDER BY tahun");

            List<long> yearValues = new List<long>();
            List<String> yearLabels = new List<string>();

            foreach (DataRow row in dataPerTahun.Rows)
            {
                yearValues.Add((long)row[1]);
                yearLabels.Add(((decimal)row[0]).ToString());
            }

            cartDataTahun.Series = new ISeries[]
            {
                new ColumnSeries<long>
                {
                    TooltipLabelFormatter = (value) => $"Rp {value.PrimaryValue.ToString("N0")}",
                    Name = "Jumlah",
                    Values = yearValues
                }
            };

            cartDataTahun.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = (value) => "Rp " + value.ToString("N0"),
                    Labels = yearLabels
                }
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
