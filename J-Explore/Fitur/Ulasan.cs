using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace J_Explore.Fitur
{
    public partial class Ulasan : Form
    {

        public class FeedbackUser
        {
            public string Ulasan { get; set; }
            public int IdAkunUser { get; set; }
        }

        public class Program
        {
            public static void ReadUlasan()
            {
                string connectionString = "your_connection_string_here";

                // SQL query to select ulasan and id_akun_user from feedback_user table
                string query = "SELECT ulasan, id_akun_user FROM feedback_user";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FeedbackUser feedback = new FeedbackUser();
                                feedback.Ulasan = reader.GetString(0);
                                feedback.IdAkunUser = reader.GetInt32(1);

                                // Use the retrieved data as needed
                                Console.WriteLine("Ulasan: " + feedback.Ulasan);
                                Console.WriteLine("ID Akun User: " + feedback.IdAkunUser);
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }

        public Ulasan()
        {
            InitializeComponent();
        }

    }
}
