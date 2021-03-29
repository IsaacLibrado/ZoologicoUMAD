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
    public partial class PA_02_01_Vender_Boletos_Entrada : Form
    {
        int boletosAdultos;
        int boletosNinios;
        int boletosAdultosMayores;

        public int BoletosAdultos { get => boletosAdultos; set => boletosAdultos = value; }
        public int BoletosNinios { get => boletosNinios; set => boletosNinios = value; }
        public int BoletosAdultosMayores { get => boletosAdultosMayores; set => boletosAdultosMayores = value; }

        public PA_02_01_Vender_Boletos_Entrada()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            boletosAdultos = Convert.ToInt32(txtBoletosAdultos.Text); 
            boletosNinios = Convert.ToInt32(txtBoletosNinios.Text);
            boletosAdultosMayores = Convert.ToInt32(txtBoletosAdultosMayores.Text); 
            MenuPrincipal.abrirPantallas(new PA_02_02_Pagar_Boletos());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
