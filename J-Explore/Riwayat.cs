using J_Explore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_Explore.Properties
{
    public partial class Riwayat : Form
    {
        public Riwayat()
        {
            InitializeComponent();
        }

        private void OnButtonExportExcelClick(object sender, EventArgs e)
        {
            ExportHelper.ExportReportToExcel(new List<PrintingArgumentsTransaction>
                {
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 3, 1000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 4, 2, 2000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 3, 3000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 1, 1, 4000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 0, 5000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 0, 6000),
                }
            );
        }

        private void OnButtonExportPdfClick(object sender, EventArgs e)
        {
            ExportHelper.ExportReportToPdf(new List<PrintingArgumentsTransaction>
                {
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 3, 1000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 4, 2, 2000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 3, 3000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 1, 1, 4000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 0, 5000),
                    new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 0, 6000),
                }
            );
        }

        private void Riwayat_Load(object sender, EventArgs e)
        {

        }
    }
}
