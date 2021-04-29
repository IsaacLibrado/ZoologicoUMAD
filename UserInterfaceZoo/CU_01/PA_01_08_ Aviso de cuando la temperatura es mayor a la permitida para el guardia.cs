using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceZoo.CU_01
{
    public partial class PA_01_08__Aviso_de_cuando_la_temperatura_es_mayor_a_la_permitida_para_el_guardia : Form
    {
        public PA_01_08__Aviso_de_cuando_la_temperatura_es_mayor_a_la_permitida_para_el_guardia()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para validar el boton para aceptar la instrucción
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MenuPrincipal.MostrarMensaje("Las autoridades y paramedicos del zoológico se acercan a la zona");
        }
        /// <summary>
        /// Metodo para validar el boton para cancelar la instrucción
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal.MostrarMensaje("Instrucción cancelada");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_06_Pantalla_sin_avisos());
        }
    }
}
