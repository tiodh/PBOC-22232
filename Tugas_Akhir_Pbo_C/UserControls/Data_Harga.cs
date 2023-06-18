using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Data_Harga : UserControl
    {
        public Data_Harga()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            {
                {
                    string connectionString = "Host=localhost;Username=postgres;Password=Kemas3788;Database=pbo;Port=3788";
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        string selectQuery = "SELECT * FROM harga_tiket";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(selectQuery, connection))
                        {
                            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id_harga_tiket = reader.GetInt32(0);
                                    int harga_tiket = reader.GetInt32(1);
                                    MessageBox.Show($"ID: {id_harga_tiket}, Harga Tiket: {harga_tiket}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
