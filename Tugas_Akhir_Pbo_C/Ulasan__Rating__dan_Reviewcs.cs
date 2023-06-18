using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Tugas_Akhir_Pbo_C
{
    public partial class Ulasan__Rating__dan_Reviewcs : Form
    {
        public Ulasan__Rating__dan_Reviewcs()
        {
            InitializeComponent();
        }

        class Program
        {
            static void Main(string connectionString)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ulasan, rating FROM feedback_user";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DataGridView dataGridView = new DataGridView();
                    dataGridView.DataSource = dataTable;

                   
                    dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    Form form = new Form();
                    form.Controls.Add(dataGridView);

                    Application.Run(form);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
