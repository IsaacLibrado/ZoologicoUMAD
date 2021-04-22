using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Linq; 
namespace UserInterfaceZoo
{
    public partial class PA_02_02_Pagar_Boletos : Form
    {
        /// <summary>
        /// Esta clase permite pagar los boletos comprados
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        
        //propiedades de acceso
        XDocument documento;
        List<Boletos> Boletos = new List<Boletos>();
        List<Cajas> Cajas = new List<Cajas>();

        //PA_02_01_Vender_Boletos_Entrada vender = new PA_02_01_Vender_Boletos_Entrada();

        public PA_02_02_Pagar_Boletos()
        {
            InitializeComponent();
            //CalculoTotal(); 
        }

        /// <summary>
        /// Esta metodo permite serializar los documentos creados al vender boletos
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void Serializar()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();

            XmlSerializer serializarequipo = new XmlSerializer(typeof(List<Boletos>));
            Stream miStreamxml = new FileStream("VentaBoletos" + nombrearch + ".xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializarequipo.Serialize(miStreamxml, Boletos);
            //por seguridad se cierra el stream
            miStreamxml.Close();
        }

        
        /// <summary>
        ///Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void Deserializar()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            if (File.Exists("VentaBoletos" + nombrearch + ".xml"))
            {
                XmlSerializer deserializarequipo = new XmlSerializer(typeof(List<Boletos>));

                Stream miStream = new FileStream("VentaBoletos" + nombrearch + ".xml", FileMode.Open, FileAccess.Read, FileShare.None);

                Boletos = (List<Boletos>)deserializarequipo.Deserialize(miStream);
                miStream.Close();
            }
        }

        /// <summary>
        /// Esta metodo permite serializar 
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void SerializarCajas()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();

            XmlSerializer serializarequipo = new XmlSerializer(typeof(List<Cajas>));
            Stream miStreamxml = new FileStream("InfoCajas" + nombrearch + ".xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializarequipo.Serialize(miStreamxml, Cajas);
            //por seguridad se cierra el stream
            miStreamxml.Close();
        }


