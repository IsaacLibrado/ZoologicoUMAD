using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceZoo
{
    public partial class PA_06_02_Orden_de_compra_registro_articulos : Form
    {
        public PA_06_02_Orden_de_compra_registro_articulos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_06_01_Orden_de_compra_informacion());
            MenuPrincipal.AsignarTitulo("Orden de Compra");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_06_03_Orden_de_compra_totales());
            MenuPrincipal.AsignarTitulo("Orden de compra Totales");
        }
    }
}
