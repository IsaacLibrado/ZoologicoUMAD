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
        string archivo;
        double total;
        int idCaja;
        bool tarjeta;
        bool efectivo;
        bool mebresia;
        bool pago; 
        public ComprasSouvenirs()
        {

        }

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
