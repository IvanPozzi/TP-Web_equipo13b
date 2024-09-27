using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Trabajo_practico_N4
{
    public class AcsesoDatos
    {
        public class AccesoDatos
        {
            private SqlConnection conexion;
            private SqlCommand comando;
            private SqlDataReader lector;

            public SqlDataReader Lector
            {
                get { return lector; }
            }

            // Se crea la conexión a la base de datos PROMOS_DB en el constructor
            public AccesoDatos()
            {
                conexion = new SqlConnection("server=.\\SQLEXPRESS; database=PROMOS_DB; integrated security=true");
                comando = new SqlCommand();
            }

            // Recibe la consulta SQL
            public void setearConsulta(string consulta)
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }

            // Método para agregar parámetros a la consulta SQL
            public void setearParametro(string nombre, object valor)
            {
                comando.Parameters.AddWithValue(nombre, valor);
            }

            // Ejecuta la consulta SQL y guarda el resultado en el lector
            public void ejecutarLectura()
            {
                comando.Connection = conexion;
                try
                {
                    conexion.Open();
                    lector = comando.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            // Ejecuta una acción en la base de datos (INSERT, UPDATE, DELETE)
            public void ejecutarAccion()
            {
                comando.Connection = conexion;
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            // Cierra la conexión a la base de datos
            public void cerrarConexion()
            {
                if (lector != null)
                {
                    lector.Close();
                }
                conexion.Close();
            }
        }
    }
}