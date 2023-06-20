using J_Explore.Lib;
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

namespace J_Explore.Fitur
{
    public partial class Beranda : Form
    {
        private string connString = "Server=localhost; Port=5432; User Id=postgres; Password=123; Database=postgres";
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public Beranda()
        {
            InitializeComponent();
        }

        private void Beranda_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
            Read();
            Data1();
            Data2();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Read()
        {
            conn.Open();
            string sql = @"select definisi_rembangan from rembangan where id_definisi_rembangan = '1'";
            cmd = new NpgsqlCommand(sql, conn);
            string? execute = cmd.ExecuteScalar()?.ToString();
            textBox1.Text = execute;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data1()
        {
            try
            {
                conn.Open();
                string data1 = @"select nama_jenis_fasilitas, deskripsi_jenis_fasilitas from jenis_fasilitas";
                cmd = new NpgsqlCommand(data1, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Data2()
        {
            try
            {
                conn.Open();
                string data2 = @"select nama_kuliner, harga_kuliner from kuliner";
                cmd = new NpgsqlCommand(data2, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
