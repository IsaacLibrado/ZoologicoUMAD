using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceZoo.CU_05
{
    public partial class PA_05_27_Emergencias : Form
    {
        public PA_05_27_Emergencias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_03_Menú_Mapa_Interactivo());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_03_Menú_Mapa_Interactivo());
        }
        private void label3_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_28_Evacacion());
        }

        private void BtnEvacuacion_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_28_Evacacion());
        }

        private void BtnAccidente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se contactaron con las autoridades pertinentes. \nLa ayuda está en camino");

            label2.Text = "¿Es de alto riego?";
            label3.Text = "Si";
            label4.Text = "No";
        }

        private void BtnHerido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se contactaron con las autoridades pertinentes. \nLa ayuda está en camino");
        }
    }
}
