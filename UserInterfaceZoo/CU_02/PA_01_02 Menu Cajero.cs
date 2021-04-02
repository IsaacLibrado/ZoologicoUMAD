﻿using System;
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
    public partial class PA_01_02_Menu_Cajero : Form
    {
        public PA_01_02_Menu_Cajero()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
            MenuPrincipal.AsignarTitulo("Vender boletos de entrada");
        }

        private void btnEspectaculo_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_01_Vender_Boletos_Entrada());
            MenuPrincipal.AsignarTitulo("Vender boletos de espectáculo");
        }

        private void btnSouvenirs_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_02_05_Souvenirs());
            MenuPrincipal.AsignarTitulo("Vender souvenir");
        }
    }
}
