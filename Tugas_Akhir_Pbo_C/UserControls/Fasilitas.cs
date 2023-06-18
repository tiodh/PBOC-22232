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
    public partial class Fasilitas : UserControl
    {
        public Fasilitas()
        {
            InitializeComponent();
        }

        private void Fasilitas_Load(object sender, EventArgs e)
        {

        }

        private void kbtnSearch_Click(object sender, EventArgs e)
        {
            string panelName = panelCari.Text; // Ambil teks dari TextBox sebagai nama panel yang ingin dicari

            Panel panelToShow = null;
            Panel[] panelsToHide = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10};

            // Cek nama panel dan tentukan panel mana yang akan ditampilkan dan yang akan disembunyikan
            if (panelName == "panel1")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel1;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }
            
            else if (panelName == "panel2")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel2;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }

            else if (panelName == "panel3")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel3;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }

            else if (panelName == "panel4")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel4;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }

            else if (panelName == "panel5")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel5;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }

            else if (panelName == "panel6")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel6;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }

            else if (panelName == "panel7")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel7;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }

            else if (panelName == "panel8")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel8;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }

            else if (panelName == "panel9")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel9;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }

            else if (panelName == "panel10")
            {
                foreach (Panel panel in panelsToHide)
                {
                    if (panel.Name == panelName)
                    {
                        panelToShow = panel10;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }
            // Ubah visibilitas panel sesuai dengan keputusan di atas
            if (panelToShow != null)
            {
                panelToShow.Visible = true;

            }
            else
            {
                // Tampilkan pesan jika panel tidak ditemukan
                MessageBox.Show("Panel tidak ditemukan.");
            }
        }
    }
}
