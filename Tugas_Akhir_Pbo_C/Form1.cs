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
using Tugas_Akhir_Pbo_C.UserControls;

namespace Tugas_Akhir_Pbo_C
{
    public partial class Form1 : KryptonForm
    {
        UserControls.Data_Harga DataHarga = new UserControls.Data_Harga();
        UserControls.Rekomendasi Rekomendasi = new UserControls.Rekomendasi();
        UserControls.Review USserControl4 = new UserControls.Review();
        UserControls.Beranda_User Beranda_User = new UserControls.Beranda_User();
        UserControls.Fasilitas fasilitas = new UserControls.Fasilitas();
        UserControls.Kuliner Kuliner = new UserControls.Kuliner();
        UserControls.Kontak_Darurat Darurat = new UserControls.Kontak_Darurat();
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
            PanelUtama.Controls.Add(Darurat);
            Darurat.Dock = DockStyle.Fill;
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
            PanelUtama.Controls.Add(fasilitas);
            fasilitas.Dock = DockStyle.Fill;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            PanelUtama.Controls.Clear();
            PanelUtama.Controls.Add(Rekomendasi);
            Rekomendasi.Dock = DockStyle.Fill;
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

        private void Button_Kuliner_Click(object sender, EventArgs e)
        {
            PanelUtama.Controls.Clear();
            PanelUtama.Controls.Add(Kuliner);
            Kuliner.Dock = DockStyle.Fill;
        }
    }
}
