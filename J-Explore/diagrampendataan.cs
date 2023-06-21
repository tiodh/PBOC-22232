using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using Npgsql;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.VisualElements;
using System.Data.Common;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.Kernel.Sketches;
using J_Explore.Utils;

namespace J_Explore
{
    public partial class diagrampendataan : Form
    {
        private ObservableCollection<DateTimePoint> weeklyData;
        private string connectionString = $"Host={Global.DbHost};Port={Global.DbPort};Database={Global.DbName};Username={Global.DbUsername};Password={Global.DbPassword}";
        private NpgsqlConnection _dbConnection;

        public diagrampendataan()
        {
            InitializeComponent();
            _dbConnection = new NpgsqlConnection(connectionString);

            // Inisialisasi koleksi tanggal dan jumlah pengunjung
            ObservableCollection<DateTimePoint> weeklyData = new ObservableCollection<DateTimePoint>();
            ObservableCollection<DateTimePoint> weeklyData2 = new ObservableCollection<DateTimePoint>();
            ObservableCollection<DateTimePoint> monthlyData = new ObservableCollection<DateTimePoint>();
            // Ambil data dari database
            _dbConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT tanggal_transaksi, count(nama_pengunjung) AS total_pengunjung FROM transaksi GROUP BY tanggal_transaksi", _dbConnection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            _dbConnection.Close();

            DateTime firstDate = (DateTime)data.Rows[0]["tanggal_transaksi"];
            DateTime lastDate = (DateTime)data.Rows[data.Rows.Count - 1]["tanggal_transaksi"];
            //DateTime endDate = startDate.AddMonths(1).AddDays(-1);


            // Menghitung durasi antara tanggal pertama dan terakhir
            TimeSpan duration = lastDate - firstDate;

            if (duration.Days >= 30)
            {
                var monthlyGroups = data.AsEnumerable()
                    .GroupBy(row => new DateTime(((DateTime)row["tanggal_transaksi"]).Year, ((DateTime)row["tanggal_transaksi"]).Month, 1))
                    .Select(group => new
                    {
                        MonthStartDate = group.Key,
                        Total = group.Sum(row => (int)(long)row["total_pengunjung"])
                    })
                    .OrderBy(group => group.MonthStartDate);

                foreach (var monthlyGroup in monthlyGroups)
                {
                    monthlyData.Add(new DateTimePoint(monthlyGroup.MonthStartDate, monthlyGroup.Total));
                }
            }
            else
            {
                var dailyGroups = data.AsEnumerable()
                    .Select(row => new
                    {
                        Date = ((DateTime)row["tanggal_transaksi"]).Date,
                        Total = (int)(long)row["total_pengunjung"]
                    })
                    .OrderBy(group => group.Date);

                foreach (var dailyGroup in dailyGroups)
                {
                    monthlyData.Add(new DateTimePoint(dailyGroup.Date, dailyGroup.Total));
                }
            }

            // Konfigurasi grafik
            cartBulan.Title = new LabelVisual
            {
                Text = "Jumlah Pengunjung",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };

            cartBulan.Series = new ISeries[]
            {
            new ColumnSeries<DateTimePoint>
            {
                TooltipLabelFormatter = (chartPoint) => $"{new DateTime((long)chartPoint.SecondaryValue):dd MMM yyyy}: {chartPoint.PrimaryValue:N0}",
                Name = "Jumlah Pengunjung",
                Values = monthlyData
            }
            };

            cartBulan.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = value => new DateTime((long)value).ToString("MMM yyyy"),
                    LabelsRotation = 45,
                    UnitWidth = TimeSpan.FromDays(30).Ticks, // Menggunakan 30 hari sebagai unit lebar
                    MinStep = TimeSpan.FromDays(30).Ticks, // Minimal jarak antara label adalah 30 hari
                }
            };
            if (duration.Days >= 7)
            {
                // Mengelompokkan data menjadi mingguan
                var weeklyGroups = data.AsEnumerable()
                    .GroupBy(row => new
                    {
                        Year = ((DateTime)row["tanggal_transaksi"]).Year,
                        Week = ((DateTime)row["tanggal_transaksi"]).AddDays(-((int)((DateTime)row["tanggal_transaksi"]).DayOfWeek)).ToString("yyyy-MM-dd")
                    })
                    .Select(group => new
                    {
                        WeekStartDate = DateTime.Parse(group.Key.Week),
                        Total = group.Sum(row => (int)row["total_pengunjung"])
                    })
                    .OrderBy(group => group.WeekStartDate);

                foreach (var weeklyGroup in weeklyGroups)
                {
                    weeklyData.Add(new DateTimePoint(new DateTime(weeklyGroup.WeekStartDate.Ticks), weeklyGroup.Total));
                }
            }
            else
            {
                // Tampilkan data harian jika durasinya kurang dari 7 hari
                var weeklyGroups = data.AsEnumerable()
                    .GroupBy(row => new
                    {
                        Year = ((DateTime)row["tanggal_transaksi"]).Year,
                        Week = ((DateTime)row["tanggal_transaksi"]).AddDays(-((int)((DateTime)row["tanggal_transaksi"]).DayOfWeek)).ToString("yyyy-MM-dd")
                    })
                    .Select(group => new
                    {
                        WeekStartDate = DateTime.Parse(group.Key.Week),
                        Total = group.Sum(row => (int)(long)row["total_pengunjung"])
                    })
                    .OrderBy(group => group.WeekStartDate);

                foreach (var weeklyGroup in weeklyGroups)
                {
                    weeklyData.Add(new DateTimePoint(weeklyGroup.WeekStartDate, weeklyGroup.Total));
                }
            }
            // Konfigurasi grafik
            cartDataMinggu.Title = new LabelVisual
            {
                Text = "Laporan Jumlah Pengunjung",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };

