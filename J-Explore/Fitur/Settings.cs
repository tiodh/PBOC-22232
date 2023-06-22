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
        private DataBase dataBase;
        public Settings()
        {
            InitializeComponent();
            hostName.Text = "localhost";
            username.Text = "postgres";
            password.Text = "Rizal020304";
            port.Text = "5432";
            nameDatabase.Text = "pbo";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveDatabase_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(hostName.Text) && !string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(port.Text) && !string.IsNullOrEmpty(nameDatabase.Text) ){
                dataBase.DbHost = hostName.Text;
                dataBase.DbUsername= username.Text;
                dataBase.DbPassword= password.Text;
                dataBase.DbName = nameDatabase.Text;
                dataBase.DbPort = port.Text;          
            }
            else {
                dataBase.DbHost = "localhost";
                dataBase.DbUsername = "postgres";
                dataBase.DbPassword = "Rizal020304";
                dataBase.DbName = "5432";
                dataBase.DbPort = "pbo";

            }

        }
    }
}
