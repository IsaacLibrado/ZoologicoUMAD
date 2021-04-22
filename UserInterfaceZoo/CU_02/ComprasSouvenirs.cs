using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceZoo
{
    [Serializable]
    public class ComprasSouvenirs
    {
        /// <summary>
        /// Esta clase define las propiedades de los souvenirs
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        string archivo;
        double total;
        int idCaja;
        bool tarjeta;
        bool efectivo;
        bool mebresia;
        bool pago;
        /// <summary>
        /// Constructor vacio a disponibilidad
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public ComprasSouvenirs()
        {

        }

        /// <summary>
        /// Constructor que asigna las propiedades de la compra de los souvenirs
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public ComprasSouvenirs(string arch, double t, int id, bool tar, bool efec, bool mem)
        {
            total = t;
            archivo = arch;
            idCaja = id;
            tarjeta = tar;
            efectivo = efec;
            mebresia = mem; 
        }

        public string Archivo { get => archivo; set => archivo = value; }
        public double Total { get => total; set => total = value; }
        public int IdCaja { get => idCaja; set => idCaja = value; }
        public bool Tarjeta { get => tarjeta; set => tarjeta = value; }
        public bool Efectivo { get => efectivo; set => efectivo = value; }
        public bool Mebresia { get => mebresia; set => mebresia = value; }
        public bool Pago { get => pago; set => pago = value; }
    }
}
