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
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string sql = @"SELECT akun_user.username, feedback_user.ulasan FROM akun_user JOIN feedback_user ON feedback_user.id_akun_user = akun_user.id_akun_user;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = dt;
            MessageBox.Show("Ulasan berhasil ditampilkan!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OnReadUlasan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = @"DELETE FROM feedback_user WHERE id_akun_user IN (SELECT akun_user.id_akun_user FROM akun_user JOIN feedback_user ON feedback_user.id_akun_user = akun_user.id_akun_user WHERE akun_user.username = '" + textBox3.Text + "');";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ulasan berhasil dihapus!");
            OnReadUlasan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = @"WITH new_akun_user AS(INSERT INTO akun_user(username) VALUES('" + textBox3.Text + "') RETURNING id_akun_user) INSERT INTO feedback_user(ulasan, id_akun_user) VALUES('" + textBox1.Text + "', (SELECT id_akun_user FROM new_akun_user));";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ulasan berhasil dibuat!");
            OnReadUlasan();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = @"WITH updated_akun_user AS (UPDATE akun_user SET username = textBox3.Text RETURNING id_akun_user)UPDATE feedback_user SET ulasan = '" + textBox1.Text + "' WHERE id_akun_user IN (SELECT id_akun_user FROM updated_akun_user);";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ulasan berhasil diedit!");
            OnReadUlasan();
        }
    }
}
