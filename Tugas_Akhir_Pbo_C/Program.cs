using Logitop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_Pbo_C
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbHelper.Initialize("localhost", 5432, "postgres", "Rizal020304", "pbo", "public");
            Application.Run(new Form1());
        }
    }
}
