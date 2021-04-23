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
    public partial class PA_01_06_Pantalla_sin_avisos : Form
    {
        public PA_01_06_Pantalla_sin_avisos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo para validar los avisos en filas
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void btnAvisoFilas_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_07_Aviso_para_mantener_sana_distancia_en_filas());
            MenuPrincipal.AsignarTitulo("Aviso para mantener sana distancia en filas");
        }
        /// <summary>
        /// Metodo para validar la temperatura excedida
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void btnTemExcedida_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_08__Aviso_de_cuando_la_temperatura_es_mayor_a_la_permitida_para_el_guardia());
            MenuPrincipal.AsignarTitulo("Aviso de temperatura excedida");
        }
        /// <summary>
        /// Metodo para validar el boton para cuando entren las personas
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void btnPersonasEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_09__Conteo_de_personas_al_entrar_al_zoológico_para_el_guardia());
            MenuPrincipal.AsignarTitulo("Conteo de personas para la entrada");
        }
        /// <summary>
        /// Metodo para validar cuando las personas vayan saliendo del zoológico
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void btnPersonasSalida_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_10__Conteo_de_personas_para_cuando_salgan_del_zoológico_para_el_guardia());
            MenuPrincipal.AsignarTitulo("Conteo de salida de personas");
        }
    }
}
