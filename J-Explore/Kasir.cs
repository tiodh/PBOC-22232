using J_Explore.Models;
using J_Explore.Services;
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
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }

        private void Kasir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void OnButtonSimpanClick(object sender, EventArgs e)
        {
            string nama = null;
            string asal = null;

            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                nama = textBox2.Text;
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                asal = textBox3.Text;
            }

            DbHelper.GetInstance().Create(Global.TableTransaksi, new Transaksi(1, Global.CurrentAdmin, DateTime.Now, nama, asal).ToDictionary());
            Transaksi lastTransaksi = Transaksi.FromDataRow(DbHelper.GetInstance().ExecuteQuery($"SELECT * FROM {Global.TableTransaksi} ORDER BY {Global.ColumnTransaksiId} DESC LIMIT 1").Rows[0]);

            PrintHelper.Print(new PrintingArgumentsTransaction(lastTransaksi.Id, lastTransaksi.Admin.Username, lastTransaksi.Tanggal, 0, int.Parse(textBox7.Text), int.Parse(textBox4.Text)));
        }

        private void OnJumlahAnakAnakKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnJumlahDewasaKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }
}
