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
    public partial class PA_06_02_Orden_de_compra_registro_articulos : Form
    {
        public PA_06_02_Orden_de_compra_registro_articulos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_06_01_Orden_de_compra_informacion());
            MenuPrincipal.AsignarTitulo("Orden de Compra");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            PA_06_03_Orden_de_compra_totales pa3 = new PA_06_03_Orden_de_compra_totales();

            //Información de la empresa
            pa3.lblDatosP3.Text = label4.Text;
            //Fechas de orden compra
            pa3.labelFechasP1.Text = lblDatosP2.Text;
            pa3.lblFechaRecp_p3.Text = lblFechaRecp_p2.Text;
            pa3.lblNoOrden_p3.Text = lblNoOrden_p2.Text;
            pa3.dateTimeRecp_p3.Text = dateTimeRecp_p2.Text;
            pa3.dateTimePago_p3.Text = dateTimePago_p2.Text;
            //Proveedor
            pa3.lblCompaProv_p3.Text = lblCompaProv_p2.Text;
            pa3.lblContacto_p3.Text = lblContacto_p2.Text;
            pa3.lblCargo_p3.Text = lblCargo_p2.Text;
            pa3.lblDomProv_p3.Text = lblDomProv_p2.Text;
            pa3.lblTelProv_p3.Text = lblTelProv_p2.Text;
            //Enviar a
            pa3.listBoxCompa_p3.Text = listBoxCompa_p2.Text;
            pa3.listBoxDepa_p3.Text = listBoxDepar_p2.Text;
            pa3.lblDomDepa_p3.Text = lblDomDepa_p2.Text;
            pa3.lblTelDepa_p3.Text = lblTelDepa_p2.Text;
            //Articulos
            
            pa3.txtNumArt_p3.Text = txtNumeroArticulo.Text;
            pa3.lblDescArt_p3.Text = lblDescripcionArticulo.Text;
            pa3.txtCant_p3.Text = txtCantidad.Text;
            //pa3.txtUPeso_p3.Text = txtUnidadPeso.Text;
            pa3.lblPUnitario_p3.Text = lblPrecioUnitario.Text;
            pa3.lblTotal_p3.Text = lblTotal.Text;
            pa3.lblSubtotal.Text = lblTotal.Text;

            MenuPrincipal.abrirPantallas(pa3);
            MenuPrincipal.AsignarTitulo("Orden de compra Totales");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            


            if (txtNumeroArticulo.Text == "" || txtCantidad.Text == "" )
            {
                MenuPrincipal.MostrarMensaje("LOS CAMPOS NO PUEDEN ESTAR VACIOS");
            }

            else
            {
                

                int producto = dataGridViewArticulos.Rows.Add();

                dataGridViewArticulos.Rows[producto].Cells[0].Value = txtNumeroArticulo.Text;
                dataGridViewArticulos.Rows[producto].Cells[1].Value = lblDescripcionArticulo.Text;
                dataGridViewArticulos.Rows[producto].Cells[2].Value = txtCantidad.Text;
                dataGridViewArticulos.Rows[producto].Cells[3].Value = lblPrecioUnitario.Text;
                dataGridViewArticulos.Rows[producto].Cells[4].Value = lblTotal.Text;
            }
            
        }

        private void txtNumeroArticulo_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroArticulo.Text == "")
            {
                MenuPrincipal.MostrarMensaje("NO SE ENCONTRÓ");
            }

            else
            {

                MenuPrincipal.MostrarMensaje("");
                if (txtNumeroArticulo.Text == "121212" || txtNumeroArticulo.Text == "Carne")
                {

                    
                    lblDescripcionArticulo.Text = "Carne de jabali para animales carnivoros";
                    lblPrecioUnitario.Text = "120";
                    int cantidad = Convert.ToInt32(txtCantidad.Text);


                }

                if (txtNumeroArticulo.Text == "12345" || txtNumeroArticulo.Text == "Semillas")
                {
                    lblDescripcionArticulo.Text = "Semillas para todo tipo de Aves";
                    lblPrecioUnitario.Text = "12";
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    int total = Convert.ToInt32(lblPrecioUnitario.Text);
                    lblTotal.Text = Convert.ToString(cantidad * total);

                }

                if (txtNumeroArticulo.Text == "223344" || txtNumeroArticulo.Text == "Vegetales")
                {
                    lblDescripcionArticulo.Text = "Vegetales de la mejor calidad para herbivoros";
                    lblPrecioUnitario.Text = "10";
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    int total = Convert.ToInt32(lblPrecioUnitario.Text);
                    lblTotal.Text = Convert.ToString(cantidad * total);

                }

                if (txtNumeroArticulo.Text == "1234" || txtNumeroArticulo.Text == "Alfalfa")
                {
                    lblDescripcionArticulo.Text = "Alfalfa fresca para animales";
                    lblPrecioUnitario.Text = "6";
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    int total = Convert.ToInt32(lblPrecioUnitario.Text);
                    lblTotal.Text = Convert.ToString(cantidad * total);

                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Char.IsNumber(e.KeyChar)) 
            {
                e.Handled = false; 
                
            }
            else if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false; 
            }
            else 
            {

                e.Handled = true; 
                MenuPrincipal.MostrarMensaje("NO SE ACEPTAN LETRAS, SOLO NÚMEROS");
            }
        }


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                MenuPrincipal.MostrarMensaje("ESTE CAMPO NO PUEDE ESTAR VACIO");

            }

            else
            {
                MenuPrincipal.MostrarMensaje("");

                int cantidad = Convert.ToInt32(txtCantidad.Text);
                int total = Convert.ToInt32(lblPrecioUnitario.Text);
                lblTotal.Text = Convert.ToString(cantidad * total);
            }
        }

        private void txtNumeroArticulo_MouseClick(object sender, MouseEventArgs e)
        {
            txtNumeroArticulo.Text = "";
        }

        private void txtCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            txtCantidad.Text = "";
        }
    }
}
