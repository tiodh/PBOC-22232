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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            DataTable dt = DbHelper.GetInstance().ExecuteQuery("select * from akun_admin");
            List<dynamic> list = Global.GetColumnData(dt, 0);

            if (list.Contains(usernameVerification.Text))
            {
                NewPassword newPassword1 = new NewPassword(usernameVerification.Text);
                newPassword1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username Tidak Di Temukan");
            }
        }

        
    }
}
