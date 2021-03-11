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
    public partial class Prueba2 : Form
    {
        public Prueba2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.AsignarTitulo("Compra venta de zapatos industriales");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal.MostrarMensaje("SU ARTICULO HA SIDO AÑADIDIO, EXITOSAMENTE, INGRESE NUEVO ARTICULO O SIGA CON SU ORDEN");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new Prueba1());
            MenuPrincipal.AsignarTitulo("Abrir Caja desde cerrar");
        }
    }
}
