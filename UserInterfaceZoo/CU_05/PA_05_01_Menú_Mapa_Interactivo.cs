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
    public partial class PA_05_01_Menú_Mapa_Interactivo : Form
    {

        public PA_05_01_Menú_Mapa_Interactivo()
        {
            InitializeComponent();
        }

        private void btnGuacamaya_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_02_Animales());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new Inicio());
        }

        private void BtnJirafa_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_06_Animales());
        }

        private void BtnElefante_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_07_Animales());
        }

        private void BtnCebra_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_08_Animales());
        }

        private void BtnTigre_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_09_Animales());
        }

        private void BtnPinguino_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_10_Animales());
        }

        private void BtnFlamenco_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_11_Animales());
        }

        private void BtnOso_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_12_Animales());
        }

        private void BtnPuma_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_13_Animales());
        }

        private void BtnJaguar_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_14_Animales());
        }

        private void BtnLeon_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_15_Animales());
        }

        private void BtnAguia_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_03_Animales());
        }
    }
}
