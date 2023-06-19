﻿using J_Explore.Fitur;
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
    public partial class Dashboard_User : Form
    {
        Kuliner kuliner = new Kuliner();
        Form activeForm;
        public Dashboard_User()
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
            this.panel12.Controls.Add(childFrom);
            this.panel12.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            tittlePageAdmin.Text = childFrom.Text;

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Kuliner(), sender);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Contact_Darurat(), sender);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Ulasan(), sender);
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Harga_Tiket(), sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Kuliner(), sender);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Contact_Darurat(), sender);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Ulasan(), sender);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Harga_Tiket(), sender);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Beranda(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Beranda(), sender);
        }
    }
}