using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dominio;



namespace Negocio
{
    public class VoucherNegocio
    {
        private AccesoDatos accesoDatos; 

        public VoucherNegocio()
        {
            accesoDatos = new AccesoDatos(); 
        }

        
        public Voucher ObtenerVoucherPorCodigo(string codigoVoucher)
        {
            
            if (string.IsNullOrWhiteSpace(codigoVoucher))
            {
                throw new ArgumentException("El código del voucher no puede estar vacío.");
            }

            
            string consulta = "SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers WHERE CodigoVoucher = @CodigoVoucher";

            accesoDatos.setearConsulta(consulta);
            accesoDatos.setearParametro("@CodigoVoucher", codigoVoucher);
            //SqlDataReader lector = null;
            Voucher v = null;

            try
            {
                accesoDatos.ejecutarLectura();
                //accesoDatos = accesoDatos.Lector;

                
                if (accesoDatos.Lector.Read())
                {
                    v = new Voucher
                    {
                        CodigoVoucher = accesoDatos.Lector["CodigoVoucher"].ToString(),
                        IdCliente = accesoDatos.Lector["IdCliente"] as int?,
                        FechaCanje = accesoDatos.Lector["FechaCanje"] as DateTime?,
                        IdArticulo = accesoDatos.Lector["IdArticulo"] as int?
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