        /// <summary>
        /// Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void DeserializarCajas()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            if (File.Exists("InfoCajas" + nombrearch + ".xml"))
            {
                XmlSerializer deserializarequipo = new XmlSerializer(typeof(List<Cajas>));

                Stream miStream = new FileStream("InfoCajas" + nombrearch + ".xml", FileMode.Open, FileAccess.Read, FileShare.None);

                Cajas = (List<Cajas>)deserializarequipo.Deserialize(miStream);
                miStream.Close();
            }
        }


        /// <summary>
        /// Método que completa el proceso de pago de boletos
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Validacion para campos vacios
            if (txtDineroPagado.Text == "" || txtFolio.Text == "" || cmbCaja.Text == "" || ((rbEfectivo.Checked == false && rbTarjeta.Checked == false)))
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            }
            else
            {
                //Asignacion de boletos
                int folio = Convert.ToInt32(txtFolio.Text);
                Boletos miBoleto = GetID(folio);

                if (miBoleto == null)
                {
                    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    return;
                }
                if (miBoleto.Pago == true)
                {
                    MenuPrincipal.MostrarMensaje("YA FUE PAGADO EL FOLIO");
                    return;
                }

                //Asignacion de variables
                miBoleto.IdCaja = Convert.ToInt32(cmbCaja.Text);
                miBoleto.Tarjeta = rbTarjeta.Checked;
                miBoleto.Efectivo = rbEfectivo.Checked;
                double dineropagado = Convert.ToDouble(txtDineroPagado.Text);
                double total = Convert.ToDouble(lbTotal.Text);

                if (miBoleto.Efectivo == true)
                {
                    //Validación de campos
                    if (miBoleto.IdCaja < 1 || miBoleto.IdCaja > 2 || dineropagado < total || (miBoleto.Tarjeta == false && miBoleto.Efectivo == false))
                    {
                        MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    }
                    else
                    {
                        int idcaja = Convert.ToInt32(cmbCaja.Text);
                        Cajas miCaja = GetIDCaja(idcaja);
                        if (miCaja == null)
                        {
                            MenuPrincipal.MostrarMensaje("LA CAJA NO HA SIDO APERTURADA");
                            return;
                        }
                        if (miCaja.Cerrar == true)
                        {
                            MenuPrincipal.MostrarMensaje("LA CAJA HA SIDO CERRADA");
                            return;
                        }
                        else
                        {
                            //Asignacion de estado pagado al boleto
                            miBoleto.Pago = true;
                            //Asignacion de campos
                            double montoTotal = miCaja.MontoCierre + miBoleto.Total;
                            miCaja.MontoCierre = montoTotal;
                            double cambio = Convert.ToDouble(txtDineroPagado.Text) - Convert.ToDouble(lbTotal.Text);
                            lbCambio.Text = cambio.ToString();
                            //Archivos de evidencia
                            Serializar();
                            SerializarCajas();
                            MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
                        }
                        //Validacion de boleto ya pagado
                        if (MessageBox.Show("Compra ya pagada\n Su cambio: $" + lbCambio.Text, "Compra", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                            MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
                        }
                    }
                }
                else
                {
                    //Validación de campos
                    //Pago con tarjeta
                    if (miBoleto.IdCaja < 1 || miBoleto.IdCaja > 2 || dineropagado != total || (miBoleto.Tarjeta == false && miBoleto.Efectivo == false))
                    {
                        MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    }
                    else
                    {
                        int idcaja = Convert.ToInt32(cmbCaja.Text);
                        Cajas miCaja = GetIDCaja(idcaja);
                        if (miCaja == null)
                        {
                            MenuPrincipal.MostrarMensaje("LA CAJA NO HA SIDO APERTURADA");
                            return;
                        }
                        if (miCaja.Cerrar == true)
                        {
                            MenuPrincipal.MostrarMensaje("LA CAJA HA SIDO CERRADA");
                            return;
                        }
                        else
                        {
                            miBoleto.Pago = true;
                            double montoTotal = miCaja.MontoCierre + miBoleto.Total;
                            miCaja.MontoCierre = montoTotal;
                            double cambio = Convert.ToDouble(txtDineroPagado.Text) - Convert.ToDouble(lbTotal.Text);
                            lbCambio.Text = cambio.ToString();
                            Serializar();
                            SerializarCajas();
                            MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
                        }
                        if (MessageBox.Show("Compra ya pagada\n Su cambio: $" + lbCambio.Text, "Compra", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                            MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Método para terminar labores en la venta de boletos y creacion de documento
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            int folio = Convert.ToInt32(txtFolio.Text);
            Boletos miBoleto = GetID(folio);

            if (miBoleto == null)
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                return;
            }
            Boletos.Remove(miBoleto);
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();

            documento = XDocument.Load("VentaBoletos" + nombrearch + ".xml");
            documento.Descendants("Boletos")
                    .Where(nodo => (string)nodo.Element("Folio") == txtFolio.Text)
                    .Remove();

            documento.Save("VentaBoletos" + nombrearch + ".xml"); //Se guarda en el documento
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
        }

        /// <summary>
        /// Método que permite obtener un boleto por su id
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private Boletos GetID(int folio)
        {
            return Boletos.Find(x => x.Folio == folio);
        }

        /// <summary>
        /// Método que permite obtener una caja por su id
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private Cajas GetIDCaja(int id)
        {
            return Cajas.Find(x => x.IdCajas == id);
        }

        /// <summary>
        /// deserializa al momento de cargar este form
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void PA_02_02_Pagar_Boletos_Load(object sender, EventArgs e)
        {
            Deserializar();
            DeserializarCajas();
        }

        /// <summary>
        /// Busqueda de un boleto no pagado por su id ingresado
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int folio = Convert.ToInt32(txtFolio.Text);
            Boletos miBoleto = GetID(folio);

            if (miBoleto == null)
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                return;
            }
            if (miBoleto.Pago == true)
            {
                MenuPrincipal.MostrarMensaje("YA FUE PAGADO EL FOLIO");
                return;
            }
            lbTotal.Text = miBoleto.Total.ToString();
        }

        /// <summary>
        /// actualiza el lbl de monto segun se ingresa una cantidad
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void txtDineroPagado_TextChanged(object sender, EventArgs e)
        {
            if (lbTotal.Text != "-")
            {
                if (txtDineroPagado.Text == "")
                {
                    txtDineroPagado.Text = "0";
                }
                else
                {
                    double dineropagado = Convert.ToDouble(txtDineroPagado.Text);
                    double total = Convert.ToDouble(lbTotal.Text);
                    double cambio = dineropagado - total;
                    lbCambio.Text = cambio.ToString();
                }
            }
        }

        /// <summary>
        /// Valida el formato ingresado
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        /// <summary>
        /// Valida el formato de ingreso
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        private void Dinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
