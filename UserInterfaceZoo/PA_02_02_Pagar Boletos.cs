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
    public partial class PA_02_02_Pagar_Boletos : Form
    {
        PA_02_01_Vender_Boletos_Entrada vender_Boletos_Entrada = new PA_02_01_Vender_Boletos_Entrada(); 
        public PA_02_02_Pagar_Boletos()
        {
            InitializeComponent();
            CalculoTotal(); 
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
        }

        private void CalculoTotal()
        {
            //adultos 200, niños 150, adultos mayores 100
            //string adultos = vender_Boletos_Entrada.BoletosAdultos;
            //int ninios = vender_Boletos_Entrada.BoletosNinios;
            //int mayores = vender_Boletos_Entrada.BoletosAdultosMayores;
            //double total; 

            //total = (adultos*200) + (ninios*150) + (mayores*100);
            //lbTotal.Text = total.ToString(); 
        }
    }
}
