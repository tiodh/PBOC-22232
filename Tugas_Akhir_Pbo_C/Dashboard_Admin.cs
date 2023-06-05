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
    }
}
