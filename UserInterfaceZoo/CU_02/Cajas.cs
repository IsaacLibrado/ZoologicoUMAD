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
    class Cajas
    {
        int idCajas;
        int idCajero;
        double montoApertura;
        double montoCierre;
        double montoTotal;
        bool rdbBoleto;
        bool rsbSouvenir;
        //Instancias sigleton de cajas
        private static Cajas caja1;
        private static Cajas caja2;
        private static Cajas caja3;

        public double MontoApertura { get => montoApertura; set => montoApertura = value; }
        public double MontoCierre { get => montoCierre; set => montoCierre = value; }
        public int IdCajas { get => idCajas; set => idCajas = value; }
        public int IdCajero { get => idCajero; set => idCajero = value; }
        public bool RdbBoleto { get => rdbBoleto; set => rdbBoleto = value; }
        public bool RsbSouvenir { get => rsbSouvenir; set => rsbSouvenir = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }

        //Constructor privado para el suo de singleton
        private Cajas()
        {

        }

        //¿Borrar?
        public Cajas(int idC, int idCj, double montAp, double montCierr, bool rBol, bool rSouv)
        {
            idCajas = idC;
            idCajero = idCj;
            montoApertura = montAp;
            montoCierre = montCierr;
            rdbBoleto = rBol;
            rsbSouvenir = rSouv;
        }

        /// <summary>
        /// Metodo para obtener la instancia unica de la caja 1
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 31/03/2021
        /// Creador Arturo Villegas
        public static Cajas ObtenInstancia1()
        {
            if (caja1 == null)
            {
                caja1 = new Cajas();
                caja1.idCajas = 1;
            }
            return caja1;
        }

        /// <summary>
        /// Metodo para obtener la instancia unica de la caja 2
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 31/03/2021
        /// Creador Arturo Villegas
        public static Cajas ObtenInstancia2()
        {
            //Autor: Villegas Rojas Oscar Arturo
            //Fecha: 25/11/2020
            //Versión: 1.0
            //Modificación: 25/11/2020
            //Uso de singleton
            if (caja2 == null)
            {
                caja2 = new Cajas();
                caja2.idCajas = 2;
            }
            return caja1;
        }

        /// <summary>
        /// Metodo para obtener la instancia unica de la caja 3
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 31/03/2021
        /// Creador Arturo Villegas
        public static Cajas ObtenInstancia3()
        {
            //Autor: Villegas Rojas Oscar Arturo
            //Fecha: 25/11/2020
            //Versión: 1.0
            //Modificación: 25/11/2020
            //Uso de singleton
            if (caja3 == null)
            {
                caja3 = new Cajas();
                caja3.idCajas = 3;
            }
            return caja1;
        }

        /// <summary>
        /// Permite realizar una venta desde una caja especifica
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 31/03/2021
        /// Creador Arturo Villegas
        public static void SumaVenta(int idCaja, double pMonto)
        {
            //Autor: Villegas Rojas Oscar Arturo
            //Fecha: 25/11/2020
            //Versión: 1.0
            //Modificación: 25/11/2020
            //Uso de singleton
            if(idCaja == 1)
                caja1.montoTotal += pMonto;
            if (idCaja == 2)
                caja2.montoTotal += pMonto;
            if (idCaja == 3)
                caja3.montoTotal += pMonto;
        }

        /// <summary>
        /// Permite la apertura de una caja especifica
        /// </summary>
        /// Version 1.0
        /// Fecha de creacion 31/03/2021
        /// Creador Arturo Villegas
        public static void AsignarApertura(int idCaja, double pMonto)
        {
            //Autor: Villegas Rojas Oscar Arturo
            //Fecha: 25/11/2020
            //Versión: 1.0
            //Modificación: 25/11/2020
            //Uso de singleton
            if (idCaja == 1)
            {
                ObtenInstancia1();
                caja1.montoApertura = pMonto;
            }
            if (idCaja == 2)
            {
                ObtenInstancia2();
                caja2.montoApertura = pMonto;
            }
            if (idCaja == 3)
            {
                ObtenInstancia3();
                caja3.montoApertura = pMonto;
            }
        }
    }
}
