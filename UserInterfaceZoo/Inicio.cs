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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para mostrar la pantalla después de hacer login
        /// </summary>
        /// <param name="pUserName">El username que hizo login</param>
        /// Version 1.0
        /// Fecha de creacion 20/03/21
        /// Creador Isaac Librado
        public Inicio(string pUserName)
        {
            InitializeComponent();
            MenuPrincipal.ValidarLogIn(true,pUserName);
        }
    }
}
