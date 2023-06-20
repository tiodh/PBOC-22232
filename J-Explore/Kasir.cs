using J_Explore.Models;
using J_Explore.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace J_Explore
{
    public partial class Kasir : Form
    {
        private List<JenisPengunjung> jenisPengunjung = new List<JenisPengunjung>();
        private int total = 0;

        public Kasir()
        {
            InitializeComponent();

            DataTable pengunjung = DbHelper.GetInstance().Read(Global.TableJenisPengunjung, Global.ColumnJenisPengunjungId);

            foreach (DataRow row in pengunjung.Rows)
            {
                jenisPengunjung.Add(JenisPengunjung.FromDataRow(row));
            }
        }

        private void CountTotal()
        {
            int anakAnak = 0;
            int dewasa = 0;
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                anakAnak = int.Parse(textBox6.Text);
            }
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                dewasa = int.Parse(textBox7.Text);
            }

            int totalAnakAnak = jenisPengunjung[0].HargaTiket * anakAnak;
            int totalDewasa = jenisPengunjung[1].HargaTiket * dewasa;

            int total = totalAnakAnak + totalDewasa;

            textBox4.Text = total.ToString("N0");
        }

        private void ClearState()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
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

            int affectedRows = DbHelper.GetInstance().Create(Global.TableTransaksi, new Transaksi(1, Global.CurrentAdmin, DateTime.Now, nama, asal).ToDictionary());
            if (affectedRows < 0)
            {
                MessageBox.Show("Gagal menambahkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Transaksi lastTransaksi = Transaksi.FromDataRow(DbHelper.GetInstance().ExecuteQuery($"SELECT * FROM {Global.TableTransaksi} JOIN {Global.TableAdmin} ON {Global.TableTransaksi}.{Global.ColumnTransaksiUsernameAdmin} = {Global.TableAdmin}.{Global.ColumnAdminUsername} ORDER BY {Global.ColumnTransaksiId} DESC LIMIT 1").Rows[0]);

            int valueAnak = 0;
            int valueDewasa = 0;

            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                valueAnak = int.Parse(textBox6.Text);
                affectedRows = DbHelper.GetInstance().Create(Global.TableDetailTransaksi, new DetailTransaksi(1, lastTransaksi, jenisPengunjung[0], valueAnak).ToDictionary());
                if (affectedRows < 0)
                {
                    MessageBox.Show("Gagal menambahkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                valueDewasa = int.Parse(textBox7.Text);
                affectedRows = DbHelper.GetInstance().Create(Global.TableDetailTransaksi, new DetailTransaksi(1, lastTransaksi, jenisPengunjung[1], valueDewasa).ToDictionary());
                if (affectedRows < 0)
                {
                    MessageBox.Show("Gagal menambahkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            PrintHelper.Print(new PrintingArgumentsTransaction(lastTransaksi.Id, lastTransaksi.Admin.Username, lastTransaksi.Tanggal, valueAnak, valueDewasa, int.Parse(textBox4.Text.Replace(",", string.Empty))));

            ClearState();
        }

        private void OnTextBoxJumlahAnakAnakKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnTextBoxJumlahDewasaKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnTextBoxJumlahAnakAnakTextChanged(object sender, EventArgs e) => CountTotal();

        private void OnTextBoxJumlahDewasaTextChanged(object sender, EventArgs e) => CountTotal();

        private void OnTextBoxNamaKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void OnTextBoxAsalKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void OnTextBoxJumlahAnakKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox7.Focus();
            }
        }

        private void OnTextBoxJumlahDewasaKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
            

        }

        private void OnTextBoxNominalKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }
    }
}
