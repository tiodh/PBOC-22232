using J_Explore.Services;
using Npgsql;
using OfficeOpenXml.Packaging.Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace J_Explore
{
    public partial class NewPassword : Form
    {
        private string username;
        public NewPassword(string username)
        {
            InitializeComponent();
            this.username = username.Trim();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {

                if (password.Text == passwordconfirmation.Text)
                {
                    int affectedRows = DbHelper.GetInstance().ExecuteNonQuery($"UPDATE akun_admin SET password = '{passwordconfirmation.Text}' where username = '{username}'");
                    MessageBox.Show("KATA SANDI BERHASIL DI UBAH");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kata Sandi Tidak Sama");
                }
            
        }
    }
}
