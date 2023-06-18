using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public class DatabaseHelper
    {
        private string ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=1;Database=1;";
        private NpgsqlConnection conn = null;

        public DatabaseHelper()
        {
            conn = new NpgsqlConnection(ConnectionString);
        }

        public void Execute(string Query)
        {
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public NpgsqlDataReader Select(string Query)
        {
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}