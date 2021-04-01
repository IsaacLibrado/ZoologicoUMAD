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

namespace UserInterfaceZoo
{
    public partial class PA_02_02_Pagar_Boletos : Form
    {
        
        List<Boletos> Boletos = new List<Boletos>();
        List<Cajas> Cajas = new List<Cajas>();

        //PA_02_01_Vender_Boletos_Entrada vender = new PA_02_01_Vender_Boletos_Entrada();

        public PA_02_02_Pagar_Boletos()
        {
            InitializeComponent();
            //CalculoTotal(); 
        }
        
        private void Serializar()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();

            XmlSerializer serializarequipo = new XmlSerializer(typeof(List<Boletos>));
            Stream miStreamxml = new FileStream("VentaBoletos" + nombrearch + ".xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializarequipo.Serialize(miStreamxml, Boletos);

            miStreamxml.Close();
        }

        //Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
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


        private void SerializarCajas()
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



        private void btnPagar_Click(object sender, EventArgs e)
        {
            int folio = Convert.ToInt32(txtFolio.Text);
            Boletos miBoleto = GetID(folio);

            if (miBoleto == null)
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                return;
            }
            miBoleto.IdCaja = Convert.ToInt32(cmbCaja.Text);
            miBoleto.Tarjeta = rbTarjeta.Checked;
            miBoleto.Efectivo = rbEfectivo.Checked;

            double dineropagado = Convert.ToDouble(txtDineroPagado.Text); 
            double total = Convert.ToDouble(lbTotal.Text);

            //Validación de campos
            if (miBoleto.IdCaja  < 1 || miBoleto.IdCaja > 2 || dineropagado < total || (miBoleto.Tarjeta == false && miBoleto.Efectivo == false))
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            else
            {
                int idcaja = Convert.ToInt32(cmbCaja.Text);
                Cajas miCaja = GetIDCaja(idcaja);

                double montoTotal = miCaja.MontoCierre + miBoleto.Total;
                miCaja.MontoCierre = montoTotal;
                double cambio = Convert.ToDouble(txtDineroPagado.Text) - Convert.ToDouble(lbTotal.Text);
                lbCambio.Text = cambio.ToString();
                Serializar();
                SerializarCajas();
                MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
            } 
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
        }

        private Boletos GetID(int folio)
        {
            return Boletos.Find(x => x.Folio == folio);
        }

        private Cajas GetIDCaja(int id)
        {
            return Cajas.Find(x => x.IdCajas == id);
        }

        private void PA_02_02_Pagar_Boletos_Load(object sender, EventArgs e)
        {
            Deserializar();
            DeserializarCajas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int folio = Convert.ToInt32(txtFolio.Text);
            Boletos miBoleto = GetID(folio);

            if (miBoleto == null)
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                return;
            }
            lbTotal.Text = miBoleto.Total.ToString(); 
        }
    }
}
