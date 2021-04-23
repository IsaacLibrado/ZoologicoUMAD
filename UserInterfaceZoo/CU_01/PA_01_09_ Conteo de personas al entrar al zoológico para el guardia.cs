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
    public partial class PA_01_09__Conteo_de_personas_al_entrar_al_zoológico_para_el_guardia : Form
    {
        //Variable en uso
        int conteo = 0;
        int total = 0;

        public PA_01_09__Conteo_de_personas_al_entrar_al_zoológico_para_el_guardia()
        {
            InitializeComponent();
            txtCantPersonas.Text = "0";
        }
        /// <summary>
        /// Metodo para validar el boton para validar el boton de ingresar datos
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        public void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos si el conteo es mayor o igual a 9000
            if (conteo >= 9000)
            {
                //Si no mandamos un mensaje
                MessageBox.Show("El zoológico llego a su capacidad máxima no se pueden agregar a más de 9000 personas, tiempo estimado 30min");
                txtCantPersonas.Clear();
            }
            else
            {
                //Acomulamos el conteo que el usuario vaya agregando
                conteo = conteo + Convert.ToInt32(txtCantPersonas.Text);
                if (conteo > 9000)
                {
                    //Le quitamos la cantidad erronea
                    conteo = conteo - Convert.ToInt32(txtCantPersonas.Text);
                    //Si no mandamos un mensaje
                    MessageBox.Show("No se pueden agregar a más de 9000 personas");
                }
                else
                {
                    // Si no es mayor lo asignamos el valor al label
                    lblTotal.Text = conteo.ToString();
                    //Si no mandamos un mensaje
                    MessageBox.Show("Se han ingresado las personas al sistema, pueden pasar al zoológico");
                    //Limpiamos el text box
                    txtCantPersonas.Clear();
                }
            }
        }
    }
}
