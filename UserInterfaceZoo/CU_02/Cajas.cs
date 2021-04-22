using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceZoo
{
    /// <summary>
    /// Esta clase define las propiedades de las cajas de venta de boletos y souvenirs
    /// </summary>
    /// Version 1.0
    /// Fecha de creacion 29 de Marzo 2021
    /// Creador David Hernandez, Karla Garcia, Arturo Villegas

    [Serializable]
    public class Cajas
    {
        int idCajas;
        int idCajero;
        double montoApertura;
        double montoCierre; 
        bool rdbBoleto;
        bool rsbSouvenir;
        double ganancias;
        double faltSobra;
        bool cerrar; 

        public double MontoApertura { get => montoApertura; set => montoApertura = value; }
        public double MontoCierre { get => montoCierre; set => montoCierre = value; }
        public int IdCajas { get => idCajas; set => idCajas = value; }
        public int IdCajero { get => idCajero; set => idCajero = value; }
        public bool RdbBoleto { get => rdbBoleto; set => rdbBoleto = value; }
        public bool RsbSouvenir { get => rsbSouvenir; set => rsbSouvenir = value; }
        public double Ganancias { get => ganancias; set => ganancias = value; }
        public double FaltSobra { get => faltSobra; set => faltSobra = value; }
        public bool Cerrar { get => cerrar; set => cerrar = value; }

        /// <summary>
        /// Constructor vacio a disponibilidad
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public Cajas()
        {

        }

        /// <summary>
        /// Constructor que asigna las propiedades de la caja
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 29 de Marzo 2021
        /// Creador David Hernandez, Karla Garcia, Arturo Villegas
        public Cajas(int idC, int idCj, double montAp, double montCierr, bool rBol, bool rSouv, double gan, double fs)
        {
            idCajas = idC;
            idCajero = idCj;
            montoApertura = montAp;
            montoCierre = montCierr;
            rdbBoleto = rBol;
            rsbSouvenir = rSouv;
            ganancias = gan;
            faltSobra = fs; 
        }
    }
}
