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
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;
using UserInterfaceZoo.CU_SinDefinir;

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
        //La pantalla que se muestra en el contenedor central
        private Form pantallaActiva = null;

        //Archivo xml que funge como bitacora
        private XElement bitacora;

        public MenuPrincipal()
        {
            //inicializamos lo básico
            InitializeComponent();
            PersonalizarDisenio();

            //Establecemos el ícono del programa
            this.Icon = Properties.Resources.ZootopiaIcon;
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
            panelComprasSubMenu.Visible = false;
            panelVentasSubMenu.Visible = false;
            panelGestionSubMenu.Visible = false;
            panelInteractivoSubMenu.Visible = false;

            //Inicializamos textos
            lblMensajes.Text = " ";
            lblTitulo.Text = "Presiona el icono para iniciar sesión";

            //Ocultamos los botones
            panelSideMenu.Visible = false;

            //evitamos que se pueda cambiar el tamaño
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;

            CrearBitacora();
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
        /// Evento que se realizar al presionar el boton compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 07 de Marzo 2021
        /// Creador Isaac Librado
        private void btnCompras_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelComprasSubMenu);
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton gestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        private void btnGestion_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelGestionSubMenu);
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton interactivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        private void btnInteractivo_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelInteractivoSubMenu);
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton orden de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 07 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMOrdenCompra_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            AsignarTitulo("Orden de Compra");
            RegistroBitacora("Generada orden de compra");
            MenuPrincipal.abrirPantallas(new PA_06_01_Orden_de_compra_informacion());
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
            AsignarTitulo("Abrir Caja");
            RegistroBitacora("Realizada la apertura de la caja");
            MenuPrincipal.abrirPantallas(new PA_02_03_Apertura_Caja());
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
            AsignarTitulo("Cerrar Caja");
            RegistroBitacora("Realizado el cierre de caja");
            MenuPrincipal.abrirPantallas(new PA_02_04_Cerrar_Caja());
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
            AsignarTitulo("Vender");
            RegistroBitacora("Realizada venta");
            MenuPrincipal.abrirPantallas(new PA_01_02_Menu_Cajero()); 
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
            AsignarTitulo("Apartar Boletos");
            RegistroBitacora("Realizado el apartado de boleto");
            abrirPantallas(new CU_03_ApartadoBoletos());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton mostrar inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMInventario_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            AsignarTitulo("Inventario");
            RegistroBitacora("Mostrado el inventario en pantalla");
            abrirPantallas(new CU_04_ComprarComida());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton comprar alimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMAlimento_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            AsignarTitulo("Compra de alimento");
            RegistroBitacora("Comprado alimento para animales");
            abrirPantallas(new CU_04_ComprarComida());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton gestion maquina expendedora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMMaquinaExp_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            AsignarTitulo("Maquina expendedora");
            RegistroBitacora("Realizada la gestion a la maquina expendedora");
            abrirPantallas(new CU_07_GestionarMaquina());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton gestion de reciclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMReciclado_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            AsignarTitulo("Reciclado");
            RegistroBitacora("Realizada la gestion del reciclado");
            MenuPrincipal.abrirPantallas(new CU_08.PA_08_01_MAPA_RECICLAJE());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton gestion de sanitizacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMSanitizar_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            AsignarTitulo("Sanitizacion");
            RegistroBitacora("Realizado el control de sanitizacion");
            MenuPrincipal.abrirPantallas(new CU_01.PA_01_06_Pantalla_sin_avisos());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton mostrar informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        private void btnSMInformacion_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            AsignarTitulo("Información interactiva");
            RegistroBitacora("Mostrada la infomacion interactiva del zoologico");
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_01_Ubicación());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton videojuego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 2.0
        /// Fecha de creacion 23 de Marzo 2021
        /// Creador Isaac Librado
        /// Fecha de modificacion 16/04/21
        /// Creador Isaac Librado
        private void btnSMVideojuego_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            AsignarTitulo("Videojuego");
            RegistroBitacora("Abierto el videojuego");

            //iniciamos el proceso
            Process programa = Process.Start(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\UserInterfaceZoo\CU_09\VideojuegoZoo.exe");

            //Usado para el ejecutable:
            //programa = Process.Start(Directory.GetCurrentDirectory() + @"\Videojuego\VideojuegoZoo.exe");
        }

        #endregion

        #region funcionalidades

        /// <summary>
        /// Metodo para crear la bitacora del sistema
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 21/03/2021
        /// Creador Isaac librado
        private void CrearBitacora()
        {
            // Creamos la estructura del archivo
            bitacora= new XElement("Bitacora",
                                    new XElement("FechaHoraInicio"),
                                    new XElement("FechaHoraFin"),
                                    new XElement("IP"),
                                    new XElement("Username"),
                                    new XElement("Bitacora")
                                    );
        }

        /// <summary>
        /// Metodo para guardar la bitacora al cerrar el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString()
                + "_" + DateTime.Now.Minute.ToString()+"_"+DateTime.Now.Second.ToString();

            //guardamos la hora actual y guardamos el archivo
            ((XElement)bitacora.FirstNode.NextNode).Add(DateTime.Now);
            bitacora.Save(string.Format("bitacora{0}.xml", nombrearch));
        }

        /// <summary>
        /// Metodo para guardar en la bitacora los registros
        /// </summary>
        /// <param name="pRegistro">El registro a guardar en la bitacora</param>
        /// Version 1.0
        /// Fecha de creacion 21/03/21
        /// Creador Isaac Librado
        public static void RegistroBitacora(string pRegistro)
        {
            //obenemos el form actual, su bitacora y su nodo de registro,
            //añadimos el registro
            MenuPrincipal formActual = (MenuPrincipal)ActiveForm;

            ((XElement)formActual.bitacora.LastNode).Add(string.Format("{1} : {0}\n",pRegistro,DateTime.Now));
        }

        /// <summary>
        /// Obtiene los datos del user que ha iniciado sesión
        /// </summary>
        /// <param name="pUserName">el username del usuario</param>
        /// Version 1.0
        /// Fecha de creacion 13/03/21
        /// Creador Isaac Librado
        public static void ValidarLogIn(bool pValidado, string pUserName)
        {
            //DOcumento XML con los datos del user
            XElement usuarios = LogIn.ObtenerDocumentoXML();
            MenuPrincipal formActual = (MenuPrincipal)ActiveForm;

            if (pValidado)
            {
                string userValidar;

                //obtenemos todos los elementos user
                IEnumerable<XElement> usuariosTag = usuarios.Elements("User");

                //por cada user obtenemos sus datos
                foreach (XElement usuario in usuariosTag)
                {
                    IEnumerable<string> datosUser = from datos in usuario.Elements()
                                                    select datos.Value;

                    //guardamos el username del usuario
                    userValidar = datosUser.ElementAt(0);

                    //si es el mismo se obtienen sus datos
                    if (userValidar == pUserName)
                    {
                        //colocamos los datos del usuario
                        formActual.lblUserName.Text = userValidar;
                        formActual.lblCargo.Text = datosUser.ElementAt(2);
                        formActual.pbPerfil.Image = Properties.Resources.LogoPNGAscendantProyects;

                        //mostramos datos en el menú
                        formActual.panelSideMenu.Visible = true;
                        formActual.ObtenerDireccionIp();

                        //Agregamos datos a la bitacora
                        ((XElement)formActual.bitacora.FirstNode).Add(DateTime.Now);
                        ((XElement)formActual.bitacora.FirstNode.NextNode.NextNode).Add(formActual.lblIp.Text);
                        ((XElement)formActual.bitacora.LastNode.PreviousNode).Add(pUserName);

                        formActual.pbLogoTemp.Visible = false;

                        //validamos el tipo de usuario para saber qué mostrar
                        if(datosUser.ElementAt(2)=="Administrador" || datosUser.ElementAt(2) == "Cajero")
                        {
                            formActual.btnCompras.Visible = false;
                            formActual.btnGestion.Visible = false;
                            formActual.panelVentasSubMenu.Height = 80;

                            if (datosUser.ElementAt(2) == "Administrador")
                            {
                                formActual.btnSMApartarBoletos.Visible = false;
                                formActual.btnSMVender.Visible = false;
                            }
                            else
                            {
                                formActual.btnSMCerrarCaja.Visible = false;
                                formActual.btnSMAbrirCaja.Visible = false;
                            }
                        }
                        else if(datosUser.ElementAt(2) == "GerenteCompras" || datosUser.ElementAt(2) == "Mantenimiento")
                        {
                            formActual.btnGestion.Visible = false;
                            formActual.btnVentas.Visible = false;

                            if (datosUser.ElementAt(2) == "Mantenimiento")
                            {
                                formActual.panelComprasSubMenu.Height = 40;
                                formActual.btnSMOrdenCompra.Visible = false;
                                formActual.btnSMAlimento.Visible = false;
                            }
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Metodo para pasar a la pantalla de inicio de sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 20/03/21
        /// Creador Isaac Librado
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirPantallas(new LogIn());
            AsignarTitulo("Inicio de Sesión");
        }

        

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
            if (panelComprasSubMenu.Visible == true)
                panelComprasSubMenu.Visible = false;
            if (panelGestionSubMenu.Visible == true)
                panelGestionSubMenu.Visible = false;
            if (panelInteractivoSubMenu.Visible == true)
                panelInteractivoSubMenu.Visible = false;
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

            panelContenedor.Controls.Clear();

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

            MostrarMensaje(string.Empty);
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

            //para que sea más demostrativo
            if (formActual.lblMensajes.Text == pMensaje && formActual.lblMensajes.Text != string.Empty)
            {
                pMensaje = "NUEVO MENSAJE: " + pMensaje;
            }
            formActual.lblMensajes.Text = pMensaje;
        }

        /// <summary>
        /// Metodo para mostrar al cargar el cu_05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23/03/21
        /// Creador Isaac Librado
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //Aqui agregamos el CU_05
        }

        /// <summary>
        /// Metodo para el boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23/03/21
        /// Creador Isaac Librado
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
