using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Procesos
    {
        public static (bool, string) validarAcceso(string usuario, string contrasenna)
        {
            return Connect.validaCredenciales(usuario, contrasenna);
        }

        //method that is responsible for visualizing any table that is sent by parameters
        public  DataTable consultarTodosElementos(String table, String[] datos)
        {
            String campo = "SELECT ";

            for (int i = 0; i < datos.Length; i++)
            {
                campo += "\"" + datos[i] + "\"";
                if (i != datos.Length - 1)
                {
                    campo += ",";
                }
            }
            campo += " FROM \"" + table + "\"";
            String query = campo;
            DataTable resultado = Connect.consultarUnDato(query);
            return resultado;
        }

        //method that is responsible for inserting any record that is sent by parameters
        public void insertarTodosElementos(String Tabla, String[] datosInsertar, String[] datosBaseDatos)
        {
            try
            {
                String query = "INSERT INTO \"" + Tabla + "\" (";

                for (int i = 0; i < datosBaseDatos.Length; i++)
                {
                    query += "\"" + datosBaseDatos[i] + "\"";
                    if (i != datosBaseDatos.Length - 1)
                    {
                        query += ") VALUES (";
                    }
                    else
                    {
                        query += ",";
                    }

                }
                for (int j = 0; j < datosInsertar.Length; j++)
                {
                    query += "\"" + datosInsertar[j] + "\"";
                    if (j != datosInsertar.Length - 1)
                    {
                        query += ",";
                    }
                    else
                    {
                        query += ");";
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //method that is responsible for deleting any record that is sent by parameters
        public static void eliminarTodosElementos(String registroEliminar, String tabla, String columna)
        {
            try
            {
                String eliminar = "delete from '" + tabla + "' where '" + columna + "' = '" + registroEliminar + "'";
                Connect.conectarBaseDatos();
                NpgsqlCommand comando = new NpgsqlCommand(eliminar, Connect.conn);
                comando.ExecuteNonQuery();
                Connect.desconectarBaseDatos();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //method that modifies any record of any table
        public void ModificarTodosElementos(String Tabla, String[] datosInsertar, String[] datosBaseDatos)
        {
            try
            {
                String query = "UPDATE  \"" + Tabla + "\" SET ";

                for (int i = 0; i < datosBaseDatos.Length; i++)
                {
                    query += "\"" + datosBaseDatos[i] + "\" = \"" + datosInsertar[i] + "\"";
                    if (i != datosBaseDatos.Length - 1)
                    {
                        query += ",";
                    }
                    else
                    {
                        query += ";";
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
