using J_Explore.Services;
using Npgsql;
using OfficeOpenXml;
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
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Application.Run(new Dashboard_Admin());
        }
    }
}