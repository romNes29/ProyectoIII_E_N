using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Factura
    {
        //invoice attributes
        private int numeroFactura;
        private String metodoPago;

        //full builder
        public Factura(int pNumeroFactura, String pMetodoPago)
        {
            this.numeroFactura = pNumeroFactura;
            this.metodoPago = pMetodoPago;
        }


        //constructor vacio
        public Factura()
        {

        }

        //gets/set
        public int NumeroFactura
        {
            set { this.numeroFactura = value; }
            get { return this.numeroFactura; }
        }

        public String MetodoPago
        {
            set { this.metodoPago = value; }
            get { return this.metodoPago; }
        }
    }
}
