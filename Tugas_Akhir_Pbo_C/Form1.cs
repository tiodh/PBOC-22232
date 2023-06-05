using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Tugas_Akhir_Pbo_C
{
    public partial class Form1 : KryptonForm
    {
        UserControls.Data_Harga USserControl2 = new UserControls.Data_Harga();
        UserControls.Rekomendasi USserControl3 = new UserControls.Rekomendasi();
        UserControls.UserControl4 USserControl4 = new UserControls.UserControl4();
        UserControls.Beranda_User Beranda_User = new UserControls.Beranda_User();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            PanelUtama.Controls.Clear();
            PanelUtama.Controls.Add(USserControl4);
            USserControl4.Dock = DockStyle.Fill;
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (LoginAdmin uu = new LoginAdmin())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            PanelUtama.Controls.Clear();
            PanelUtama.Controls.Add(USserControl2);
            USserControl2.Dock = DockStyle.Fill;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            PanelUtama.Controls.Clear();
            PanelUtama.Controls.Add(USserControl3);
            USserControl3.Dock = DockStyle.Fill;
        }

        private void PanelUtama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            PanelUtama.Controls.Clear();
            PanelUtama.Controls.Add(Beranda_User);
            Beranda_User.Dock = DockStyle.Fill;
        }
    }
}
