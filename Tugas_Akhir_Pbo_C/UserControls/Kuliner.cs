using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Kuliner : UserControl
    {
        public Kuliner()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string kataKunci = Username_Login.Text; // Mengambil kata kunci dari TextBox cari

            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1;Database=1;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM kuliner WHERE Username_Login LIKE '%' + @KataKunci + '%'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KataKunci", kataKunci);

                SqlDataReader reader = command.ExecuteReader();

                string hasil = "";
                while (reader.Read())
                {
                    // Mengambil nilai dari kolom yang diinginkan
                    string nilaiKolom = reader.GetString(0); // Mengambil nilai kolom pertama sebagai contoh

                    hasil += nilaiKolom + Environment.NewLine;
                }

                reader.Close();
                connection.Close();

                MessageBox.Show(hasil, "Hasil Pencarian");
            }
        }
    }
}
