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
            //int folio = 0;
            //lblNoOrden.Text = "0";
            //folio = Convert.ToInt32(this.lblNoOrden.Text);
            //folio++;
            //lblNoOrden.Text = folio.ToString();

            //Se adicionan los elementos
            listClaveProveedor.Items.Add("PetsFood");
            listClaveProveedor.Items.Add("AnimalPet");
           
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
        }
    }
}
