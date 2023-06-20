using System;
using J_Explore.Fitur;
using J_Explore.Lib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using J_Explore.Utils;

namespace J_Explore.Lib
{
    public partial class FasilitasUser : Form
    {
        private string connString = $"Server={Global.DbHost}; Port={Global.DbPort}; User Id={Global.DbUsername}; Password={Global.DbPassword}; Database={Global.DbName}";
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        Form activeForm;
        public FasilitasUser()
        {
            InitializeComponent();
        }
        private void Fasilitas_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
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
            this.panel1.Controls.Add(childFrom);
            this.panel1.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas1 = new DetailFasilitas();
            conn.Open();

            detailfasilitas1.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\musicorner2.jpeg";

            string sql1 = @"select nama_fasilitas from fasilitas where id_fasilitas = '13'";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox1.Text = result1;

            string sql2 = @"select jumlah_fasilitas from fasilitas where id_fasilitas = '13'";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox2.Text = result2;

            string sql3 = @"select harga_fasilitas from fasilitas where id_fasilitas = '13'";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '13'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '3'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas1, sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas9 = new DetailFasilitas();
            conn.Open();

            detailfasilitas9.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\playground2.jpeg";

            string sql1 = @"select nama_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '9'";
            cmd = new NpgsqlCommand(sql1, conn);
            string result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas9.textBox1.Text = result1;

            string sql2 = @"select jumlah_fasilitas from fasilitas where id_fasilitas = '18'";
            cmd = new NpgsqlCommand(sql2, conn);
            string result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas9.textBox2.Text = result2;

            string sql3 = @"select harga_fasilitas from fasilitas where id_fasilitas = '18'";
            cmd = new NpgsqlCommand(sql3, conn);
            string result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas9.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '18'";
            cmd = new NpgsqlCommand(sql4, conn);
            string result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas9.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '9'";
            cmd = new NpgsqlCommand(sql5, conn);
            string result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas9.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas9, sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas2 = new DetailFasilitas();
            conn.Open();

            detailfasilitas2.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\hotel2.jpeg  ";

            string sql1 = @"select nama_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '2'";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox1.Text = result1;

            string sql2 = @"select (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '4') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '5')+ (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '6') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '7') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '8') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '9') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '10');";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox2.Text = result2;

            string sql3 = @"select (select harga_fasilitas from fasilitas where id_fasilitas = '10') ||' - '|| (select harga_fasilitas from fasilitas where id_fasilitas = '4');";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '3'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '2'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas2, sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas4 = new DetailFasilitas();
            conn.Open();

            detailfasilitas4.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\aula2.jpeg";

            string sql1 = @"select substring(nama_fasilitas, 1, 5) as nama from fasilitas where id_fasilitas = '11';";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas4.textBox1.Text = result1;

            string sql2 = @"select (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '11') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '12');";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas4.textBox2.Text = result2;

            string sql3 = @"select (select harga_fasilitas from fasilitas where id_fasilitas = '12') ||' - '|| (select harga_fasilitas from fasilitas where id_fasilitas = '11');";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas4.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '11'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas4.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '10'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas4.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas4, sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas5 = new DetailFasilitas();
            conn.Open();

            detailfasilitas5.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\kantin2.jpeg";

            string sql1 = @"select nama_fasilitas from fasilitas where id_fasilitas = '17'";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas5.textBox1.Text = result1;

            string sql2 = @"select jumlah_fasilitas from fasilitas where id_fasilitas = '17'";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas5.textBox2.Text = result2;

            string sql3 = @"select harga_fasilitas from fasilitas where id_fasilitas = '17'";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas5.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '17'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas5.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '8'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas5.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas5, sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas6 = new DetailFasilitas();
            conn.Open();

            detailfasilitas6.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\suiteroom3.jpeg";

            string sql1 = @"select nama_fasilitas from fasilitas where id_fasilitas = '3'";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas6.textBox1.Text = result1;

            string sql2 = @"select jumlah_fasilitas from fasilitas where id_fasilitas = '3'";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas6.textBox2.Text = result2;

            string sql3 = @"select harga_fasilitas from fasilitas where id_fasilitas = '3'";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas6.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '3'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas6.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '7'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas6.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas6, sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas7 = new DetailFasilitas();
            conn.Open();

            detailfasilitas7.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\kolamrenang2.jpeg";

            string sql1 = @"select nama_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '1'";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas7.textBox1.Text = result1;

            string sql2 = @"select (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '1') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '2');";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas7.textBox2.Text = result2;

            string sql3 = @"select harga_fasilitas from fasilitas where id_fasilitas = '1'";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas7.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '1'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas7.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '1'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas7.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas7, sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas8 = new DetailFasilitas();
            conn.Open();

            detailfasilitas8.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\campingground2.jpeg";

            string sql1 = @"select nama_fasilitas from fasilitas where id_fasilitas = '14'";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas8.textBox1.Text = result1;

            string sql2 = @"select jumlah_fasilitas from fasilitas where id_fasilitas = '14'";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas8.textBox2.Text = result2;

            string sql3 = @"select harga_fasilitas from fasilitas where id_fasilitas = '14'";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas8.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '14'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas8.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '4'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas8.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas8, sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas10 = new DetailFasilitas();
            conn.Open();

            detailfasilitas10.pictureBox1.ImageLocation = "C:\\Users\\Fahmi\\Downloads\\Blm Fiks\\PBOC-22232-Front_End\\Tugas_Akhir_Pbo_C\\Resources\\restoran.jpg";

            string sql1 = @"select nama_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '5'";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas10.textBox1.Text = result1;

            string sql2 = @"select jumlah_fasilitas from fasilitas where id_fasilitas = '16'";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas10.textBox2.Text = result2;

            string sql3 = @"select harga_fasilitas from fasilitas where id_fasilitas = '16'";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas10.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '16'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas10.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '5'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas10.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas10, sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DetailFasilitas detailfasilitas11 = new DetailFasilitas();
            conn.Open();

            detailfasilitas11.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\PBOC-22232\\J-Explore1\\J-Explore\\Resources\\cafe2.jpeg";

            string sql1 = @"select nama_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '6'";
            cmd = new NpgsqlCommand(sql1, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas11.textBox1.Text = result1;

            string sql2 = @"select jumlah_fasilitas from fasilitas where id_fasilitas = '15'";
            cmd = new NpgsqlCommand(sql2, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas11.textBox2.Text = result2;

            string sql3 = @"select harga_fasilitas from fasilitas where id_fasilitas = '15'";
            cmd = new NpgsqlCommand(sql3, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas11.textBox3.Text = result3;

            string sql4 = @"select jam_operational from fasilitas where id_fasilitas = '15'";
            cmd = new NpgsqlCommand(sql4, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas11.textBox4.Text = result4;

            string sql5 = @"select deskripsi_jenis_fasilitas from jenis_fasilitas where id_jenis_fasilitas = '6'";
            cmd = new NpgsqlCommand(sql5, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas11.textBox5.Text = result5;

            conn.Close();
            OpenChildFrom(detailfasilitas11, sender);
        }
    }
}
