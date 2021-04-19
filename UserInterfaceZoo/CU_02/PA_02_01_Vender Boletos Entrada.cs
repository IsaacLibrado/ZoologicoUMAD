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
    public partial class PA_02_01_Vender_Boletos_Entrada : Form
    {
        //int boletosAdultosV;
        //int boletosNiniosV;
        //int boletosAdultosMayoresV;
        //double totalV; 
        List<Boletos> Boletos = new List<Boletos>();
        //public int BoletosAdultos { get => boletosAdultosV; set => boletosAdultosV = value; }
        //public int BoletosNinios { get => boletosNiniosV; set => boletosNiniosV = value; }
        //public int BoletosAdultosMayores { get => boletosAdultosMayoresV; set => boletosAdultosMayoresV = value; }

        public PA_02_01_Vender_Boletos_Entrada()
        {
            InitializeComponent();
        }

        //public PA_02_01_Vender_Boletos_Entrada(int ba, int bn, int bam)
        //{
        //    InitializeComponent();
        //    boletosAdultos = ba;
        //    boletosNinios = bn;
        //    boletosAdultosMayores = bam; 
        //}


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


        private void btnVender_Click(object sender, EventArgs e)
        {
            if (txtBoletosAdultos.Text == "" || txtBoletosAdultosMayores.Text == "" || txtBoletosNinios.Text == "" || txtFolio.Text == "")
            {
                MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                return;
            }
            else
            {
                int folio = Convert.ToInt32(txtFolio.Text);
                Boletos miBoleto = GetID(folio);

                if (miBoleto != null)
                {
                    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                    return;
                }

                miBoleto = new Boletos();
                //Asignación de variables
                miBoleto.Folio = Convert.ToInt32(txtFolio.Text);
                miBoleto.IdCaja = 0;
                miBoleto.BoletosAdultos = Convert.ToInt32(txtBoletosAdultos.Text);
                miBoleto.BoletosNinios = Convert.ToInt32(txtBoletosNinios.Text);
                miBoleto.BoletosAdultosMayores = Convert.ToInt32(txtBoletosAdultosMayores.Text);
                miBoleto.Efectivo = false;
                miBoleto.Tarjeta = false;
                miBoleto.Total = (miBoleto.BoletosAdultos * 200 + miBoleto.BoletosNinios * 150 + miBoleto.BoletosAdultosMayores * 100);

                //Validación de campos
                if (miBoleto.BoletosAdultos < 0 || miBoleto.BoletosNinios < 0 || miBoleto.BoletosAdultosMayores < 0 || miBoleto.Folio < 0)
                    MenuPrincipal.MostrarMensaje("PROCESO INVÁLIDO INTENTE DE NUEVO");
                else
                {
                    //Confirmación de exito
                    MenuPrincipal.MostrarMensaje("ACCIÓN SOLICITADA COMPLETADA");
                    Boletos.Add(miBoleto);
                    Serializar();

                    //MenuPrincipal.abrirPantallas(new PA_02_02_Pagar_Boletos());
                    //MenuPrincipal.AsignarTitulo("Pagar Boletos");
                    this.Close();
                    MenuPrincipal.abrirPantallas(new PA_02_02_Pagar_Boletos());
                    MenuPrincipal.AsignarTitulo("Pagar Boletos");
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_01_02_Menu_Cajero());
        }

        private Boletos GetID(int folio)
        {
            return Boletos.Find(x => x.Folio == folio);
        }

        private void PA_02_01_Vender_Boletos_Entrada_Load(object sender, EventArgs e)
        {
            Deserializar();
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
