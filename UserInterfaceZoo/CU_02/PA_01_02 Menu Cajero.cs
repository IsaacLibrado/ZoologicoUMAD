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

namespace UserInterfaceZoo
{
    public partial class PA_01_02_Menu_Cajero : Form
    {
        public PA_01_02_Menu_Cajero()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if(VerificacionCajas() == true)
            {
                this.Close();
                MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
                MenuPrincipal.AsignarTitulo("Vender boletos de entrada");
            }
        }

        private void btnEspectaculo_Click(object sender, EventArgs e)
        {

        }

        private void btnSouvenirs_Click(object sender, EventArgs e)
        {
            if (VerificacionCajas() == true)
            {
                this.Close();
                MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
                MenuPrincipal.AsignarTitulo("Souvenirs");
            }
        }
        private bool VerificacionCajas()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            if (File.Exists("InfoCajas" + nombrearch + ".xml"))
            {
                return true;
            }
            else
            {
                MenuPrincipal.MostrarMensaje("NO SE HA APERTURADO LAS CAJAS");
                return false;
            }

        }
    }
}
