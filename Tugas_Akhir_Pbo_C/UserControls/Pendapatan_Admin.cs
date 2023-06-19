using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Logitop.Services;
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
using System.Diagnostics;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Pendapatan_Admin : UserControl
    {
        public Pendapatan_Admin()
        {
            InitializeComponent();
            readDaysIncome();
        }

        private void readDaysIncome()
        {
            ObservableCollection<int> total = new ObservableCollection<int>();
            List<string> days = new List<string>();
            DataTable data = DbHelper.GetInstance().ExecuteQuery("select date(tanggal_transaksi) as tanggal, sum(to_number(nominal_transaksi, '9999999999')) as nominal from transaksi\r\njoin detail_transaksi using (id_transaksi)\r\ngroup by date(tanggal_transaksi)");

            foreach (DataRow row in data.Rows)
            {
                DateTime dateIncome = Convert.ToDateTime(row["tanggal"]);
                if (DateTime.Now.Month == dateIncome.Month)
                {
                    total.Add(Convert.ToInt32(row["nominal"]));
                    days.Add(dateIncome.ToString("dd MMM"));
                }
            }

            cartesianChart1.Series = new ISeries[] {
                new ColumnSeries<int>
                {
                    Name = "Jumlah",
                    Values = total
                }
            };

            foreach (DataRow row in data.Rows)
            {
                Console.WriteLine();
            }

            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = (value) => "Rp " + value.ToString("N0"),
                    Labels = days
                }
            };
        }
    }
}
