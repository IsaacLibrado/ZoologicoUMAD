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
    public partial class PA_05_05_Animales : Form
    {
        public PA_05_05_Animales()
        {
            InitializeComponent();
        }

        //Regresa a la Pantalla anterior 
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_03_Menú_Mapa_Interactivo());
        }

        
    }
}
