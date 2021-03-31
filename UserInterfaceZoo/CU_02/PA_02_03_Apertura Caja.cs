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
using System.Net;

namespace UserInterfaceZoo
{
    public partial class PA_02_03_Apertura_Caja : Form
    {
        int idCajas;
        int idCajero;
        double montoApertura;
        bool rdbBoleto;
        bool rsbSouvenir; 
        //No se toma folio
        //int folio;

        private XElement apertura;

        public double MontoApertura { get => montoApertura; set => montoApertura = value; }
        public int IdCajas { get => idCajas; set => idCajas = value; }
        public int IdCajero { get => idCajero; set => idCajero = value; }
        public bool RdbBoleto { get => rdbBoleto; set => rdbBoleto = value; }
        public bool RsbSouvenir { get => rsbSouvenir; set => rsbSouvenir = value; }

        public PA_02_03_Apertura_Caja()
        {
            InitializeComponent();
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
            CrearRegistro();
            
            //Asignación de variables
            IdCajas = Convert.ToInt32(cmbCaja.Text);
            IdCajero = Convert.ToInt32(cmbCajero.Text);
            MontoApertura = Convert.ToDouble(txbMontoInicial.Text);
            RdbBoleto = rbBoleto.Checked;
            RsbSouvenir = rbSouvenir.Checked;
            //Validación de campos
            if ((MontoApertura > 9999 || MontoApertura < 7500) || (RdbBoleto == false && rsbSouvenir == false) || (idCajas < 1 || idCajas > 3) || (idCajero < 1 || idCajero > 5))
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            else
            {
                Cajas.AsignarApertura(IdCajas, MontoApertura);
                //Agregamos los datos a la bitacora
                ((XElement)apertura.FirstNode.NextNode).Add(DateTime.Now);
                //((XElement)apertura.FirstNode.NextNode.NextNode).Add(IdCajas);
                ((XElement)apertura.FirstNode.NextNode.NextNode.NextNode).Add(IdCajero);
                ((XElement)apertura.LastNode).Add(MontoApertura);
                if (rdbBoleto == true)
                {
                    //Agregamos datos a la bitacora
                    ((XElement)apertura.FirstNode).Add("Boleto");

                }
                else
                {
                    //Agregamos datos a la bitacora
                    ((XElement)apertura.FirstNode).Add("Souvenir");

                }
                GuardarApertura();
                //Confirmación de exito
                MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
            }
            //Se completa el proceso y regresa al menu0
            this.Close();
        }

        /// <summary>
        /// Metodo para crear la bitacora del sistema
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 21/03/2021
        /// Creador Isaac librado
        private void CrearRegistro()
        {
            // Creamos la estructura del archivo
            apertura = new XElement("AbrirCaja",
                                    new XElement("Tipo"),
                                    new XElement("FechaHora"),
                                    new XElement("Caja"),
                                    new XElement("Cajero"),
                                    new XElement("MontoApertura")
                                    );
        }

        /// <summary>
        /// Metodo para crear la bitacora del sistema
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 31/03/2021
        /// Creador Arturo Villegas apartir de Isaac Librado
        private void GuardarApertura()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString()
                + "_" + DateTime.Now.Minute.ToString();

            //guardamos la hora actual y guardamos el archivo
            apertura.Save(string.Format("apertura{0}.xml", nombrearch));
        }
    }
}
