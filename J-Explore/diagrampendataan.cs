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
namespace J_Explore
{
    public partial class diagrampendataan : Form
    {
        private ObservableCollection<DateTimePoint> weeklyData;
        private string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=Ilmiana15!";
        private NpgsqlConnection _dbConnection;

        public diagrampendataan()
        {
            InitializeComponent();
            _dbConnection = new NpgsqlConnection(connectionString);

            // Inisialisasi koleksi tanggal dan jumlah pengunjung
            weeklyData = new ObservableCollection<DateTimePoint>();

            // Tambahkan event handler untuk perubahan nilai DateTimePicker
            dateTimeMinggu.ValueChanged += DateTimePickerMinggu_ValueChanged;

            // Panggil metode untuk mengisi data
            LoadData();
        }

        private void LoadData()
        {
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
                    long weekStartDateTicks = weeklyGroup.WeekStartDate.Ticks;
                    DateTime weekStartDate = DateTime.FromOADate(weekStartDateTicks);
                    weeklyData.Add(new DateTimePoint(weekStartDate, weeklyGroup.Total));
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
                    long weekStartDateTicks = weeklyGroup.WeekStartDate.Ticks;
                    DateTime weekStartDate = DateTime.FromOADate(weekStartDateTicks);
                    weeklyData.Add(new DateTimePoint(weekStartDate, weeklyGroup.Total));
                }

            }

            // Konfigurasi grafik
            cartDataMinggu.Title = new LabelVisual
            {
                Text = "Jumlah Pengunjung",
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
                    Labeler = value => ((DateTime)value).ToString("dd MMM yyyy"),
                    LabelsRotation = 45,
                    UnitWidth = TimeSpan.FromDays(1).Ticks,
                    MinStep = TimeSpan.FromDays(1).Ticks,
                }
            };
        }

        private void DateTimePickerMinggu_ValueChanged(object sender, EventArgs e)
        {
            // Hapus semua data sebelum memuat data baru
            weeklyData.Clear();

            // Panggil metode untuk memuat data
            LoadData();
        }

        private void cartesianChart2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
