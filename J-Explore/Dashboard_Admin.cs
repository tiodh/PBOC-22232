using J_Explore.Properties;
using J_Explore.Utils;
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
            OpenChildFrom(new Kasir(), "Kasir");
        }

        public void OpenChildFrom(Form childFrom, string title)
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
            tittlePageAdmin.Text = title.ToUpper();

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
            OpenChildFrom(new diagrampendapatan(), "Diagram Pendapatan");
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
            OpenChildFrom(new pendapatan(), "Pendapatan");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new pendataan(), "Pendataan");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new diagrampendataan(), "Diagram Pendapatan");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Registrasi_Admin(), "Registrasi Admin");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Kasir(), "Kasir");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Riwayat(), "Riwayat");
        }

        private void OnTableLayoutKasirMouseEnter(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Global.OnHoverColor;

        }

        private void OnTableLayoutKasirMouseLeave(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Color.FromArgb(63, 130, 109);
        }

        private void OnPictureBoxKasirMouseEnter(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Global.OnHoverColor;
        }

        private void OnPictureBoxKasirMouseLeave(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Color.FromArgb(63, 130, 109);
        }

        private void OnPanelKasirMouseEnter(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Global.OnHoverColor;
        }

        private void OnPanelKasirMouseLeave(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Color.FromArgb(63, 130, 109);
        }

        private void OnLabelKasirMouseEnter(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Global.OnHoverColor;
        }

        private void OnLabelKasirMouseLeave(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Color.FromArgb(63, 130, 109);
        }

        private void OnTableLayoutRiwayatMouseEnter(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Global.OnHoverColor;
        }

        private void OnTableLayoutRiwayatMouseLeave(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Color.FromArgb(63, 130, 109);
        }

        private void OnPanelRiwayatMouseEnter(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Global.OnHoverColor;
        }

        private void OnPanelRiwayatMouseLeave(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Color.FromArgb(63, 130, 109);
        }

        private void OnPictureBoxRiwayatMouseEnter(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Global.OnHoverColor;
        }

        private void OnPictureBoxRiwayatMouseLeave(object sender, EventArgs e)
        {
            //tableLayoutPanel1.BackColor = Color.FromArgb(63, 130, 109);
        }
    }
}
