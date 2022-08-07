using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Clientes
    {
        //Customer attributes
        private String cedula;
        private String nombre;
        private String apellido1;
        private String apellido2;
        private String direccion;
        private int telefono;
        private String email;

        //Builder packed with clients
        public Clientes(String pCedula, String pNombre, String pApellido1, String pApellido2, String pDireccion, int pTelefono, String pEmail)
        {
            this.cedula = pCedula;
            this.nombre = pNombre;
            this.apellido1 = pApellido1;
            this.apellido2 = pApellido2;
            this.direccion = pDireccion;
            this.telefono = pTelefono;
            this.email = pEmail;
        }

        //empty builder
        public Clientes()
        {

        }

        //get/set
        public String Cedula
        {
            set { this.cedula = value; }
            get { return this.cedula; }
        }

        public String Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public String Apellido1
        {
            set { this.apellido1 = value; }
            get { return this.apellido1; }
        }

        public String Apellido2
        {
            set { this.apellido2 = value; }
            get { return this.apellido2; }
        }

        public String Direccion
        {
            set { this.direccion = value; }
            get { return this.direccion; }
        }

        public int Telefono
        {
            set { this.telefono = value; }
            get { return this.telefono; }
        }

        public String Email
        {
            set { this.email = value; }
            get { return this.email; }
        }


    }
}