            cartDataMinggu.Series = new ISeries[]
            {
                new ColumnSeries<DateTimePoint>
                {
                    TooltipLabelFormatter = (chartPoint) => $"{new DateTime((long)chartPoint.SecondaryValue):dd MMM yyyy}: {chartPoint.PrimaryValue:N0}",
                    Name = "Jumlah Pengunjung",
                    Values = weeklyData
                }
            };

            cartDataMinggu.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = value => new DateTime((long)value).ToString("dd MMM yyyy"),
                    LabelsRotation = 45,
                    UnitWidth = TimeSpan.FromDays(1).Ticks,
                    MinStep = TimeSpan.FromDays(1).Ticks,
                }
            };
            if (duration.Days >= 7)
            {
                var dailyGroups2 = data.AsEnumerable()
                    .Select(row => new
                    {
                        Date = ((DateTime)row["tanggal_transaksi"]).Date,
                        Total = (int)(long)row["total_pengunjung"]
                    })
                    .OrderBy(group => group.Date);

                foreach (var dailyGroup2 in dailyGroups2)
                {
                    weeklyData2.Add(new DateTimePoint(dailyGroup2.Date, dailyGroup2.Total));
                }
            }

            else
            {
                var dailyGroups2 = data.AsEnumerable()
                    .Select(row => new
                    {
                        Date = ((DateTime)row["tanggal_transaksi"]).Date,
                        Total = (int)(long)row["total_pengunjung"]
                    })
                    .OrderBy(group => group.Date);

                foreach (var dailyGroup2 in dailyGroups2)
                {
                    weeklyData2.Add(new DateTimePoint(dailyGroup2.Date, dailyGroup2.Total));
                }
            }

            // Konfigurasi grafik
            cartHari.Title = new LabelVisual
            {
                Text = "Laporan Jumlah Pengunjung",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };

            cartHari.Series = new ISeries[]
            {
                new ColumnSeries<DateTimePoint>
                {
                    TooltipLabelFormatter = (chartPoint) => $"{new DateTime((long)chartPoint.SecondaryValue):dd MMM yyyy}: {chartPoint.PrimaryValue:N0}",
                    Name = "Jumlah Pengunjung",
                    Values = weeklyData2
                }
            };

            cartHari.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = value => new DateTime((long)value).ToString("dd MMM yyyy"),
                    LabelsRotation = 45,
                    UnitWidth = TimeSpan.FromDays(1).Ticks,
                    MinStep = TimeSpan.FromDays(1).Ticks,
                }
            };
        }



        private void cartesianChart2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
