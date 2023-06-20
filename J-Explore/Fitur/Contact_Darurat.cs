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

namespace J_Explore.Fitur
{
    public partial class Contact_Darurat : Form
    {
        private const string connectionString = "Server = localhost; Port = 5432; User Id= postgres; Password=Rizal020304; Database = pbo;";
        public Contact_Darurat()
        {
            InitializeComponent();
            ReadKontakDarurat();
        }

        public void ReadKontakDarurat()
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
                        int id = Convert.ToInt32(reader[0]);
                        string name = reader.GetString(1);
                        string email = reader.GetString(2);
                        string phone = reader.GetString(3);
                        string deskripsi = reader.GetString(4);

                        DataKontakDarurat.Rows.Add(id,name, email, phone, deskripsi);
                    }
                }

                connection.Close();
            }
        }
    }
}
