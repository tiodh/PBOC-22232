﻿using J_Explore;
using J_Explore.Models;
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
        NpgsqlConnection conn = new NpgsqlConnection($"Server={Global.DbHost};Port={Global.DbPort};User Id={Global.DbUsername};Password={Global.DbPassword};Database={Global.DbName}");
        public LoginForm(Dashboard_User dashboard)
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string inputUsername = username.Text.Trim();
            string inputPassword = password.Text.Trim();
            try
            {
                conn.Open();
                string query = $"select * from akun_admin where username = '{username.Text.Trim()}' and password = '{password.Text.Trim()}'";
                NpgsqlDataAdapter sda = new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    inputUsername = username.Text.Trim();
                    inputPassword = password.Text.Trim();

                    Global.CurrentAdmin = Admin.FromDataRow(dt.Rows[0]);

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
            catch (Exception ex)
            {
                MessageBox.Show($"Error, {ex}");
            }
            finally
            {
                conn.Close();
            }

        }

        private void resetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetPage = new ResetPassword();
            resetPage.ShowDialog();
        }
    }
}
