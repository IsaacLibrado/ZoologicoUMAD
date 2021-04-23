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
    public partial class PA_01_10__Conteo_de_personas_para_cuando_salgan_del_zoológico_para_el_guardia : Form
    {
        //Variables en uso
        int conteo = 0;


        public PA_01_10__Conteo_de_personas_para_cuando_salgan_del_zoológico_para_el_guardia()
        {
            InitializeComponent();
            txtCantidad.Text = "0";
        }
        /// <summary>
        /// Metodo para validar el boton para cuando salgan las personas
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void button1_Click(object sender, EventArgs e)
        {
            conteo = conteo + Convert.ToInt32(txtCantidad.Text);
            //Le damos valor al label
            lblTotal.Text = conteo.ToString();
            //Mandamos un mensaje
            MessageBox.Show("Se a retirado cliente del zoológico pueden acceder " + conteo + " personas de la entrada");
            //Limpiamos el textbox
            txtCantidad.Clear();

        }
    }
}
