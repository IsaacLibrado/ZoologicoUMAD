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

namespace UserInterfaceZoo
{
    public partial class PA_02_03_Apertura_Caja : Form
    {
        int idCajas;
        int idCajero;
        int montoApertura;
        bool rdbBoleto;
        bool rsbSouvenir; 
        //No se toma folio
        //int folio;
        XDocument apertura = new XDocument();

        public int MontoApertura { get => montoApertura; set => montoApertura = value; }
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
            //Asignación de variables
            IdCajas = Convert.ToInt32(cmbCaja.Text);
            IdCajero = Convert.ToInt32(cmbCajero.Text);
            MontoApertura = Convert.ToInt32(txbMontoInicial.Text);
            RdbBoleto = rbBoleto.Checked;
            RsbSouvenir = rbSouvenir.Checked;
            //Validación de campos
            if ((MontoApertura > 9999 || MontoApertura < 7500) || (RdbBoleto == false && rsbSouvenir == false) || (idCajas < 1 || idCajas > 3) || (idCajero < 1 || idCajero > 5))
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            else
            {
                apertura = XDocument.Load("apertura.xml");
                //Asignación de las variables
                if (rdbBoleto == true)
                {
                    XElement temp = new XElement("AbrirCajaBoleto",
                            //new XElement("Folio", folio),
                            new XElement("Caja", IdCajas),
                            new XElement("Cajero", IdCajero),
                             new XElement("MontoApertura", MontoApertura));
                    apertura.Descendants("AperturaDeCaja").First().Add(temp);
                }
                else
                {
                    XElement temp = new XElement("AbrirCajaSouvenir",
                            //new XElement("Folio", folio),
                            new XElement("Caja", IdCajas),
                            new XElement("Cajero", IdCajero),
                             new XElement("MontoApertura", MontoApertura));
                    apertura.Descendants("AperturaDeCaja").First().Add(temp);
                }
                //Guardado en XML

                apertura.Save("apertura.XML");
                //folio++;
                //Confirmación de exito
                MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
            }
            //Se completa el proceso y regresa al menu
            this.Close();
        }
    }
}
