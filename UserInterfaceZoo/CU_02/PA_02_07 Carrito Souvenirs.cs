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
using System.IO;

namespace UserInterfaceZoo
{
    public partial class PA_02_07_Carrito_Souvenirs : Form
    {
        List<Carrito> carrito = new List<Carrito>();
        List<ComprasSouvenirs> confirmacion = new List<ComprasSouvenirs>(); 
        double suma = 0;

        public PA_02_07_Carrito_Souvenirs()
        {
            InitializeComponent();
        }

        private void SerializarConfirmacion()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtArchivo.Text + ".xml";
            XmlSerializer serializarequipo = new XmlSerializer(typeof(List<ComprasSouvenirs>));
            Stream miStreamxml = new FileStream("Compra-" + archivo, FileMode.Create, FileAccess.Write, FileShare.None);
            serializarequipo.Serialize(miStreamxml, confirmacion);

            miStreamxml.Close();
        }

        //Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        private void DeserializarConfrimacion()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtArchivo.Text + ".xml";
            if (File.Exists("Compra-" + archivo))
            {
                XmlSerializer deserializarequipo = new XmlSerializer(typeof(List<ComprasSouvenirs>));

                Stream miStream = new FileStream("Compra-" + archivo, FileMode.Open, FileAccess.Read, FileShare.None);

                confirmacion = (List<ComprasSouvenirs>)deserializarequipo.Deserialize(miStream);
                miStream.Close();
            }
        }

        //Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        private void Deserializar()
        {
            //string archivo = txtArchivo.Text;
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtArchivo.Text + ".xml";

            if (File.Exists(archivo))
            {
                XmlSerializer deserializarequipo = new XmlSerializer(typeof(List<Carrito>));

                Stream miStream = new FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.None);

                carrito = (List<Carrito>)deserializarequipo.Deserialize(miStream);
                miStream.Close();
            }
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Karla Garcia
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtArchivo.Text + ".xml";

            //Código de seguridad para eliminar el archivo de texto solo si este existe
            if (File.Exists(archivo))
                File.Delete(archivo);

            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_06_Membresia());
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton Pagar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Karla Garcia
        private void btnPagar_Click(object sender, EventArgs e)
        {
            DeserializarConfrimacion(); 
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
    + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtArchivo.Text + ".xml";
            ComprasSouvenirs miConfirmacion = GetID(archivo);

            if (miConfirmacion != null)
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                return;
            }

            //folio = Convert.ToInt32(txtFolio.Text);
            //Carrito miCarrito = GetFolio(folio);
            //if (miCarrito != null)
            //{
            //    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            //    return;
            //}

            miConfirmacion = new ComprasSouvenirs();
            miConfirmacion.Archivo = archivo;
            miConfirmacion.Total = suma;
            miConfirmacion.IdCaja = 0;
            miConfirmacion.Efectivo = false;
            miConfirmacion.Mebresia = false;
            miConfirmacion.Tarjeta = false; 
            confirmacion.Add(miConfirmacion); 
            SerializarConfirmacion();
            MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");

            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_08_Pago_Souvenirs());
            MenuPrincipal.AsignarTitulo("Pago de souvenirs");
        }

        private void PA_02_07_Carrito_Souvenirs_Load(object sender, EventArgs e)
        {
            ////creamos el formato del nombre del archivo
            //string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
            //    + "-" + DateTime.Now.Year.ToString();

            //txtArchivo.Text = "VentaSouvenirs" + nombrearch + "-folio[0].xml";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DeserializarConfrimacion();
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtArchivo.Text + ".xml";
            ComprasSouvenirs miConfirmacion = GetID(archivo);

            if (miConfirmacion != null)
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                return;
            }

            DataSet ds = new DataSet();
            ds.ReadXml(archivo);
            dataGridView1.DataSource = ds.Tables[0];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                suma += Convert.ToDouble(row.Cells["Total"].Value);
            }

            lbTotal.Text = suma.ToString(); 
            Deserializar(); 
        }

        private ComprasSouvenirs GetID(string archivo)
        {
            return confirmacion.Find(x => x.Archivo == archivo);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_06_Membresia());
        }
    }
}
