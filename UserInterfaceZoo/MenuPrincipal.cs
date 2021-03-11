using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace UserInterfaceZoo
{
    /// <summary>
    /// Esta clase define las funcionalidades del menu principal
    /// </summary>
    /// Version 1.0
    /// Fecha de creacion 07 de Marzo 2021
    /// Creador Isaac Librado
    public partial class MenuPrincipal : Form
    {
        private Form pantallaActiva = null;

        public MenuPrincipal()
        {
            //inicializamos lo básico
            InitializeComponent();
            PersonalizarDisenio();
            
        }

        #region disenio

        /// <summary>
        /// Metodo para darle un diseño inicial al menu
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 7 de Marzo del 2021
        /// Creador Isaac Librado
        private void PersonalizarDisenio()
        {
            //hacemos invisibles a los sub menus
            panelVentasSubMenu.Visible = false;

            //Obtenemos la direccion IP actual del dispositivo
            ObtenerDireccionIp();

            //Inicializamos textos
            lblMensajes.Text = " ";
            lblTitulo.Text = "Menu Principal";
            //.....
        }

        /// <summary>
        /// Obtiene la direccion ip del dispositivo actual
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 07 de Marzo del 2021
        /// Creador Isaac Librado
        private void ObtenerDireccionIp()
        {
            //lo marca como obsoleto porque utiliza ipv4
            var ip = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];

            ////version ipv6
            //var ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];

            lblIp.Text = ip.ToString();
        }

        /// <summary>
        /// Obtiene la hora actual cada tick del timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 7 de Marzo de 2021
        /// Creador Isaac Librado
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            //asigna las fechas y horas a sus respectivos labels
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        #endregion

        #region subMenuVentas

        /// <summary>
        /// Evento que se realizar al presionar el boton ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 07 de Marzo 2021
        /// Creador Isaac Librado
        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelVentasSubMenu);
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton abrir cajas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 07 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMAbrirCaja_Click(object sender, EventArgs e)
        {
            //Ocultamos el submenu y mostramos la pantalla con su respectivo titulo
            ocultarSubMenu();
            abrirPantallas(new Prueba1());
            AsignarTitulo("Abrir Caja");
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton cerrar cajas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 07 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMCerrarCaja_Click(object sender, EventArgs e)
        {
            //Ocultamos el submenu y mostramos la pantalla con su respectivo titulo
            ocultarSubMenu();
            abrirPantallas(new Prueba2());
            AsignarTitulo("Cerrar Caja");
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton vender 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 07 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMVender_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }


        /// <summary>
        /// Evento que se realizar al presionar el boton apartar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 07 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMApartarBoletos_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }
        #endregion

        #region funcionalidades

        /// <summary>
        /// Metodo para ocultar los submenus
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 7 de Marzo del 2021
        /// Creador Isaac Librado
        private void ocultarSubMenu()
        {
            if (panelVentasSubMenu.Visible == true)
                panelVentasSubMenu.Visible = false;
        }

        /// <summary>
        /// Metodo para mostrar los submenus dependiendo el panel
        /// </summary>
        /// <param name="subMenu">El panel a mostrar con los botones del sub menu</param>
        /// Version 1.0
        /// Fecha de creacion 7 de Marzo del 2021
        /// Creador Isaac Librado
        private void mostrarSubMenu(Panel subMenu)
        {
            //alterna entre visible y no visible dependiendo el estado actual del submenu
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        /// <summary>
        /// Metodo para mostrar las pantallas en el panel contenedor
        /// </summary>
        /// <param name="pPantalla">Es la pantalla a mostrar</param>
        /// Version 1.0
        /// Fecha de creacion 7 de Marzo del 2021
        /// Creador Isaac Librado

        public static void abrirPantallas(Form pPantalla)
        {
            //obtenemos la pantalla del menu principal
            MenuPrincipal formActual = (MenuPrincipal)ActiveForm;

            //obtenemos la pantalla activa en el contenedor
            Form pantallaActiva = formActual.pantallaActiva;

            //obtenemos la instancia del contenedor
            Panel panelContenedor = formActual.panelContenedor;

            //si tenemos una pantalla activa la cerramos
            if (pantallaActiva != null)
                pantallaActiva.Close();

            //asignamos la pantalla activa 
            pantallaActiva = pPantalla;
            //le indicamos que no es la principal
            pantallaActiva.TopLevel = false;
            //le quitamos el borde
            pantallaActiva.FormBorderStyle = FormBorderStyle.None;
            //que cubra todo el contenedor
            pantallaActiva.Dock = DockStyle.Fill;
            //lo añadimos a los controles del contenedor
            panelContenedor.Controls.Add(pantallaActiva);
            //lo asignamos al tag de contenedor
            panelContenedor.Tag = pPantalla;
            //traemos la pantalla activa al frente
            pantallaActiva.BringToFront();

            //mostramos la pantalla activa
            pantallaActiva.Show();
        }

        /// <summary>
        /// Metodo para asignar el titulo de la pantalla actual
        /// </summary>
        /// <param name="pTitulo">Titulo a colocar</param>
        /// Version 1.0
        /// Fecha de creacion 7 de Marzo del 2021
        /// Creador Isaac Librado
        public static void AsignarTitulo(string pTitulo)
        {
            //obtenemos las instancias necesarias del menu y el label del titulo
            MenuPrincipal formActual = (MenuPrincipal)ActiveForm;
            Panel panelTitulo = formActual.panelTitulo;
            Label lblTitulo = formActual.lblTitulo;

            //colocamos el texto
            lblTitulo.Text = pTitulo;

            //obtenemos el centro del panel para colocar en esa posicion al label
            int panelX = (panelTitulo.Size.Width - lblTitulo.Size.Width) / 2;
            lblTitulo.Location = new Point(panelX, lblTitulo.Location.Y);
        }

        /// <summary>
        /// Metodo para mostrar los mensajes en la pantalla
        /// </summary>
        /// <param name="pMensaje">El mensaje a mostrar</param>
        /// Version 1.0
        /// Fecha de creacion 7 de Marzo del 2021
        /// Creador Isaac Librado
        public static void MostrarMensaje(string pMensaje)
        {
            //obtenemos la instancia del menu principal para colocar el texto en su control
            MenuPrincipal formActual = (MenuPrincipal)ActiveForm;
            formActual.lblMensajes.Text = pMensaje;
        }

        #endregion
    }
}
