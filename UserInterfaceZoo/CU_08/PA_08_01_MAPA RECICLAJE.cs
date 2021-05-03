using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceZoo.CU_08
{
    public partial class PA_08_01_MAPA_RECICLAJE : Form
    {
        public PA_08_01_MAPA_RECICLAJE()
        {
            InitializeComponent();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_08.PA_08_02_INFORMACION());
        }

        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_08.PA_08_03_DESECHOS());
        }

        private void btnBasura_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_08.PA_08_04_SIMBOLOGIA());
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new Inicio());
        }
    }
}
