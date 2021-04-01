using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace UserInterfaceZoo
{
    public partial class PA_02_03_Apertura_Caja : Form
    {
        //int idCajero;
        //int montoApertura;
        //bool rdbBoleto;
        //bool rsbSouvenir;
        List<Cajas> Cajas = new List<Cajas>();

        //No se toma folio
        //int folio;
        //XDocument apertura = new XDocument();

        //public int MontoApertura { get => montoApertura; set => montoApertura = value; }
        //public int IdCajas { get => idCajas; set => idCajas = value; }
        //public int IdCajero { get => idCajero; set => idCajero = value; }
        //public bool RdbBoleto { get => rdbBoleto; set => rdbBoleto = value; }
        //public bool RsbSouvenir { get => rsbSouvenir; set => rsbSouvenir = value; }

        public PA_02_03_Apertura_Caja()
        {
            InitializeComponent();
        }

        private void Serializar()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();

            XmlSerializer serializarequipo = new XmlSerializer(typeof(List<Cajas>));
            Stream miStreamxml = new FileStream("InfoCajas" + nombrearch + ".xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializarequipo.Serialize(miStreamxml, Cajas);

            miStreamxml.Close();
        }

        //Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        private void Deserializar()
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
        /// Evento que se realizar al presionar el boton abrir cajas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Arturo Villegas
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Se cancela el proceso y regresa al menu
            this.Close();
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton abrir cajas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Arturo Villegas
        private void btnAperturar_Click(object sender, EventArgs e)
        {
            int idCajas = Convert.ToInt32(cmbCaja.Text);
            Cajas miCaja = GetID(idCajas);

            miCaja = new Cajas(); 
            //Asignación de variables
            miCaja.IdCajas = Convert.ToInt32(cmbCaja.Text);
            miCaja.IdCajero = Convert.ToInt32(cmbCajero.Text);
            miCaja.MontoApertura = Convert.ToInt32(txbMontoInicial.Text);
            miCaja.MontoCierre = Convert.ToInt32(txbMontoInicial.Text);
            miCaja.RdbBoleto = rbBoleto.Checked;
            miCaja.RsbSouvenir = rbSouvenir.Checked;
            miCaja.Ganancias = 0;
            miCaja.FaltSobra = 0; 
            //Cajas.Add(miCaja);
            //Serializar();

            //Validación de campos
            if ((miCaja.MontoApertura > 9999 || miCaja.MontoApertura < 7500) || (miCaja.RdbBoleto == false && miCaja.RsbSouvenir == false) || (miCaja.IdCajas < 1 || miCaja.IdCajas > 4) || (miCaja.IdCajero < 1 || miCaja.IdCajero > 5))
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            else
            {
                //Confirmación de exito
                MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
                Cajas.Add(miCaja);
                Serializar();
            }
            //Se completa el proceso y regresa al menu
        }

        private Cajas GetID(int id)
        {
            return Cajas.Find(x => x.IdCajas == id);
        }
        private void PA_02_03_Apertura_Caja_Load(object sender, EventArgs e)
        {
            //string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
            //+ "-" + DateTime.Now.Year.ToString();
            Deserializar();
        }
    }
}
