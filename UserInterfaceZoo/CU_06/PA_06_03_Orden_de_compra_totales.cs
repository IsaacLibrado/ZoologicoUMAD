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
    public partial class PA_06_03_Orden_de_compra_totales : Form
    {
        
        public PA_06_03_Orden_de_compra_totales()
        {
            InitializeComponent();  
            
         
        }
        public PA_06_03_Orden_de_compra_totales(string texto)
        {
            InitializeComponent();
            lblSubtotal.Text =texto;
            lblTasaImpuestos.Text = "16 %";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_06_02_Orden_de_compra_registro_articulos());
            MenuPrincipal.AsignarTitulo("Orden de compra registro artículos");
                                 
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this.Close();
            //PA_06_01_Orden_de_compra_informacion pa1 = new PA_06_01_Orden_de_compra_informacion();
            //pa1.GenerarNumeroOrden();            
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            double descuento = Convert.ToDouble(txtDescuento.Text);
            descuento = descuento / 100;
            int total = Convert.ToInt32(lblSubtotal.Text);

            lblSubtotalDescuento.Text = Convert.ToString(descuento*total);
            double subtotal = Convert.ToDouble(lblSubtotalDescuento.Text);
            double iva = 0.16;
            lblTotalImpuestos.Text = Convert.ToString(subtotal*iva+(subtotal));

            //double totalImpuestos = Convert.ToDouble(lblTasaImpuestos.Text);
            //lblEnvioAlmacen.Text = Convert.ToString(totalImpuestos *0.25);

            //double grantotal = Convert.ToDouble(lblEnvioAlmacen.Text);
            //lblGranTotal.Text = Convert.ToString(grantotal +totalImpuestos);
        }
    }
}
