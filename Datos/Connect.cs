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
        static NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=EMPRESA; User Id=fundamentos; Password=choco29;");
        
        //Method that connects the database to the application
        public static void conectarBaseDatos()
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

        //Method that disconnects the database from the application
        public static void desconectarBaseDatos()
        {
            conn.Close();
        }


        //Method validates that the user exists
        public static (bool,string) validaCredenciales(string usuario, string contrasenna)
        {
            bool permitirAcceso = false;
            string puesto = "";
            try{ 
                DataTable tabla = new DataTable();
                string query = "SELECT usuario, contrasena, tipo_usuario FROM \"usuarios\" WHERE \"usuario\" = \'" + usuario + "\' AND PGP_SYM_DECRYPT(contrasena::bytea, 'AES_KEY') = \'" + contrasenna + "\' ;";
                NpgsqlCommand conector = new NpgsqlCommand(query,conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                datos.Fill(tabla);
                if(tabla.Rows.Count == 1)
                {
                    permitirAcceso = true;
                    puesto = tabla.Rows[0]["tipo_usuario"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: "+e.ToString());
            }
            return (permitirAcceso,puesto);
        }

        public static DataTable consultarUnDato(String query)
        {
            try
            {
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable table = new DataTable();
                datos.Fill(table);
                desconectarBaseDatos();
                return table;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
