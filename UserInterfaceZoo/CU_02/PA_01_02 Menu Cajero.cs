using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UserInterfaceZoo.CU_SinDefinir;

namespace UserInterfaceZoo
{
    public partial class PA_01_02_Menu_Cajero : Form
    {
        /// <summary>
        /// Esta clase permite acceder a las funciones de venta de boleto o souvenir
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public PA_01_02_Menu_Cajero()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que permite cerrar este form
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo que da acceso a la venta de boleto de entrada
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            //Permite saber si las cajas estan abiertas, en caso negativo no permite su acceso
            if(VerificacionCajas() == true)
            {
                this.Close();
                MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
                MenuPrincipal.AsignarTitulo("Vender boletos de entrada");
            }
        }

        /// <summary>
        /// Esta metodo no hace nada debido a que no es un caso de uso programado por el momento
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnEspectaculo_Click(object sender, EventArgs e)
        {
            MenuPrincipal.AsignarTitulo("Vender Boletos de Espectaculo");
            MenuPrincipal.abrirPantallas(new CU_03_ApartadoBoletos());
        }

        /// <summary>
        /// Metodo que da acceso a la venta de souvenirs
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnSouvenirs_Click(object sender, EventArgs e)
        {
            //Permite saber si las cajas estan abiertas, en caso negativo no permite el acceso
            if (VerificacionCajas() == true)
            {
                this.Close();
                MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
                MenuPrincipal.AsignarTitulo("Souvenirs");
            }
        }

        /// <summary>
        /// Este metodo permite saber si la caja esta abierta
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private bool VerificacionCajas()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            //si el archivo que buscamos de la caja aperturada permitimos saber que la caja está abierta
            if (File.Exists("InfoCajas" + nombrearch + ".xml"))
            {
                return true;
            }
            //si el archivo no fue encontrado la caja esta cerrada
            else
            {
                MenuPrincipal.MostrarMensaje("NO SE HA APERTURADO LAS CAJAS");
                return false;
            }
        }
    }
}
