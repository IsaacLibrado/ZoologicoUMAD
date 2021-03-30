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
    public partial class PA_02_04_Cerrar_Caja : Form
    {
        int idCajas;
        bool rdbBoleto;
        bool rsbSouvenir;
        double ganancias;
        double montoCaja;
        double faltaSobra;

        XDocument cierre = new XDocument();

        List<Cajas> Caja = new List<Cajas>();

        //public int IdCajas { get => idCajas; set => idCajas = value; }
        //public bool RdbBoleto { get => rdbBoleto; set => rdbBoleto = value; }
        //public bool RsbSouvenir { get => rsbSouvenir; set => rsbSouvenir = value; }
        //public double Ganancias { get => ganancias; set => ganancias = value; }
        //public double MontoCaja { get => montoCaja; set => montoCaja = value; }
        //public double FaltaSobra { get => faltaSobra; set => faltaSobra = value; }

        public PA_02_04_Cerrar_Caja()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ////Asignación de variables
            //idCajas = Convert.ToInt32(cmbCaja.Text);
            //rdbBoleto = rbBoleto.Checked;
            //rsbSouvenir = rbSouvenir.Checked;
            //ganancias = Convert.ToDouble(lblGanancias.Text);
            //montoCaja = Convert.ToDouble(lblMonto.Text);
            //faltaSobra = Convert.ToDouble(txbFaltaSobra.Text);

            //Se completa el proceso y regresa al menu
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //idCajas = Convert.ToInt32(cmbCaja.Text);
            //Cajas caja1 = ObtenerId(idCajas);

        }

        //private Cajas ObtenerId(int idCaja)
        //{
        //    return Caja.Find(x => x.IdCajas == idCaja);
        //}
    }
}
