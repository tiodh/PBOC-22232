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
    public partial class Data_Harga : UserControl
    {
        public Data_Harga()
        {
            InitializeComponent();
            ShowDataHargaWisata();
        }
        private void ShowDataHargaWisata()
        {
            var db = new DatabaseHelper();
            var reader = db.Select("SELECT id_harga_tiket, harga_tiket, FROM public.harga_tiket;");
            DGV_Data_Harga.Rows.Clear();


            while (reader.Read())
            {
                DGV_Data_Harga.Rows.Add((int)reader["id_harga_tiket"], (int)reader["harga_tiket"]);
            }

            reader.Close();

        }
    }
}
