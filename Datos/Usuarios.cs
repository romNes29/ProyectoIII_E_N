using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuarios
    {
        //user attributes
        private String usuario;
        private String contrasena;
        private String tipoUsuario;


        //full builder
        public Usuarios(string pUsuario, string pContrasena, string pTipoUsuario)
        {
            this.usuario = pUsuario;
            this.contrasena = pContrasena;
            this.tipoUsuario = pTipoUsuario;
        }

        //empty builder
        public Usuarios()
        {

        }

        //Get-Set
        public String Usuario
        {
            set { this.usuario = value; }
            get { return this.usuario; }
        }

        public String Contrasena
        {
            set { this.contrasena = value; }
            get { return this.contrasena; }
        }

        public String TipoUsuario
        {
            set { this.tipoUsuario = value; }
            get { return this.tipoUsuario; }
        }
    }
}
