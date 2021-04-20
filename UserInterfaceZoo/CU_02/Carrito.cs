using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceZoo
{
    [Serializable]
    public class Carrito
    {
        /// <summary>
        /// Esta clase define las propiedades del carrito de ventas
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        int codigo;
        int folio;
        string descripcion;
        double precio;
        int cantidad;
        double total;

        /// <summary>
        /// Constructor vacio a disponibilidad
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public Carrito()
        {

        }

        /// <summary>
        /// Constructor que asigna las propiedades del carrito
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public Carrito(int cod, string desc, double pre, int cant, double t, int f)
        {
            codigo = cod;
            descripcion = desc;
            precio = pre;
            cantidad = cant;
            total = t;
            folio = f;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Total { get => total; set => total = value; }
        public int Folio { get => folio; set => folio = value; }
    }

}

