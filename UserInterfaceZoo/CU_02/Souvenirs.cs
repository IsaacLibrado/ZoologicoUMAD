using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceZoo
{
    [Serializable]
    public class Souvenirs
    {
        int codigo;
        //int folio; 
        string descripcion;
        double precio;
        //int cantidad;
        //double total;

        public Souvenirs()
        {

        }

        public Souvenirs(int cod, string desc, double pre)
            //int cant, double t, int f
        {
            codigo = cod;
            descripcion = desc;
            precio = pre;
            //cantidad = cant;
            //total = t;
            //folio = f; 
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        //public int Cantidad { get => cantidad; set => cantidad = value; }
        //public double Total { get => total; set => total = value; }
        //public int Folio { get => folio; set => folio = value; }
    }
}
