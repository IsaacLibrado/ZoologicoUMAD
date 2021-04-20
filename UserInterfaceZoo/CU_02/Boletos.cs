using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceZoo
{
    [Serializable]
    public class Boletos
    {
        /// <summary>
        /// Esta clase define las propiedades de los boletos de entrada
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        int folio; 
        int boletosAdultos;
        int boletosNinios;
        int boletosAdultosMayores;
        int idCaja;
        bool tarjeta;
        bool efectivo;
        double total;
        bool pago; 


        public int BoletosAdultos { get => boletosAdultos; set => boletosAdultos = value; }
        public int BoletosNinios { get => boletosNinios; set => boletosNinios = value; }
        public int BoletosAdultosMayores { get => boletosAdultosMayores; set => boletosAdultosMayores = value; }
        public int IdCaja { get => idCaja; set => idCaja = value; }
        public bool Tarjeta { get => tarjeta; set => tarjeta = value; }
        public bool Efectivo { get => efectivo; set => efectivo = value; }
        public double Total { get => total; set => total = value; }
        public int Folio { get => folio; set => folio = value; }
        public bool Pago { get => pago; set => pago = value; }

        /// <summary>
        /// Constructor vacio a disponibilidad
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public Boletos()
        {

        }
        /// <summary>
        /// Constructor adaptado para la asignación automatica de las propiedades del boleto
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public Boletos(int f, int adultos, int ninios, int adultosMayores, int idC, bool tarj, bool efec, double tl)
        {
            folio = f; 
            boletosAdultos = adultos;
            boletosNinios = ninios;
            boletosAdultosMayores = adultosMayores;
            idCaja = idC;
            tarjeta = tarj;
            efectivo = efec;
            total = tl; 
        }
    }
}
