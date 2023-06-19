using J_Explore.Services;
using Npgsql;
using System.Data;

namespace J_Explore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new Dashboard_Admin());
=======
            Application.Run(new Form1());
<<<<<<< HEAD
            //PrintHelper.Print(new PrintingArgumentsTransaction(), new PrintPreviewDialog());
=======
>>>>>>> 7afa700906c2220d5776cfe9f3ec549165016290
>>>>>>> 65da20319d2e183b88c39b086bc238332fe12ef3
        }
    }
}