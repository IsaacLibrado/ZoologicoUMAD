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
    public partial class PA_02_06_Membresia : Form
    {
        public PA_02_06_Membresia()
        {
            InitializeComponent();
        }

        //int codigoProducto;

        /// <summary>
        /// Evento que se realizar al presionar el boton Regresar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Karla Garcia
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_02_Menu_Cajero());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton Mostrar Carrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Karla Garcia
        private void btnCarrito_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_07_Carrito_Souvenirs());
            MenuPrincipal.AsignarTitulo("Carrito de souvenirs");
        }

        private void btnAnimFelpa_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
        }

        private void btnGorras_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
        }

        private void btnCubrebocas_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
        }

        private void btnLlaveros_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
        }

        private void btnTazas_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
        }

        private void btnPlayeras_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
        }
    }
}
