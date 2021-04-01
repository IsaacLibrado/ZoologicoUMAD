using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceZoo
{
    /// <summary>
    /// Evento que se realizar al presionar el boton abrir cajas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// Version 1.0
    /// Fecha de creacion 30 de Marzo 2021
    /// Creador Karla Garcia
    
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

        public double MontoApertura { get => montoApertura; set => montoApertura = value; }
        public double MontoCierre { get => montoCierre; set => montoCierre = value; }
        public int IdCajas { get => idCajas; set => idCajas = value; }
        public int IdCajero { get => idCajero; set => idCajero = value; }
        public bool RdbBoleto { get => rdbBoleto; set => rdbBoleto = value; }
        public bool RsbSouvenir { get => rsbSouvenir; set => rsbSouvenir = value; }
        public double Ganancias { get => ganancias; set => ganancias = value; }
        public double FaltSobra { get => faltSobra; set => faltSobra = value; }

        public Cajas()
        {

        }

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
