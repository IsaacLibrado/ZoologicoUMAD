using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UserInterfaceZoo
{
    public partial class LogIn : Form
    {
        //atributos para el inicio de sesión y obtención de datos
        private XElement usuariosx;

        //nombre de usuario que tiene acceso al sistema
        public string usuarioPasar;

        public LogIn()
        {
            InitializeComponent();

            //obtenemos los datos del documento xml donde se almacenan 
            //los datos de los usuarios
            usuariosx = ObtenerDocumentoXML();

            //indicamos el diseño inicial
            DisenioInicial();
        }

        /// <summary>
        /// Metodo para poner el diesño inicial al form
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 20/03/21
        /// Creador Isaac Librado
        private void DisenioInicial()
        {
            txbContra.PasswordChar = '*';
            txbContra.MaxLength = 12;
            txbUsuario.MaxLength = 10;
        }

        /// <summary>
        /// Metodo que se ejecuta cuando se da click en entrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 20/03/21
        /// Creador Isaac Librado
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        /// <summary>
        /// Metodo para validar que los datos ingresados corresponden a un usuario
        /// </summary>
        /// <param name="pUser">Nombre del usuario</param>
        /// <param name="pPassword">Contrasena</param>
        /// <returns>true si los datos se validan como correctos|por default lo regresa como false</returns>
        /// Version 1.1
        /// Fecha de crecion 13/03/21
        /// Creador Isaac Librado
        private bool ValidarLogIn(string pUser, string pPassword)
        {
            string userValidar;
            string passwordValidar;

            //obtenemos todos los elementos user
            IEnumerable<XElement> usuariosTag = usuariosx.Elements("User");

            //por cada user obtenemos sus datos
            foreach (XElement usuario in usuariosTag)
            {
                IEnumerable<string> datosUser = from datos in usuario.Elements()
                                                select datos.Value;

                //guardamos el user y contrasena de ese usuario
                userValidar = datosUser.ElementAt(0);
                passwordValidar = datosUser.ElementAt(1);

                //si son los mismos a los ingresados se valida
                if (userValidar == pUser && passwordValidar == pPassword)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Metodo para obtener el documento xml de los usuarios
        /// </summary>
        /// <returns>El XElement de los usuarios</returns>
        /// Version 1.0
        /// Fecha de creacion 13/03/21
        /// Creador Isaac Librado
        public static XElement ObtenerDocumentoXML()
        {
            XElement usuariosTexto;

            //Valida si existe el archivo de guardado
            if (File.Exists("users.xml"))
            {
                //Obtenemos la info de un archivo de texto
                string usuarios = System.IO.File.ReadAllText("users.xml");

                //Pasamos la cadena por parse
                usuariosTexto = XElement.Parse(usuarios);
            }
            else
            {

                // Si no existe, se crea un archivo con datos default
                usuariosTexto = new XElement("Usuarios",
                                        new XElement("User", new XAttribute("userid", "1"),
                                            new XElement("Username", "system"),
                                            new XElement("Password", "admin123"),
                                            new XElement("Cargo", "Admin")
                                            ),
                                        new XElement("User", new XAttribute("userid", "2"),
                                            new XElement("Username", "20060001"),
                                            new XElement("Password", "admin123"),
                                            new XElement("Cargo", "Administrador")
                                            ),
                                        new XElement("User", new XAttribute("userid", "3"),
                                            new XElement("Username", "20060002"),
                                            new XElement("Password", "admin123"),
                                            new XElement("Cargo", "Cajero")
                                            ),
                                        new XElement("User", new XAttribute("userid", "4"),
                                            new XElement("Username", "20060003"),
                                            new XElement("Password", "admin123"),
                                            new XElement("Cargo", "GerenteCompras")
                                            ),
                                        new XElement("User", new XAttribute("userid", "5"),
                                            new XElement("Username", "20060004"),
                                            new XElement("Password", "admin123"),
                                            new XElement("Cargo", "Mantenimiento")
                                            )
                                        );

                //Guardamos en disco
                usuariosTexto.Save("users.xml");
            }

            return usuariosTexto;
        }


        /// <summary>
        /// Metodo para validar cuando se presione enter en el campo de contrasenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 25/03/21
        /// Creador Isaac Librado
        private void txbContra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Entrar();
            }
        }

        /// <summary>
        /// Metodo para validar la entrada al sistema despues del login
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 25/03/21
        /// Creador Isaac Librado
        private void Entrar()
        {
            //Variables para obtener los datos de login
            string user = txbUsuario.Text;
            string password = txbContra.Text;

            bool validado = ValidarLogIn(user, password);

            //Si la validacion de los datos es correcta se manda a la pantalla principal y si no
            //se indica con un mensaje y se limpian los text box
            if (validado)
            {
                usuarioPasar = user;

                MenuPrincipal.AsignarTitulo("Menú Principal");
                MenuPrincipal.abrirPantallas(new Inicio(user));
            }
            else
            {
                MenuPrincipal.MostrarMensaje("DATOS INCORRECTOS INTENTE OTRA VEZ");
                txbUsuario.Clear();
                txbContra.Clear();
                txbUsuario.Focus();
            }
        }

        /// <summary>
        /// Cambia al passwordbox después de dar enter en el textbox del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 23/04/21
        /// Creador Isaac Librado
        private void txbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbContra.Focus();
            }
        }
    }
}
