using J_Explore.Services;

namespace J_Explore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PrintHelper.Print(new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 2, 25000));
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
    }
}