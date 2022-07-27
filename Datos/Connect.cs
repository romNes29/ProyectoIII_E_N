using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Datos
{
    public class Connect
    {
        static NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=usuarios; User Id=fundamentos; Password=choco29;");

        public void conectarBaseDatos()
        {
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error conectando a base de datos."+e.ToString());
            }
            
        }
        public void desconectarBaseDatos()
        {
            conn.Close();
        }

        public static bool validaCredenciales(string usuario, string contrasenna)
        {
            bool permitirAcceso = false;
            DataTable tabla = new DataTable();
            string query = "SELECT nombre, contrasenna FROM \"usuarios_login\" WHERE \"nombre\" = \'" + usuario + "\' AND PGP_SYM_DECRYPT(contrasenna::bytea, 'AES_KEY') = \'" + contrasenna + "\' ;";
            NpgsqlCommand conector = new NpgsqlCommand(query,conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            datos.Fill(tabla);
            if(tabla.Rows.Count == 1)
            {
                permitirAcceso = true;
            }

            return permitirAcceso;
            
        }
    }
}
