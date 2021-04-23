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
    public partial class PA_01_07_Aviso_para_mantener_sana_distancia_en_filas : Form
    {
        public PA_01_07_Aviso_para_mantener_sana_distancia_en_filas()
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
            this.Close();
            MessageBox.Show("Las autoridades del zoológico se acercan a la zona");
            MenuPrincipal.abrirPantallas(new PA_01_06_Pantalla_sin_avisos());
        }
        /// <summary>
        /// Metodo para validar el boton para cancelar la instrucción
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Se cancelo la instrucción");
            MenuPrincipal.abrirPantallas(new PA_01_06_Pantalla_sin_avisos());
        }
    }
}
