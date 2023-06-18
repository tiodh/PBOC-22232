using System.Data;
using System.Windows.Forms;

namespace _222410103030_steven_create_data_harga_wisata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using NpgsqlConnection;
            string connString = "Host=localhost;Port=5432;Database=back_end;Username=postgres;Password=starco";
            Npgsql.NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            string sql = "SELECT * FROM harga_tiket";
            Npgsql.NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_price = textBox1.Text;
            string price = textBox2.Text;
            dataGridView1.Rows.Add(id_price, price);
            textBox1.Clear();
            textBox2.Clear();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
        }
    }

    internal class NpgsqlConnection
    {
        private string connString;

        public NpgsqlConnection(string connString)
        {
            this.connString = connString;
        }

        public static implicit operator Npgsql.NpgsqlConnection(NpgsqlConnection v)
        {
            throw new NotImplementedException();
        }
    }

    internal class NpgsqlDataAdapter
    {
        private string sql;
        private NpgsqlConnection conn;

        public NpgsqlDataAdapter(string sql, NpgsqlConnection conn)
        {
            this.sql = sql;
            this.conn = conn;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public NpgsqlDataAdapter(string sql, Npgsql.NpgsqlConnection conn1) => this.sql = sql;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static implicit operator Npgsql.NpgsqlDataAdapter(NpgsqlDataAdapter v)
        {
            throw new NotImplementedException();
        }
    }
}