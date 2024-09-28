using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using static Trabajo_practico_N4.AcsesoDatos;



namespace Trabajo_practico_N4
{
    public class VoucherNegocio
    {
        private AccesoDatos accesoDatos; 

        public VoucherNegocio()
        {
            accesoDatos = new AccesoDatos(); 
        }

        
        public voucher ObtenerVoucherPorCodigo(string codigoVoucher)
        {
            
            if (string.IsNullOrWhiteSpace(codigoVoucher))
            {
                throw new ArgumentException("El código del voucher no puede estar vacío.");
            }

            
            string consulta = "SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers WHERE CodigoVoucher = @CodigoVoucher";

            accesoDatos.setearConsulta(consulta);
            accesoDatos.setearParametro("@CodigoVoucher", codigoVoucher);
            SqlDataReader lector = null;
            voucher v = null;

            try
            {
                accesoDatos.ejecutarLectura();
                lector = accesoDatos.Lector;

                
                if (lector.Read())
                {
                    v = new voucher
                    {
                        CodigoVoucher = lector["CodigoVoucher"].ToString(),
                        IdCliente = lector["IdCliente"] as int?,
                        FechaCanje = lector["FechaCanje"] as DateTime?,
                        IdArticulo = lector["IdArticulo"] as int?
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el voucher: " + ex.Message);
            }
            finally
            {
                accesoDatos.cerrarConexion(); 
            }

            
            return v;
        }
    }
}