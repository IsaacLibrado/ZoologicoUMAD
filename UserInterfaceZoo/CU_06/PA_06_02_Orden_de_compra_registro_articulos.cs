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
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_06_03_Orden_de_compra_totales());
            MenuPrincipal.AsignarTitulo("Orden de compra Totales");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int producto = dataGridViewArticulos.Rows.Add();

            

            if (txtNumeroArticulo.Text=="121212" || txtNumeroArticulo.Text=="Carne")
            {
                lblDescripcionArticulo.Text = "Carne de jabali para animales carnivoros";
                lblPrecioUnitario.Text = "120";
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                int total = Convert.ToInt32(lblPrecioUnitario.Text);
                lblTotal.Text =Convert.ToString( cantidad*total);

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
            dataGridViewArticulos.Rows[producto].Cells[0].Value = txtNumeroArticulo.Text;
            dataGridViewArticulos.Rows[producto].Cells[1].Value = lblDescripcionArticulo.Text;
            dataGridViewArticulos.Rows[producto].Cells[2].Value = txtCantidad.Text;
            dataGridViewArticulos.Rows[producto].Cells[3].Value = lblPrecioUnitario.Text;
            dataGridViewArticulos.Rows[producto].Cells[4].Value = lblTotal.Text;

        }
    }
}
