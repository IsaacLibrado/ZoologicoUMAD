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
    public partial class PA_05_07_Animales : Form
    {
        public PA_05_07_Animales()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_01_Menú_Mapa_Interactivo());
        }
    }
}
