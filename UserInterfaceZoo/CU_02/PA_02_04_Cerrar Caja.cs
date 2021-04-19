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
    public partial class PA_02_04_Cerrar_Caja : Form
    {
        //int idCajas;
        //bool rdbBoleto;
        //bool rsbSouvenir;
        //double ganancias;
        //double montoCaja;
        //double faltaSobra;

        //XDocument cierre = new XDocument();

        List<Cajas> Cajas = new List<Cajas>();

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCaja.Text == "")
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            }
            else
            {
                int idcaja = Convert.ToInt32(cmbCaja.Text);
                Cajas miCaja = GetID(idcaja);

                if (miCaja == null)
                {
                    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    return;
                }
                //lblMonto.Text = miCaja.MontoCierre.ToString();
                //double monto = miCaja.MontoCierre - miCaja.MontoApertura;
                //lblGanancias.Text = monto.ToString();

                //miCaja.FaltSobra = Convert.ToDouble(txbFaltaSobra.Text);
                //miCaja.Ganancias = monto; 
                if ((miCaja.IdCajas < 1 || miCaja.IdCajas > 4))
                    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                else
                {


                    if (miCaja.RdbBoleto == true)
                        label1.Text = "Boleto";
                    else
                        label1.Text = "Souvenirs";

                    lblMonto.Text = miCaja.MontoCierre.ToString();
                    double monto = miCaja.MontoCierre - miCaja.MontoApertura;
                    lblGanancias.Text = monto.ToString();

                    //miCaja.FaltSobra = Convert.ToDouble(txbFaltaSobra.Text);
                    //miCaja.Ganancias = monto;
                    //Serializar();
                    MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
                }
            }
        }

        private void PA_02_04_Cerrar_Caja_Load(object sender, EventArgs e)
        {
            Deserializar();
        }

        private Cajas GetID(int id)
        {
            return Cajas.Find(x => x.IdCajas == id);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (cmbCaja.Text == "")
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            }
            else
            {
                int idcaja = Convert.ToInt32(cmbCaja.Text);
                Cajas miCaja = GetID(idcaja);


                if (miCaja == null)
                {
                    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    return;
                }
                if (miCaja.Ganancias == 0)
                {
                    miCaja.FaltSobra = Convert.ToDouble(txbFaltaSobra.Text);

                    if (miCaja.IdCajas < 1 || miCaja.IdCajas > 4)
                        MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    else
                    {
                        lblMonto.Text = miCaja.MontoCierre.ToString();
                        double monto = miCaja.MontoCierre - miCaja.MontoApertura;
                        lblGanancias.Text = monto.ToString();

                        miCaja.Ganancias = Convert.ToDouble(lblGanancias.Text);
                        Serializar();
                    }
                }
                else
                    MenuPrincipal.MostrarMensaje("LA CAJA YA SE CERRÓ");
            }
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
