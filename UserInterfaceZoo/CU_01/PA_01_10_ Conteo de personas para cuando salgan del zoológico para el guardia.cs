﻿using System;
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
            //Agregamos unn valor inicial y que solo puedas poner 5 numeros
            txtCantidad.Text = "0";
            txtCantidad.MaxLength = 5;
        }
        /// <summary>
        /// Metodo para validar el boton para cuando salgan las personas
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_06_Pantalla_sin_avisos());
        }
        /// <summary>
        /// Metodo para validar el boton para cuando ingresen las personas
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07/04/21
        /// Creador Manuel Rangel
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            //Agregamos la validacion para el textbox vacio
            if (txtCantidad.Text == "")
            {
                MenuPrincipal.MostrarMensaje("Debes de ingresar algun valor");
            }
            else
            {
                conteo = conteo + Convert.ToInt32(txtCantidad.Text);
                //Le damos valor al label
                lblTotal.Text = conteo.ToString();
                //Mandamos un mensaje
                MenuPrincipal.MostrarMensaje("Se a retirado cliente del zoológico pueden acceder " + txtCantidad.Text + " personas de la entrada");
                //Limpiamos el textbox
                txtCantidad.Clear();
            }
        }
        /// <summary>
        /// Hacemos la creacion del evento KeyPress
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29/04/21
        /// Creador Manuel Rangel
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Hacemos una validacion para que acepte solo numeros y no letras ni caracteres
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                MenuPrincipal.MostrarMensaje("Solo se aceptan numeros");
                e.Handled = true;
                return;
            }
        }
    }
}
