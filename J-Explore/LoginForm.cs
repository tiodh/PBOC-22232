using J_Explore;
using J_Explore.Services;
using J_Explore.Utils;
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
        NpgsqlConnection connTol = new NpgsqlConnection($"Server={Global.DbHost};Port={Global.DbPort};User Id={Global.DbUsername};Password={Global.DbPassword};Database={Global.DbName}");
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
                connTol.Open();
                string query = $"select * from akun_admin where username = '{username.Text}' and password = '{password.Text}'";
                NpgsqlDataAdapter sda = new NpgsqlDataAdapter(query, connTol);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    inputUsername = username.Text;
                    inputPassword = password.Text;

                    
                    Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
                    dashboard_Admin.ShowDialog();
                    this.Close();
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
                connTol.Close();
            }

        }
    }
}
