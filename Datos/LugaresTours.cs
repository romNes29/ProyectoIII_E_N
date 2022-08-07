using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LugaresTours
    {
        private String nombre;
        private String direccion;
        private String descripccion;

        public LugaresTours(String pNombre, String pDireccion, String pDescripcion)
        {
            this.nombre = pNombre;
            this.direccion = pDireccion;
            this.descripccion = pDescripcion;
        }

        public LugaresTours()
        {

        }

        public String Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public String Direccion
        {
            set { this.direccion = value; }
            get { return this.direccion; }
        }

        public String Descripccion
        {
            set { this.descripccion = value; }
            get { return this.descripccion; }
        }

    }
}
