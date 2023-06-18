using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_Pbo_C
{
    public partial class LoginAdmin : Form
    {

        private string username = "admin";
        private string password = "admin123";
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPalette1_PalettePaint(object sender, ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string inputUsername = Username_Login.Text;
            string inputPassword = Password_Login.Text;

            if (inputUsername == username && inputPassword == password)
            {
                MessageBox.Show("Login berhasil!");

                // Menutup form login
                this.Hide();

                // Membuat instance form baru yang akan ditampilkan setelah login
                Dashboard_Admin Dashboard_Admin = new Dashboard_Admin();

                // Menampilkan form utama
                Dashboard_Admin.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah. Silakan coba lagi.");
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }
    }

}
