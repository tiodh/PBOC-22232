using J_Explore.Properties;
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
    public partial class Dashboard_Admin : Form
    {
        private Form activeForm;

        public Dashboard_Admin()
        {
            InitializeComponent();
        }

        public void OpenChildFrom(Form childFrom, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.Dock = DockStyle.Fill;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            this.showPanel.Controls.Add(childFrom);
            this.showPanel.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            tittlePageAdmin.Text = childFrom.Text;

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void pendapatan(object sender, EventArgs e)
        {

        }

        private void diagrampendapatan(object sender, EventArgs e)
        {
            OpenChildFrom(new diagrampendapatan(), sender);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            /*OpenChildFrom(Riwayat, sender);*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new pendapatan(), sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new pendataan(), sender);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new diagrampendataan(), sender);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Registrasi_Admin(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Kasir(), sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Riwayat(), sender);
        }
    }
}
