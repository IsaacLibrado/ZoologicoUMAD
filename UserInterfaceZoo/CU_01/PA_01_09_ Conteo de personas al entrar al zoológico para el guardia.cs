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


        public PA_01_09__Conteo_de_personas_al_entrar_al_zoológico_para_el_guardia()
        {
            //Agregamos unn valor inicial y que solo puedas poner 5 numeros
            InitializeComponent();
            txtCantPersonas.Text = "0";
            txtCantPersonas.MaxLength = 5;
        }
        /// <summary>
        /// Metodo para validar el boton para validar el boton de ingresar datos
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        public void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCantPersonas.Text == "")
            {
                MenuPrincipal.MostrarMensaje("Debes de ingresar algun valor");
            }
            else
            {
                //Validamos si el conteo es mayor o igual a 9000
                if (conteo >= 9000)
                {
                    //Si no mandamos un mensaje
                    MenuPrincipal.MostrarMensaje("El zoológico llego a su capacidad máxima no se pueden agregar a más de 9000 personas, tiempo estimado 30min");
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
                        MenuPrincipal.MostrarMensaje("No se pueden agregar a más de 9000 personas");
                    }
                    else
                    {
                        // Si no es mayor lo asignamos el valor al label
                        lblTotal.Text = conteo.ToString();
                        //Si no mandamos un mensaje
                        MenuPrincipal.MostrarMensaje("Se han ingresado las personas al sistema, pueden pasar al zoológico");
                        //Limpiamos el text box
                        txtCantPersonas.Clear();
                    }
                }
            }
        }

        /// <summary>
        /// Metodo del boton para salir de la pantalla
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29/04/21
        /// Creador Manuel Rangel
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerramos la pantalla y la cambiamos
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_06_Pantalla_sin_avisos());
        }
        /// <summary>
        /// Asignamos el evento KeyPress
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void txtCantPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Hacemos la validacion para que no acepte letras ni caracteres
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                MenuPrincipal.MostrarMensaje("Solo se aceptan numeros");
                e.Handled = true;
                return;
            }
        }
    }
}
