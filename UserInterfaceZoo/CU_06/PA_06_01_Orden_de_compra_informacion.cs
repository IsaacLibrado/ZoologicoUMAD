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
           
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_06_02_Orden_de_compra_registro_articulos());
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
            //int folio = 1;
            //int conversion = folio + 1;

            //lblNoOrden.Text = Convert.ToString(conversion);           

            //int folio = int.Parse(lblNoOrden.Text);
            //folio++;
            //lblNoOrden.Text = folio.ToString();
            int contador = 0;
            int folio = 0;
            int folio2 = 0;

            contador++;
            lblNoOrden.Text = Convert.ToString(contador);
            folio += Convert.ToInt32(lblNoOrden.Text);



            folio++;
            folio2 = folio;

            MessageBox.Show(folio2.ToString());
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
    }
}
