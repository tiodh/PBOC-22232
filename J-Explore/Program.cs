using J_Explore.Fitur;
using J_Explore.Services;
using J_Explore.Utils;
using Npgsql;
using OfficeOpenXml;
using System.Data;

namespace J_Explore
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Initialize settings by default
            Global.DbHost = Properties.Settings.Default.DbHost;
            Global.DbUsername = Properties.Settings.Default.DbUsername;
            Global.DbPassword = Properties.Settings.Default.DbPassword;
            Global.DbPort = Properties.Settings.Default.DbPort;
            Global.DbName = Properties.Settings.Default.DbName;

            try
            {
                DbHelper.Initialize(Global.DbHost, Global.DbPort, Global.DbUsername, Global.DbPassword, Global.DbName);
                DbHelper.GetInstance().ExecuteQuery("SELECT * FROM akun_admin");

                // If no exception occurs, show the Dashboard_User form
                Application.Run(new Dashboard_User());
            }
            catch (ArgumentException)
            {
                // Show the Settings form if an ArgumentException occurs
                var settingsForm = new Settings(true);
                settingsForm.ShowDialog();

                Application.Run(new Dashboard_User());

            }
        }
    }

}