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
    public partial class PA_02_07_Carrito_Souvenirs : Form
    {
        public PA_02_07_Carrito_Souvenirs()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_06_Membresia());
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_08_Pago_Souvenirs());
        }
    }
}
