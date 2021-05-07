using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceZoo.CU_05
{
    public partial class PA_05_26_Salir : Form
    {
        public PA_05_26_Salir()
        {
            InitializeComponent();

            //indicamos el diseño inicial
            DisenioInicial();
        }

        private void DisenioInicial()
        {
            if (MenuPrincipal.iniciado)
            {
                BtnSalir.Enabled = false;
            }

            TxtContra.PasswordChar = '*';
            TxtContra.MaxLength = 12;
            TxtUsuario.MaxLength = 10;
        }

        //Se realiza una comprobación de usuario y contraseña por si otra persona que
        //no sea la persona anfitriona quiera salir
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        //Regresa a pantalla principal 
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_03_Menú_Mapa_Interactivo());
        }

        private void TxtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salir();
            }
        }

        private void Salir()
        {
            if ((TxtUsuario.Text == "system") && (TxtContra.Text == "admin123"))
            {
                if (MenuPrincipal.iniciado)
                {
                    this.Close();
                }
                else
                {
                    MenuPrincipal.abrirPantallas(new LogIn());
                }
            }
            else if ((TxtUsuario.Text != "system") && (TxtContra.Text != "admin123"))
            {
                MenuPrincipal.MostrarMensaje("DATOS INCORRECTOS INTENTE OTRA VEZ");
                TxtContra.Clear();
                TxtContra.Clear();
                TxtUsuario.Focus();
            }
        }
    }
}
