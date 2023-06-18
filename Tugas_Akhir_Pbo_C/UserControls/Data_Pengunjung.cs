using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_Pbo_C.UserControls
{
    public partial class Data_Pengunjung : UserControl
    {
        private DataContext dataContext;
        public Data_Pengunjung()
        {
            InitializeComponent();
            dataContext = new DataContext();
        }

        private void Data_Pengunjung_Load(object sender, EventArgs e)
        {
            LoadDataPengunjung();
        }

        private void LoadDataPengunjung()
        {

        }

        private void kryptonCheckButton3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kryptonTextBox5.Text))
            {
                int idDataPengunjung = Convert.ToInt32(kryptonTextBox5.Text);
                string namaPengunjung = kryptonTextBox1.Text;
                string alamatPengunjung = kryptonTextBox2.Text;
                int jumlahPengunjung = Convert.ToInt32(kryptonTextBox3.Text);
                int idJenisPengunjung;

                if (radioButton3.Checked)
                {
                    idJenisPengunjung = 1; // Nilai untuk jenis pengunjung anak-anak
                }
                else if (radioButton4.Checked)
                {
                    idJenisPengunjung = 2; // Nilai untuk jenis pengunjung dewasa
                }
                else
                {
                    MessageBox.Show("Silakan pilih jenis pengunjung (Anak-anak atau Dewasa).");
                    return;
                }



                bool result = dataContext.UpdateDataPengunjung(idDataPengunjung, namaPengunjung, alamatPengunjung, jumlahPengunjung, idJenisPengunjung);

                if (result)
                {
                    MessageBox.Show("Data pengunjung berhasil diperbarui.");
                    ClearTextBoxes();
                    ClearRadioButtons();
                }
                else
                {
                    MessageBox.Show("Data pengunjung dengan ID tersebut tidak ditemukan.");
                }
            }
            else
            {
                MessageBox.Show("Silakan masukkan ID data pengunjung.");
            }
        }
        private void ClearTextBoxes()
        {
            kryptonTextBox5.Text = "";
            kryptonTextBox1.Text = "";
            kryptonTextBox2.Text = "";
            kryptonTextBox3.Text = "";
        }
        private void ClearRadioButtons()
        {
            radioButton4.Checked = false;
            radioButton3.Checked = false;
        }
    }
    
}
