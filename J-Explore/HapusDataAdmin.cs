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

namespace J_Explore
{
    public partial class HapusDataAdmin : Form
    {
        public HapusDataAdmin()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hapusDataAkun();
        }

        private void hapusDataAkun()
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Rizal020304;Database=pbo"))
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
                        usernameInput.Text = "";
                        passwordInput.Text= "";
                    }
                    else
                    {
                        MessageBox.Show("Akun admin tidak ditemukan.");
                    }
                }
            }
        }
    }
}
