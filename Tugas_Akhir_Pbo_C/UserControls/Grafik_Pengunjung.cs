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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.VisualElements;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class UserControl5 : UserControl
    {
        private readonly NpgsqlConnection _dbConnection;
        public UserControl5()
        {
            InitializeComponent();

            string connectionString = "Host=localhost;Port=5432;Database=pbo_final;Username=postgres;Password=indra1978";
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

            if (duration.Days >= 7)
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
                    weeklyData.Add(new DateTimePoint(dailyGroup.Date, dailyGroup.Total));
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
                    weeklyData.Add(new DateTimePoint(dailyGroup.Date, dailyGroup.Total));
                }
            }

            // Konfigurasi grafik
            Chart1.Title = new LabelVisual
            {
                Text = "Laporan Jumlah Pengunjung",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };

            Chart1.Series = new ISeries[]
            {
                new ColumnSeries<DateTimePoint>
                {
                    TooltipLabelFormatter = (chartPoint) => $"{new DateTime((long)chartPoint.SecondaryValue):dd MMM yyyy}: {chartPoint.PrimaryValue:N0}",
                    Name = "Jumlah Pengunjung",
                    Values = weeklyData
                }
            };

            Chart1.XAxes = new Axis[]
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }
    }
}
