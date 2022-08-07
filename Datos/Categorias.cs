using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Categorias
    {
        //category attributes
        private String nombre;
        private String descripcion;

        //full builder
        public Categorias(String pNombre, String pDescripcion)
        {
            this.nombre = pNombre;
            this.descripcion = pDescripcion;
        }

        //constructor vacio
        public Categorias()
        {

        }

        //gets/sets
        public String Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public String Descripcion
        {
            set { this.descripcion = value; }
            get { return this.descripcion; }
        }
    }
}
