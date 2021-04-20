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
    public partial class PA_02_08_Pago_Souvenirs : Form
    {
        List<ComprasSouvenirs> comprasSouvenirs = new List<ComprasSouvenirs>();
        List<Cajas> cajas = new List<Cajas>();
        List<ComprasSouvenirs> confirmacion = new List<ComprasSouvenirs>();

        public PA_02_08_Pago_Souvenirs()
        {
            InitializeComponent();
        }

        private void Serializar()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "Compra-VentaSouvenirs" + nombrearch + "-folio" + txtCompra.Text + ".xml";

            XmlSerializer serializarequipo = new XmlSerializer(typeof(List<ComprasSouvenirs>));
            Stream miStreamxml = new FileStream(archivo, FileMode.Create, FileAccess.Write, FileShare.None);
            serializarequipo.Serialize(miStreamxml, comprasSouvenirs);

            miStreamxml.Close();
        }

        //Método para deserializar en el que aparte checará si existe el archivo que ya se creó.
        private void Deserializar()
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "Compra-VentaSouvenirs" + nombrearch + "-folio" + txtCompra.Text + ".xml";

            if (File.Exists(archivo))
            {
                XmlSerializer deserializarequipo = new XmlSerializer(typeof(List<ComprasSouvenirs>));

                Stream miStream = new FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.None);

                comprasSouvenirs = (List<ComprasSouvenirs>)deserializarequipo.Deserialize(miStream);
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
            serializarequipo.Serialize(miStreamxml, cajas);

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

                cajas = (List<Cajas>)deserializarequipo.Deserialize(miStream);
                miStream.Close();
            }
        }

        /// <summary>
        /// Evento que se realizar al presionar el boton pagar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador Karla Garcia
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtCompra.Text == "" || txtPagado.Text == "" || cmbCaja.Text == "" || ((rbEfectivo.Checked == false && rbMembresia.Checked == false && rbTarjeta.Checked == false)))
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
            }
            else
            {
                string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
        + "-" + DateTime.Now.Year.ToString();
                string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtCompra.Text + ".xml";
                double dineropagado = Convert.ToDouble(txtPagado.Text);
                double total = Convert.ToDouble(lbTotal.Text);

                ComprasSouvenirs miCompra = GetID(archivo);

                if (miCompra == null)
                {
                    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    return;
                }
                miCompra.IdCaja = Convert.ToInt32(cmbCaja.Text);
                miCompra.Efectivo = rbEfectivo.Checked;
                miCompra.Mebresia = rbMembresia.Checked;
                miCompra.Tarjeta = rbTarjeta.Checked;
                miCompra.Pago = true;

                if (miCompra.Tarjeta == true)
                {
                    if (miCompra.IdCaja < 3 || miCompra.IdCaja > 4 || dineropagado != total || (miCompra.Tarjeta == false && miCompra.Efectivo == false && miCompra.Mebresia == false))
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
                        else if (miCompra.Pago == true)
                        {
                            double montoTotal = miCaja.MontoCierre + miCompra.Total;
                            miCaja.MontoCierre = montoTotal;
                            double cambio = Convert.ToDouble(txtPagado.Text) - Convert.ToDouble(lbTotal.Text);
                            lbCambio.Text = cambio.ToString();
                            Serializar();
                            SerializarCajas();
                            MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
                        }
                        if (MessageBox.Show("Compra ya pagada\n Su cambio: $" + lbCambio.Text, "Compra", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
                        }
                    }
                }
                else
                {
                    //Validación de campos miCompra.IdCaja < 3 || miCompra.IdCaja > 4 || 
                    if (miCompra.IdCaja < 3 || miCompra.IdCaja > 4 || dineropagado < total || (miCompra.Tarjeta == false && miCompra.Efectivo == false && miCompra.Mebresia == false))
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
                        else if (miCompra.Pago == true)
                        {
                            double montoTotal = miCaja.MontoCierre + miCompra.Total;
                            miCaja.MontoCierre = montoTotal;
                            double cambio = Convert.ToDouble(txtPagado.Text) - Convert.ToDouble(lbTotal.Text);
                            lbCambio.Text = cambio.ToString();
                            Serializar();
                            SerializarCajas();
                            MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
                        }
                        if (MessageBox.Show("Compra ya pagada\n Su cambio: $" + lbCambio.Text, "Compra", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
                        }
                    }
                }
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Deserializar();
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            string archivo = "VentaSouvenirs" + nombrearch + "-folio" + txtCompra.Text + ".xml";
            //lbCambio.Text = archivo; 

            ComprasSouvenirs miCompra = GetID(archivo);

            if (miCompra == null)
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                return;
            }
            if(miCompra.Pago == true)
            {
                MenuPrincipal.MostrarMensaje("YA FUE PAGADO EL FOLIO");
                return;
            }
            //if (miCompra != null)
            //{
            //    MenuPrincipal.MostrarMensaje("YA FUE PAGADO EL FOLIO");
            //    return; 
            //}
            lbTotal.Text = miCompra.Total.ToString();
        }

        private void PA_02_08_Pago_Souvenirs_Load(object sender, EventArgs e)
        {
            //creamos el formato del nombre del archivo
            string nombrearch = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString()
                + "-" + DateTime.Now.Year.ToString();
            DeserializarCajas(); 
        }

        private ComprasSouvenirs GetID(string archivo)
        {
            return comprasSouvenirs.Find(x => x.Archivo == archivo);
        }

        private Cajas GetIDCaja(int id)
        {
            return cajas.Find(x => x.IdCajas == id);
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

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

        private void txtPagado_TextChanged(object sender, EventArgs e)
        {
            if (txtPagado.Text == "")
            {
                txtPagado.Text = "0";
            }
            else
            {
                double dineropagado = Convert.ToDouble(txtPagado.Text);
                double total = Convert.ToDouble(lbTotal.Text);
                double cambio = dineropagado - total;
                lbCambio.Text = cambio.ToString();
            }
        }
    }
}
