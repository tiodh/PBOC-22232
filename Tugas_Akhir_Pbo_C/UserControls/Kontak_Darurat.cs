using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Kontak_Darurat : UserControl
    {
        private const string connectionString = "Server = localhost; Port = 5432; User Id= postgres; Password=12345; Database = database-pbo-final;";

        public Kontak_Darurat()
        {
            InitializeComponent();
        }

        private void Read()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "Select * from layanan_darurat";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.CommandText = sql;
                    NpgsqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        string email = reader.GetString(1);
                        string phone = reader.GetString(2);
                        string deskripsi = reader.GetString(3);

                        kryptonDataGridView1.Rows.Add(name, email, phone, deskripsi);
                    }
                }
            }
            connection.Close();
        }
    }
}

