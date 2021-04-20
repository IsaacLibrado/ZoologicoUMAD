using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace UserInterfaceZoo
{
    public partial class PA_02_05_Souvenirs : Form
    {
        /// <summary>
        /// Esta clase permite la selección de souvenirs para vender
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        
        private XElement souvenirsx;
        List<Carrito> carrito = new List<Carrito>();
        List<Souvenirs> documento = new List<Souvenirs>();
        List<ComprasSouvenirs> confirmacion = new List<ComprasSouvenirs>();

        int folio; 

        public PA_02_05_Souvenirs()
        {
            InitializeComponent();
            souvenirsx = ObtenerDocumentoXML();
        }

        /// <summary>
        /// Este metodo permite la serializacion con la informacion de la venta de los souvenirs
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void Serializar()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();

            XmlSerializer serializarequipo = new XmlSerializer(typeof(List<Carrito>));
            Stream miStreamxml = new FileStream("VentaSouvenirs" + nombrearch + "-folio"+ folio +".xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializarequipo.Serialize(miStreamxml, carrito);

            miStreamxml.Close();
        }

        /// <summary>
        /// Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void Deserializar()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            if (File.Exists("VentaSouvenirs" + nombrearch + "-folio" + folio + ".xml"))
            {
                XmlSerializer deserializarequipo = new XmlSerializer(typeof(List<Carrito>));

                Stream miStream = new FileStream("VentaBoletos" + nombrearch + "-folio" + folio + ".xml", FileMode.Open, FileAccess.Read, FileShare.None);

                carrito = (List<Carrito>)deserializarequipo.Deserialize(miStream);
                miStream.Close();
            }
        }

        /// <summary>
        /// Método para serializar la informacion del souvenir
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void SerializarDocumento()
        {
            XmlSerializer serializarequipo = new XmlSerializer(typeof(List<Souvenirs>));
            Stream miStreamxml = new FileStream("souvenirs.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializarequipo.Serialize(miStreamxml, documento);

            miStreamxml.Close();
        }

        /// <summary>
        /// Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void DeserializarDocumento()
        {
            if (File.Exists("souvenirs.xml"))
            {
                XmlSerializer deserializarequipo = new XmlSerializer(typeof(List<Souvenirs>));

                Stream miStream = new FileStream("souvenirs.xml", FileMode.Open, FileAccess.Read, FileShare.None);

                documento = (List<Souvenirs>)deserializarequipo.Deserialize(miStream);
                miStream.Close();
            }
        }

        /// <summary>
        /// Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void DeserializarConfrimacion()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtFolio.Text + ".xml";
            if (File.Exists("Compra-" + archivo))
            {
                XmlSerializer deserializarequipo = new XmlSerializer(typeof(List<ComprasSouvenirs>));

                Stream miStream = new FileStream("Compra-" + archivo, FileMode.Open, FileAccess.Read, FileShare.None);

                confirmacion = (List<ComprasSouvenirs>)deserializarequipo.Deserialize(miStream);
                miStream.Close();
            }
        }

        /// <summary>
        /// Metodo que permite obtener una caja mediante su id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private Souvenirs GetID(int codigo)
        {
            return documento.Find(x => x.Codigo == codigo);
        }

        /// <summary>
        /// Metodo que permite obtener un carrito con su folio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private Carrito GetFolio(int folio)
        {
            return carrito.Find(x => x.Folio == folio);
        }

        /// <summary>
        /// Metodo que permite obtener una compra con su id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private ComprasSouvenirs GetID(string archivo)
        {
            return confirmacion.Find(x => x.Archivo == archivo);
        }

        /// <summary>
        /// Metodo que permite agregar souvenirs al carrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validacion para campos vacios
            if(txtFolio.Text == "" || txtCodigo.Text == "" || txtCantidad.Text == "")
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            }
            else
            { 
            DeserializarConfrimacion();
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtFolio.Text + ".xml";
            ComprasSouvenirs miConfirmacion = GetID(archivo);

                if (miConfirmacion != null)
                {
                    MenuPrincipal.MostrarMensaje("YA FUE PAGADO EL FOLIO");
                }
                else
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    Souvenirs miSouvenir = GetID(codigo);

                    if (miSouvenir == null)
                    {
                        MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                        return;
                    }

                    folio = Convert.ToInt32(txtFolio.Text);
                    Carrito miCarrito = GetFolio(folio);
                    //if (miCarrito != null)
                    //{
                    //    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    //    return;
                    //}
                    //Asignacion de variables
                    miCarrito = new Carrito();
                    miCarrito.Codigo = Convert.ToInt32(txtCodigo.Text);
                    miCarrito.Folio = Convert.ToInt32(txtFolio.Text);
                    miCarrito.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    des.Text = miSouvenir.Descripcion.ToString();
                    precio.Text = miSouvenir.Precio.ToString();
                    miCarrito.Descripcion = des.Text;
                    miCarrito.Precio = Convert.ToDouble(precio.Text);
                    miCarrito.Total = miCarrito.Precio * miCarrito.Cantidad;
                    //souvenir agregado al carrito
                    carrito.Add(miCarrito);
                    Serializar();
                    MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
                }
            }
        }

        /// <summary>
        /// Metodo que cerrar el form actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_02_Menu_Cajero());
            MenuPrincipal.AsignarTitulo("Menu de cajero");
        }

        /// <summary>
        /// Metodo que permite acceder a la pantalla de carrito souvenirs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnCarrito_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_07_Carrito_Souvenirs());
            MenuPrincipal.AsignarTitulo("Carrito de souvenirs");
        }

        /// <summary>
        /// Metodo que permite obtener la lista de souvenirs disponibles para su compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public static XElement ObtenerDocumentoXML()
        {
            XElement souvenirsTexto;

            //Valida si existe el archivo de guardado
            if (File.Exists("souvenirs.xml"))
            {
                //Obtenemos la info de un archivo de texto
                string souvenirs = System.IO.File.ReadAllText("souvenirs.xml");

                //Pasamos la cadena por parse
                souvenirsTexto = XElement.Parse(souvenirs);
            }
            else
            {

                // Si no existe, se crea un archivo con datos default
                souvenirsTexto = new XElement("ArrayOfSouvenirs",
                                        //ANIMALES FELPA
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "01"),
                                            new XElement("Descripcion", "Tucan"),
                                            new XElement("Precio", "180")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "02"),
                                            new XElement("Descripcion", "León"),
                                            new XElement("Precio", "200")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "03"),
                                            new XElement("Descripcion", "Oso"),
                                            new XElement("Precio", "250")
                                            ),
                                        //GORRAS-BUFANDA
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "04"),
                                            new XElement("Descripcion", "Gorra Panda"),
                                            new XElement("Precio", "150")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "05"),
                                            new XElement("Descripcion", "Gorra Jirafa"),
                                            new XElement("Precio", "100")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "06"),
                                            new XElement("Descripcion", "Bufanda Leopardo"),
                                            new XElement("Precio", "90")
                                            ),
                                        //CUBREBOCAS
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "07"),
                                            new XElement("Descripcion", "Leopardo"),
                                            new XElement("Precio", "100")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "08"),
                                            new XElement("Descripcion", "Gorila"),
                                            new XElement("Precio", "100")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "09"),
                                            new XElement("Descripcion", "Zootopia"),
                                            new XElement("Precio", "100")
                                            ),
                                        //LLAVEROS
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "10"),
                                            new XElement("Descripcion", "Águila"),
                                            new XElement("Precio", "50")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "11"),
                                            new XElement("Descripcion", "Flamencos"),
                                            new XElement("Precio", "60")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "12"),
                                            new XElement("Descripcion", "Serpiente"),
                                            new XElement("Precio", "100")
                                            ),
                                        //TAZAS
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "13"),
                                            new XElement("Descripcion", "Zootopia"),
                                            new XElement("Precio", "100")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "14"),
                                            new XElement("Descripcion", "Elefantes"),
                                            new XElement("Precio", "100")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "15"),
                                            new XElement("Descripcion", "Pumas"),
                                            new XElement("Precio", "100")
                                            ),
                                        //PLAYERAS
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "16"),
                                            new XElement("Descripcion", "Tigre Blanco"),
                                            new XElement("Precio", "200")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "17"),
                                            new XElement("Descripcion", "Tiburón"),
                                            new XElement("Precio", "200")
                                            ),
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "18"),
                                            new XElement("Descripcion", "Aves"),
                                            new XElement("Precio", "200")
                                            ),
                                        //MEMBRESIAS
                                        new XElement("Souvenirs",
                                            new XElement("Codigo", "19"),
                                            new XElement("Descripcion", "Membresía #19"),
                                            new XElement("Precio", "180")
                                            )
                                        );

                //Guardamos en disco
                souvenirsTexto.Save("souvenirs.xml");
            }

            return souvenirsTexto;
        }

        /// <summary>
        /// Metodo que permite deserializar el documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void PA_02_05_Souvenirs_Load(object sender, EventArgs e)
        {
            //Deserializar();
            DeserializarDocumento();
        }

        /// <summary>
        /// Metodo que permite ajustar el menu de souvenirs a su respectivo formato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnMembresia_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UserInterfaceZoo.Properties.Resources.membresia;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            label2.Text = "19";
            label3.Text = "";
            label4.Text = "";

        }

        /// <summary>
        /// Metodo que permite ajustar el menu de souvenirs a su respectivo formato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnPlayeras_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UserInterfaceZoo.Properties.Resources.playera_tigreblanco;
            pictureBox2.Image = UserInterfaceZoo.Properties.Resources.playera_tiburon;
            pictureBox3.Image = UserInterfaceZoo.Properties.Resources.playera_aves;
            label2.Text = "16";
            label3.Text = "17";
            label4.Text = "18";
        }

        /// <summary>
        /// Metodo que permite ajustar el menu de souvenirs a su respectivo formato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnAnimFelpa_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UserInterfaceZoo.Properties.Resources.peluche_tucan;
            pictureBox2.Image = UserInterfaceZoo.Properties.Resources.peluche_leon;
            pictureBox3.Image = UserInterfaceZoo.Properties.Resources.peluche_oso;
            label2.Text = "01";
            label3.Text = "02";
            label4.Text = "03";
        }

        /// <summary>
        /// Metodo que permite ajustar el menu de souvenirs a su respectivo formato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnGorras_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UserInterfaceZoo.Properties.Resources.gorra_panda;
            pictureBox2.Image = UserInterfaceZoo.Properties.Resources.gorra_jirafa;
            pictureBox3.Image = UserInterfaceZoo.Properties.Resources.bufanda_leopardo;
            label2.Text = "04";
            label3.Text = "05";
            label4.Text = "06";
        }

        /// <summary>
        /// Metodo que permite ajustar el menu de souvenirs a su respectivo formato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnCubrebocas_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UserInterfaceZoo.Properties.Resources.cubre_leopardo;
            pictureBox2.Image = UserInterfaceZoo.Properties.Resources.cubre_gorila;
            pictureBox3.Image = UserInterfaceZoo.Properties.Resources.cubre_zoo;
            label2.Text = "07";
            label3.Text = "08";
            label4.Text = "09";
        }

        /// <summary>
        /// Metodo que permite ajustar el menu de souvenirs a su respectivo formato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnLlaveros_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UserInterfaceZoo.Properties.Resources.llave_aguila;
            pictureBox2.Image = UserInterfaceZoo.Properties.Resources.llave_flamenco;
            pictureBox3.Image = UserInterfaceZoo.Properties.Resources.llavero_serpiente;
            label2.Text = "10";
            label3.Text = "11";
            label4.Text = "12";
        }

        /// <summary>
        /// Metodo que permite ajustar el menu de souvenirs a su respectivo formato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnTazas_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UserInterfaceZoo.Properties.Resources.taza_zoo;
            pictureBox2.Image = UserInterfaceZoo.Properties.Resources.taza_elefante;
            pictureBox3.Image = UserInterfaceZoo.Properties.Resources.taza_puma;
            label2.Text = "13";
            label3.Text = "14";
            label4.Text = "15";
        }

        /// <summary>
        /// Metodo que permite solo el ingreso de caracteres validos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
