using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J_Explore.Utils;
using Npgsql;

namespace J_Explore.Fitur
{
    public partial class Ulasan : Form
    {
        private string connString = $"Host={Global.DbHost};Port={Global.DbPort};Database={Global.DbName};Username={Global.DbUsername};Password={Global.DbPassword}";
        private NpgsqlConnection conn;
        private DataTable dt;
        private NpgsqlCommand cmd;
        public Ulasan()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Ulasan_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
        }

        private void OnReadUlasan()
        {
            conn.Open();
            string sql = @"SELECT akun_user.username, feedback_user.ulasan FROM feedback_user JOIN akun_user ON feedback_user.id_akun_user = akun_user.id_akun_user;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OnReadUlasan();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
