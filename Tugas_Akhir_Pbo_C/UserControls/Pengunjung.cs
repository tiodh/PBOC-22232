using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.VisualElements;
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

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Pengunjung : UserControl
    {
        private readonly NpgsqlConnection _dbConnection;

        public Pengunjung()
        {
            InitializeComponent();

            string connectionString = "Host=localhost;Port=5432;Database=jexplore fix;Username=postgres;Password=12345";
            _dbConnection = new NpgsqlConnection(connectionString);

            // Inisialisasi koleksi tanggal dan jumlah pengunjung
            ObservableCollection<DateTimePoint> weeklyData = new ObservableCollection<DateTimePoint>();

            // Ambil data dari database
            _dbConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT tanggal_transaksi, SUM(jumlah_pengunjung) AS total_pengunjung FROM transaksi JOIN data_pengunjung ON transaksi.id_transaksi = data_pengunjung.id_data_pengunjung GROUP BY tanggal_transaksi", _dbConnection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            _dbConnection.Close();

            DateTime firstDate = (DateTime)data.Rows[0]["tanggal_transaksi"];
            DateTime lastDate = (DateTime)data.Rows[data.Rows.Count - 1]["tanggal_transaksi"];

            // Menghitung durasi antara tanggal pertama dan terakhir
            TimeSpan duration = lastDate - firstDate;

            var monthlyGroups = data.AsEnumerable()
                .GroupBy(row => new
                {
                    Year = ((DateTime)row["tanggal_transaksi"]).Year,
                    Month = ((DateTime)row["tanggal_transaksi"]).ToString("yyyy-MM")
                })
                .Select(group => new
                {
                    MonthStartDate = DateTime.ParseExact(group.Key.Month, "yyyy-MM", CultureInfo.InvariantCulture).ToString("MMMM yyyy"),
                    Total = group.Sum(row => (int)(long)row["total_pengunjung"])
                })
                .OrderBy(group => group.MonthStartDate);

            foreach (var monthlyGroup in monthlyGroups)
            {
                weeklyData.Add(new DateTimePoint(DateTime.ParseExact(monthlyGroup.MonthStartDate, "MMMM yyyy", CultureInfo.InvariantCulture), monthlyGroup.Total));
            }

            // Konfigurasi grafik
            Chart3.Title = new LabelVisual
            {
                Text = "Laporan Jumlah Pengunjung",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };

            Chart3.Series = new ISeries[]
            {
                new ColumnSeries<DateTimePoint>
                {
                    TooltipLabelFormatter = (chartPoint) => $"{new DateTime((long)chartPoint.SecondaryValue):dd MMM yyyy}: {chartPoint.PrimaryValue:N0}",
                    Name = "Jumlah Pengunjung",
                    Values = weeklyData
                }
            };

           Chart3.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = value => new DateTime((long)value).ToString("MMM yyyy"),
                    LabelsRotation = 45,
                    UnitWidth = TimeSpan.FromDays(1).Ticks,
                    MinStep = TimeSpan.FromDays(1).Ticks,
                }
            };
        }
    }
}
