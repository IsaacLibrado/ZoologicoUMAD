using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceZoo
{
    public partial class PA_06_01_Orden_de_compra_informacion : Form
    {
        
        public PA_06_01_Orden_de_compra_informacion()
        {
            InitializeComponent();

            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            PA_06_02_Orden_de_compra_registro_articulos pa2_pa1 = new PA_06_02_Orden_de_compra_registro_articulos();

            //Información de la empresa
            pa2_pa1.lblDatosP2.Text = label4.Text;
            //Fechas de orden compra
            pa2_pa1.label4.Text = lblInfoE.Text;
            pa2_pa1.lblFechaRecp_p2.Text = lblFechaRecp.Text;
            pa2_pa1.lblNoOrden_p2.Text = lblNoOrden.Text;
            pa2_pa1.dateTimeRecp_p2.Text = dateTimePicker1.Text;
            pa2_pa1.dateTimePago_p2.Text = dateTimePicker2.Text;
            //Proveedor
            pa2_pa1.lblCompaProv_p2.Text = lblCompaProveedor.Text;
            pa2_pa1.lblContacto_p2.Text = lblContacto.Text;
            pa2_pa1.lblCargo_p2.Text = lblCargo.Text;
            pa2_pa1.lblDomProv_p2.Text = lblDomProveedor.Text;
            pa2_pa1.lblTelProv_p2.Text = lblTelProveedor.Text;
            //Enviar a
            pa2_pa1.listBoxCompa_p2.Text = listBoxCompañia.Text;
            pa2_pa1.listBoxDepar_p2.Text = listBoxDepartamento.Text;
            pa2_pa1.lblDomDepa_p2.Text = lblDomicilioDepartamento.Text;
            pa2_pa1.lblTelDepa_p2.Text = lblTelefonoDepartamento.Text;


            if (dateTimePicker1.Value.Date < DateTime.Now.Date && dateTimePicker2.Value.Date < DateTime.Now.Date)
            {
                MenuPrincipal.MostrarMensaje("LA FECHA SELECCIONADA ES MENOR A LA FECHA DEL SISTEMA");
            }
            else
                MenuPrincipal.abrirPantallas(pa2_pa1); 
                MenuPrincipal.AsignarTitulo("Orden de compra registro artículos");
        }


        private void PA_06_01_Orden_de_compra_informacion_Load(object sender, EventArgs e)
        {
 
            //Se adicionan los elementos
            listClaveProveedor.Items.Add("PetsFood");
            listClaveProveedor.Items.Add("AnimalPet");

            GenerarNumeroOrden();
           
        }

        private void listClaveProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listClaveProveedor.SelectedItem == "PetsFood")
            {
                lblCompaProveedor.Text = "PetsFood";
                lblContacto.Text = "Juan Perez Dominic";
                lblCargo.Text = "Proveedor";
                lblDomProveedor.Text = "3 Sur";
                lblTelProveedor.Text = "2223114060";

            }
            if (listClaveProveedor.SelectedItem == "AnimalPet")
            {
                lblCompaProveedor.Text = "AnimalPet";
                lblContacto.Text = "Benjamin Flores Pino";
                lblCargo.Text = "Proveedor";
                lblDomProveedor.Text = "10 Poniente";
                lblTelProveedor.Text = "2211678923";

            }
        }

        private void fechaRecepcion_Tick(object sender, EventArgs e)
        {
            lblFechaRecp.Text = DateTime.Now.ToShortDateString();
        }

        public void GenerarNumeroOrden()
        {


            var seed = Environment.TickCount;
            var random = new Random(seed);

            var value = random.Next(1, 100);
            lblNoOrden.Text = Convert.ToString(value);



        }

        private void listBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDepartamento.SelectedItem=="Almacen")
            {
                lblDomicilioDepartamento.Text = "Calle 5 Sur Col Centro";
                lblTelefonoDepartamento.Text = "2231231200";

            }
            if (listBoxDepartamento.SelectedItem == "Repartidor")
            {
                lblDomicilioDepartamento.Text = "Calle 9 Norte";
                lblTelefonoDepartamento.Text = "9816299715";

            }
            if (listBoxDepartamento.SelectedItem == "Compras")
            {
                lblDomicilioDepartamento.Text = "Av 5 Norte";
                lblTelefonoDepartamento.Text = "518264212";

            }
            if (listBoxDepartamento.SelectedItem == "Encargado")
            {
                lblDomicilioDepartamento.Text = "Bugambilias 2 sur";
                lblTelefonoDepartamento.Text = "82622773";

            }

        }

        private void listBoxCompañia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCompañia.SelectedItem == "Zootopia SA de CV")
            {
                listBoxDepartamento.SelectedIndex=1;
            }         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MenuPrincipal.MostrarMensaje("LA FECHA SELECCIONADA ES MENOR A LA FECHA DEL SISTEMA");
            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value.Date < DateTime.Now.Date)
            {
                MenuPrincipal.MostrarMensaje("LA FECHA SELECCIONADA ES MENOR A LA FECHA DEL SISTEMA");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
