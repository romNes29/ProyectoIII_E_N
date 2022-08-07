using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Tours
    {
        //toures attributes
        private String nombreTours;
        private String descripccion;
        private String estado;
        private int cantidadEspacios;
        private float precio;
        private String duracionTours;

        //full builder
        public Tours(string pNombreTours, string pDescripccion, string pEstado, int pCantidadEspacios, float pPrecio, string pDuracionTours)
        {
            this.nombreTours = pNombreTours;
            this.descripccion = pDescripccion;
            this.estado = pEstado;
            this.cantidadEspacios = pCantidadEspacios;
            this.precio = pPrecio;
            this.duracionTours = pDuracionTours;
        }

        // empty builder
        public Tours()
        {

        }

        //Gets-Sets
        public String NombreTours
        {
            set { this.nombreTours = value; }
            get { return this.nombreTours; }
        }

        public String Descripccion
        {
            set { this.descripccion = value; }
            get { return this.descripccion; }
        }
        public String Estado
        {
            set { this.estado = value; }
            get { return this.estado; }
        }

        public int CantidadEspacios
        {
            set { this.cantidadEspacios = value; }
            get { return this.cantidadEspacios; }
        }
        public float Precio
        {
            set { this.precio = value; }
            get { return this.precio; }
        }

        public String DuracionTours
        {
            set { this.duracionTours = value; }
            get { return this.duracionTours; }
        }


    }
}
