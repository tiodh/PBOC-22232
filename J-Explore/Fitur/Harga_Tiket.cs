using J_Explore.Lib;
using J_Explore.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace J_Explore.Fitur
{
    public partial class Harga_Tiket : Form
    {
        private string connsString = $"Host={Global.DbHost};Port={Global.DbPort};Database={Global.DbName};Username={Global.DbUsername};Password={Global.DbPassword}";
        private NpgsqlCommand cmd;
        private NpgsqlConnection conn;
        public Harga_Tiket()
        {
            InitializeComponent();
        }

        private void Harga_Tiket_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connsString);
            ReadText1();
            ReadText2();
        }

        private void ReadText1()
        {
            conn.Open();
            string sql = @"select harga_tiket from jenis_pengunjung where id_jenis_pengunjung = '1'";
            cmd = new NpgsqlCommand(sql, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            textBox1.Text = result1;
            conn.Close();
        }

        private void ReadText2()
        {
            conn.Open();
            string sql = @"select harga_tiket from jenis_pengunjung where id_jenis_pengunjung = '2'";
            cmd = new NpgsqlCommand(sql, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            textBox2.Text = result1;
            conn.Close();
        }
    }
}