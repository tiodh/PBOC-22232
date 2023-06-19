using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace J_Explore.Lib
{
    public partial class Fasilitas : Form
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        public Fasilitas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Fasilitas_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection();
        }
    }
}
