using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceZoo.CU_05
{
    public partial class PA_05_02_Animales : Form
    {
        public PA_05_02_Animales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            PA_05_01_Menú_Mapa_Interactivo mapa = new PA_05_01_Menú_Mapa_Interactivo();
            mapa.Show();
            this.Hide();

        }
    }
}
