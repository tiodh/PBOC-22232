using Npgsql;
using System;
using System.Windows.Forms;
using J_Explore.Utils;

namespace J_Explore.Lib
{
    public partial class DetailFasilitas : Form
    {
        private string connString;
        private NpgsqlConnection conn;

        public DetailFasilitas()
        {
            InitializeComponent();

            connString = $"Server={Global.DbHost}; Port={Global.DbPort}; User Id={Global.DbUsername}; Password={Global.DbPassword}; Database={Global.DbName}";
            conn = new NpgsqlConnection(connString);
        }

        FasilitasUser user = new FasilitasUser();

        private void UpdateMusicCorner()
        {

            DetailFasilitas detailfasilitas1 = new DetailFasilitas();
            conn.Open();

            // Update nama fasilitas
            string sqlUpdateNama = "UPDATE fasilitas SET nama_fasilitas = '" + textBox1.Text + "' WHERE id_fasilitas = '13'";
            NpgsqlCommand cmd = new NpgsqlCommand(sqlUpdateNama, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox1.Text = result1;

            // Update jumlah fasilitas
            string sqlUpdateJumlah = "UPDATE fasilitas SET jumlah_fasilitas = '" + textBox2.Text + "' WHERE id_fasilitas = '13'";
            cmd = new NpgsqlCommand(sqlUpdateJumlah, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox2.Text = result2;

            // Update harga fasilitas
            string sqlUpdateHarga = "UPDATE fasilitas SET harga_fasilitas = '" + textBox3.Text + "' WHERE id_fasilitas = '13'";
            cmd = new NpgsqlCommand(sqlUpdateHarga, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox3.Text = result3;

            // Update jam operasional
            string sqlUpdateJam = "UPDATE fasilitas SET jam_operational = '" + textBox4.Text + "' WHERE id_fasilitas = '13'";

            cmd = new NpgsqlCommand(sqlUpdateJam, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox4.Text = result4;

            // Update deskripsi jenis fasilitas
            string sqlUpdateDeskripsi = "UPDATE jenis_fasilitas SET deskripsi_jenis_fasilitas = '" + textBox5.Text + "' WHERE id_jenis_fasilitas = '13'";
            cmd = new NpgsqlCommand(sqlUpdateDeskripsi, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox5.Text = result5;

            conn.Close();

            // Menampilkan pesan sukses atau melakukan tindakan lain setelah update
            MessageBox.Show("Data fasilitas berhasil diperbarui!");
        }

        private void UpdatePlayGround()
        {

            DetailFasilitas detailfasilitas1 = new DetailFasilitas();
            conn.Open();

            // Update nama fasilitas
            string sqlUpdateNama = "UPDATE fasilitas SET nama_fasilitas = '" + textBox1.Text + "' WHERE id_fasilitas = '13'";
            NpgsqlCommand cmd = new NpgsqlCommand(sqlUpdateNama, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox1.Text = result1;

            // Update jumlah fasilitas
            string sqlUpdateJumlah = "UPDATE fasilitas SET jumlah_fasilitas = '" + textBox2.Text + "' WHERE id_fasilitas = '13'";
            cmd = new NpgsqlCommand(sqlUpdateJumlah, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox2.Text = result2;

            // Update harga fasilitas
            string sqlUpdateHarga = "UPDATE fasilitas SET harga_fasilitas = '" + textBox3.Text + "' WHERE id_fasilitas = '13'";
            cmd = new NpgsqlCommand(sqlUpdateHarga, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox3.Text = result3;

            // Update jam operasional
            string sqlUpdateJam = "UPDATE fasilitas SET jam_operational = '" + textBox4.Text + "' WHERE id_fasilitas = '13'";

            cmd = new NpgsqlCommand(sqlUpdateJam, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox4.Text = result4;

            // Update deskripsi jenis fasilitas
            string sqlUpdateDeskripsi = "UPDATE jenis_fasilitas SET deskripsi_jenis_fasilitas = '" + textBox5.Text + "' WHERE id_jenis_fasilitas = '13'";
            cmd = new NpgsqlCommand(sqlUpdateDeskripsi, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas1.textBox5.Text = result5;

            conn.Close();

            // Menampilkan pesan sukses atau melakukan tindakan lain setelah update
            MessageBox.Show("Data fasilitas berhasil diperbarui!");
        }

        private void UpdateHotel()
        {

            DetailFasilitas detailfasilitas2 = new DetailFasilitas();
            conn.Open();

            // Update nama fasilitas
            string sqlUpdateNama = "UPDATE fasilitas SET nama_fasilitas = '" + textBox1.Text + "' WHERE id_fasilitas = '2'";
            NpgsqlCommand cmd = new NpgsqlCommand(sqlUpdateNama, conn);
            string? result1 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox1.Text = result1;

            // Update jumlah fasilitas
            string sqlUpdateJumlah = "select (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '4') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '5')+ (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '6') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '7') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '8') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '9') + (select sum(jumlah_fasilitas) from fasilitas where id_fasilitas = '10');";
            cmd = new NpgsqlCommand(sqlUpdateJumlah, conn);
            string? result2 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox2.Text = result2;

            // Update harga fasilitas
            string sqlUpdateHarga = "UPDATE fasilitas SET harga_fasilitas = '" + textBox3.Text + "' WHERE id_fasilitas = '3'";
            cmd = new NpgsqlCommand(sqlUpdateHarga, conn);
            string? result3 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox3.Text = result3;

            // Update jam operasional
            string sqlUpdateJam = "UPDATE fasilitas SET jam_operational = '" + textBox4.Text + "' WHERE id_fasilitas = '2'";

            cmd = new NpgsqlCommand(sqlUpdateJam, conn);
            string? result4 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox4.Text = result4;

            // Update deskripsi jenis fasilitas
            string sqlUpdateDeskripsi = "UPDATE jenis_fasilitas SET deskripsi_jenis_fasilitas = '" + textBox5.Text + "' WHERE id_jenis_fasilitas = '9'";
            cmd = new NpgsqlCommand(sqlUpdateDeskripsi, conn);
            string? result5 = cmd.ExecuteScalar()?.ToString();
            detailfasilitas2.textBox5.Text = result5;

            conn.Close();

            // Menampilkan pesan sukses atau melakukan tindakan lain setelah update
            MessageBox.Show("Data fasilitas berhasil diperbarui!");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            UpdateMusicCorner();
            UpdateHotel();
            UpdatePlayGround();
        }
    }
}
