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

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Kontak_Darurat : UserControl
    {
        public Kontak_Darurat()
        {
            InitializeComponent();
            connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=nama_database;Username=nama_pengguna;Password=sandi_pengguna");
        }

        private void UpdateEmergencyContact(string location, string contactNumber)
        {
            try
            {
                connection.Open();

                string query = "UPDATE Locations SET EmergencyContact = @ContactNumber WHERE LocationName = @Location";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                command.Parameters.AddWithValue("@Location", location);
                command.ExecuteNonQuery();

                MessageBox.Show("Emergency contact updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Kontak_Darurat_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string location = Username_Login.Text;
            string contactNumber = Username_Login.Text;

            if (string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show("Please enter both location and contact number.");
                return;
            }

            UpdateEmergencyContact(location, contactNumber);
        }
    }
}
