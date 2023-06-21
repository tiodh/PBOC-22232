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

namespace J_Explore
{
    public partial class diagrampendapatan : Form
    {
        public diagrampendapatan()
        {
            InitializeComponent();
            readDaysIncome();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
