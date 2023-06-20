using J_Explore;
using J_Explore.Services;
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

namespace penjualan_laptop.lib.dataProduct
{
    public partial class LoginForm : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection($"Host=localhost;Port=5432;Username=postgres;Password=Rizal020304;Database=pbo;");
        public LoginForm(Dashboard_User dashboard)
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string inputUsername = username.Text;
            string inputPassword = password.Text;
            try
            {
                String query = $"select * from akun_admin where username = '{username.Text}' and password = '{password.Text}'";
                NpgsqlDataAdapter sda = new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    inputUsername = username.Text;
                    inputPassword = password.Text;
                    this.Hide();
                    Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
                    dashboard_Admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username/Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Clear();
                    password.Clear();

                    username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
