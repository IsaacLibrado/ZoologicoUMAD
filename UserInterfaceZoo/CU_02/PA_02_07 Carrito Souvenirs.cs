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
    public partial class PA_02_07_Carrito_Souvenirs : Form
    {
        public PA_02_07_Carrito_Souvenirs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Karla Garcia
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_06_Membresia());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton Pagar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Karla Garcia
        private void btnPagar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_08_Pago_Souvenirs());
        }
    }
}
