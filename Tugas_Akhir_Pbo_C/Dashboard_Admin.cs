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
    public partial class Dashboard_Admin : Form
    {
        UserControls.Data_Pengunjung Data_Pengunjung = new UserControls.Data_Pengunjung();
        UserControls.Riwayat_Admin Riwayat_Admin = new UserControls.Riwayat_Admin();
        UserControls.Pengunjung Pengunjung = new UserControls.Pengunjung();
        UserControls.Pendapatan_Admin Pendapatan_Admin  = new UserControls.Pendapatan_Admin();
        UserControls.Review Review = new UserControls.Review();
        UserControls.Registrasi_Admin Registrasi = new UserControls.Registrasi_Admin();
        UserControls.Contact_Darurat Contact = new UserControls.Contact_Darurat();
        UserControls.Grafik_Pengunjung diagram_Pengunjung = new UserControls.Grafik_Pengunjung();
        UserControls.Grafik_Keuangan diagramKeuangan = new UserControls.Grafik_Keuangan();
        public Dashboard_Admin()
        {
            InitializeComponent();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(Data_Pengunjung);
            Data_Pengunjung.Dock = DockStyle.Fill;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(Pendapatan_Admin);
            Pendapatan_Admin.Dock = DockStyle.Fill;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(Riwayat_Admin);
            Riwayat_Admin.Dock = DockStyle.Fill;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(Pengunjung);
            Pengunjung.Dock = DockStyle.Fill;
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(Review);
            Review.Dock = DockStyle.Fill;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(Registrasi);
            Registrasi.Dock = DockStyle.Fill;
        }

        private void Button_Darurat_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(Contact);
            Contact.Dock = DockStyle.Fill;
        }

        private void diagramPengunjung_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(diagram_Pengunjung);
            diagram_Pengunjung.Dock = DockStyle.Fill;
        }

        private void diagramPendapatan_Click(object sender, EventArgs e)
        {
            PanelUtamaAdmin.Controls.Clear();
            PanelUtamaAdmin.Controls.Add(diagramKeuangan);
            diagramKeuangan.Dock = DockStyle.Fill;
        }
    }
}
