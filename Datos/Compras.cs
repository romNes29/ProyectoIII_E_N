using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Compras
    {

        //shopping attributes
        private String fechaCompra;
        private float precioTotal;

        //constructor lleno
        public Compras(String pFechaCompra, float pPrecioTotal)
        {
            this.fechaCompra = pFechaCompra;
            this.precioTotal = pPrecioTotal;
        }

        //constructor vacio
        public Compras()
        {

        }

        //gets/sets
        public String FechaCompra
        {
            set { this.fechaCompra = value; }
            get { return this.fechaCompra; }
        }

        public float PrecioTotal
        {
            set { this.precioTotal = value; }
            get { return this.precioTotal; }
        }
    }
}
