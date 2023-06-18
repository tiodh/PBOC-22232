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
    public partial class Registrasi_Admin : UserControl
    {
        public Registrasi_Admin()
        {
            InitializeComponent();
        }

        private void kryptonCheckButton2_Click(object sender, EventArgs e)
        {
            
            string username = kryptonTextBox5.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=rikiyudi123;Database=Projek PBO"))
            {
                connection.Open();

                
                string sql = "DELETE FROM akun_admin WHERE username = @username";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    
                    command.Parameters.AddWithValue("@username", username);

                    
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Akun admin berhasil dihapus.");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Akun admin tidak ditemukan.");
                    }
                }
            }
        }
        private void ClearTextBoxes()
        {
            
            kryptonTextBox5.Text = "";
            kryptonTextBox1.Text = "";
            kryptonTextBox3.Text = "";
            kryptonTextBox2.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registrasi_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
