using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        private AccesoDatos accesoDatos;

        public ClienteNegocio()
        {
            accesoDatos = new AccesoDatos();
        }

        
        public Cliente ObtenerClientePorDNI(string documento)
        {
            if (string.IsNullOrWhiteSpace(documento))
            {
                throw new ArgumentException("El documento no puede estar vacío.");
            }

            string consulta = "SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP FROM Clientes WHERE Documento = @Documento";
            accesoDatos.setearConsulta(consulta);
            accesoDatos.setearParametro("@Documento", documento);
            SqlDataReader lector = null;
            Cliente c = null;

            try
            {
                accesoDatos.ejecutarLectura();
                lector = accesoDatos.Lector;

                if (lector.Read())
                {
                    c = new Cliente
                    {
                        Id = (int)lector["Id"],
                        Documento = lector["Documento"].ToString(),
                        Nombre = lector["Nombre"].ToString(),
                        Apellido = lector["Apellido"].ToString(),
                        Email = lector["Email"].ToString(),
                        Direccion = lector["Direccion"].ToString(),
                        Ciudad = lector["Ciudad"].ToString(),
                        CP = (int)lector["CP"]
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente: " + ex.Message);
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

            return c; 
        }
        public void AgregarCliente(Cliente nuevoCliente)
        {
          
            if (nuevoCliente == null)
            {
                throw new ArgumentNullException("El cliente no puede ser nulo.");
            }

           
            string consulta = "INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
                              "VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)";

            accesoDatos.setearConsulta(consulta);
            accesoDatos.setearParametro("@Documento", nuevoCliente.Documento);
            accesoDatos.setearParametro("@Nombre", nuevoCliente.Nombre);
            accesoDatos.setearParametro("@Apellido", nuevoCliente.Apellido);
            accesoDatos.setearParametro("@Email", nuevoCliente.Email);
            accesoDatos.setearParametro("@Direccion", nuevoCliente.Direccion);
            accesoDatos.setearParametro("@Ciudad", nuevoCliente.Ciudad);
            accesoDatos.setearParametro("@CP", nuevoCliente.CP);

            try
            {
                accesoDatos.ejecutarAccion(); // Ejecuta la acción de inserción
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message);
            }
            finally
            {
                accesoDatos.cerrarConexion(); // Asegurarse de cerrar la conexión
            }
        }
    }
}