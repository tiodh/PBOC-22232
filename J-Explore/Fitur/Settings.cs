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

namespace J_Explore.Fitur
{
    public partial class Settings : Form
    {
        private bool isDialog;

        public Settings(bool isDialog = false)
        {
            InitializeComponent();

            hostName.Text = Global.DbHost;
            username.Text = Global.DbUsername;
            password.Text = Global.DbPassword;
            port.Text = Global.DbPort.ToString();
            nameDatabase.Text = Global.DbName;

            comboBoxPrinter.Items.Clear();
            foreach (string printer in PrintHelper.GetAvailablePrinters())
            {
                comboBoxPrinter.Items.Add(printer);
            }
            comboBoxPrinter.Text = PrintHelper.GetCurrentPrinter();

            comboBoxPaperSize.Items.Clear();
            foreach (string paperSize in PrintHelper.GetAvailablePaperSizes())
            {
                comboBoxPaperSize.Items.Add(paperSize);
            }
            comboBoxPaperSize.Text = PrintHelper.GetCurrentPaperSize();

            this.isDialog = isDialog;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveDatabase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hostName.Text.Trim()))
            {
                MessageBox.Show("Host masih kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(username.Text.Trim()))
            {
                MessageBox.Show("Username masih kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Password masih kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(port.Text.Trim()))
            {
                MessageBox.Show("Port masih kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(nameDatabase.Text.Trim()))
            {
                MessageBox.Show("Nama Database masih kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Global.DbHost = hostName.Text;
            Global.DbUsername = username.Text;
            Global.DbPassword = password.Text;
            Global.DbPort = int.Parse(port.Text);
            Global.DbName = nameDatabase.Text;

            Properties.Settings.Default.DbHost = Global.DbHost;
            Properties.Settings.Default.DbUsername = Global.DbUsername;
            Properties.Settings.Default.DbPassword = Global.DbPassword;
            Properties.Settings.Default.DbPort = Global.DbPort;
            Properties.Settings.Default.DbName = Global.DbName;

            Properties.Settings.Default.Save();

            if (isDialog)
            {
                Close();
            }
        }

        private void OnTextBoxPortKeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnComboboxPrinterSelectedIndexChanged(object sender, EventArgs e) => PrintHelper.SetCurrentPrinter(comboBoxPrinter.Text);

        private void OnComboboxPaperSizeSelectedIndexChanged(object sender, EventArgs e) => PrintHelper.SetCurrentPaperSize(comboBoxPaperSize.Text);
    }
}
