using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceZoo.CU_SinDefinir
{
    /// <summary>
    /// Pantalla para el CU_04 que no fue programado
    /// </summary>
    /// Version 1.0
    /// Fecha de creacion 03/05/21
    /// Creador Isaac Librado
    public partial class CU_04_ComprarComida : Form
    {

        int indiceFoto = 0;

        public CU_04_ComprarComida()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para salir de la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 03/05/21
        /// Creador Isaac Librado
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo para mostrar la foto anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 03/05/21
        /// Creador Isaac Librado
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            indiceFoto--;
            mostrarFoto();
        }

        /// <summary>
        /// Metodo para mostrar la foto de acuerdo al indiice
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 03/05/21
        /// Creador Isaac Librado 
        private void mostrarFoto()
        {
            switch (indiceFoto)
            {
                case 0:
                    ib_contenido.Image = Properties.Resources.CU_04_DA;
                    btnAnterior.Enabled = false;
                    break;
                case 1:
                    ib_contenido.Image = Properties.Resources.CU_04_DA_FA_01;
                    btnAnterior.Enabled = true;
                    break;
                case 2:
                    ib_contenido.Image = Properties.Resources.CU_04_DA_FA_02;
                    btnSiguiente.Enabled = true;
                    break;
                case 3:
                    ib_contenido.Image = Properties.Resources.CU_04_PANTALLAS;
                    btnSiguiente.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// Metodo para mostrar la foto siguiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Version 1.0
        /// Fecha de creacion 03/05/21
        /// Creador Isaac Librado
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indiceFoto++;
            mostrarFoto();
        }
    }
}
