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
    public partial class PA_05_02_Menú_Mapa_Interactivo_Ubicacion : Form
    {
        public PA_05_02_Menú_Mapa_Interactivo_Ubicacion()
        {
            InitializeComponent();
        }

        //Muestra Pantalla
        private void btnGuacamaya_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_04_Animales());
        }

        //Muestra Pantalla
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_26_Salir());
        }

        //Muestra Pantalla
        private void BtnJirafa_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_08_Animales());
        }

        //Muestra Pantalla
        private void BtnElefante_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_09_Animales());
        }

        //Muestra Pantalla
        private void BtnCebra_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_10_Animales());
        }

        //Muestra Pantalla
        private void BtnTigre_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_11_Animales());
        }

        //Muestra Pantalla
        private void BtnPinguino_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_12_Animales());
        }

        //Muestra Pantalla
        private void BtnFlamenco_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_13_Animales());
        }

        //Muestra Pantalla
        private void BtnOso_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_14_Animales());
        }

        //Muestra Pantalla
        private void BtnPuma_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_15_Animales());
        }

        //Muestra Pantalla
        private void BtnJaguar_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_16_Animales());
        }

        //Muestra Pantalla
        private void BtnLeon_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_17_Animales());
        }

        //Muestra Pantalla
        private void BtnAguia_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_05_Animales());
        }

        //Muestra Pantalla
        private void BtnPavo_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_19_Animales());
        }

        //Muestra Pantalla
        private void BtnOsoHormiguero_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_18_Animales());
        }

        //Muestra Pantalla
        private void BtnPolar_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_20_Animales());
        }
        //Muestra Pantalla
        private void BtnCaja3_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_21_Caja());
        }
        //Muestra Pantalla
        private void BtnCaja1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_21_Caja());
        }
        //Muestra Pantalla
        private void BtnCaja2_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_21_Caja());
        }
        //Muestra Pantalla
        private void BtnCaja4_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_21_Caja());
        }

        private void BtnTaquilla_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_24_Taquilla());
        }

        private void BtnTienda_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_23_Tienda());
        }

        private void BtnForo_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_25_Foro());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_22_Restaurante());
        }


        private void BtnEmergencia_Click(object sender, EventArgs e)
        {
            MenuPrincipal.abrirPantallas(new CU_05.PA_05_27_Emergencias());
        }

        //Al apretar el botón de animales se mostrarán los nombres y
        //lugares de los animales y no se mostrarán ningún lugar 
        private void BtnAnimales_Click(object sender, EventArgs e)
        {
            btnGuacamaya.Text = "Santuario de aves (Tucanes, guacamayas y loros)";
            BtnJirafa.Text = "Jirafas";
            BtnElefante.Text = "Elefantes";
            BtnCebra.Text = "Cebras";
            BtnAguia.Text = "Aguila";
            BtnTigre.Text = "Tigres";
            BtnPinguino.Text = "Pingüinos";
            BtnFlamenco.Text = "Flamencos";
            BtnOso.Text = "Osos";
            BtnPuma.Text = "Pumas";
            BtnJaguar.Text = "Jaguares";
            BtnLeon.Text = "Leones";
            BtnOsoHormiguero.Text = "Oso \nHormiguero";
            BtnPavo.Text = "Pavo \nreal";
            BtnPolar.Text = "Oso Polar";
            BtnForo.Text = "";
            BtnTienda.Text = "";
            BtnTaquilla.Text = "";
            button1.Text = "";
            BtnCaja1.Text = "";
            BtnCaja2.Text = "";
            BtnCaja3.Text = "";
            BtnCaja4.Text = "";
        }

        //Al apretar el botón de Áreas se mostrarán los nombres y
        //lugares de las áreas y no se mostrará ningún animal 
        private void BtnLugares_Click(object sender, EventArgs e)
        {
            BtnForo.Text = "Foro Madre Naturaleza";
            BtnTienda.Text = "Tienda de regalos";
            BtnTaquilla.Text = "Taquilla";
            button1.Text = "Restaurante del zoológico";
            BtnCaja1.Text = "Caja";
            BtnCaja2.Text = "Caja";
            BtnCaja3.Text = "Caja";
            BtnCaja4.Text = "Caja";
            btnGuacamaya.Text = "";
            BtnJirafa.Text = "";
            BtnElefante.Text = "";
            BtnCebra.Text = "";
            BtnAguia.Text = "";
            BtnTigre.Text = "";
            BtnPinguino.Text = "";
            BtnFlamenco.Text = "";
            BtnOso.Text = "";
            BtnPuma.Text = "";
            BtnJaguar.Text = "";
            BtnLeon.Text = "";
            BtnOsoHormiguero.Text = "";
            BtnPavo.Text = "";
            BtnPolar.Text = "";
        }
    }
}
