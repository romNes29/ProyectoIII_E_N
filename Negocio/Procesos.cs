using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Procesos
    {
        public static bool validarAcceso(string usuario, string contrasenna)
        {
            return Connect.validaCredenciales(usuario,contrasenna);
        }
    }
}
