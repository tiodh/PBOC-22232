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
    public partial class PanelUtama : Form
    {
        Fitur.Kuliner Kuliner = new Fitur.Kuliner();
        public PanelUtama()
        {
            InitializeComponent();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            panel10.Controls.Clear();
            panel10.Controls.Add(Kuliner);
            Kuliner.Dock = DockStyle.Fill;
            MessageBox.Show("Hello World");
        }

        private void pendapatan(object sender, EventArgs e)
        {
            
        }

        private void diagrampendapatan(object sender, EventArgs e)
        {

        }

        private void pendataan(object sender, EventArgs e)
        {

        }

        private void diagrampendataan(object sender, EventArgs e)
        {

        }
    }
}
