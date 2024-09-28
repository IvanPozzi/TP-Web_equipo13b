using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_practico_N4
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnsiguiente_Click(object sender, EventArgs e)
        {
            // Obtén el código del voucher del TextBox
            string codigoVoucher = Texcodigovoucher.Text.Trim();

            try
            {
                // Crea una instancia de la clase VoucherNegocio
                VoucherNegocio voucherNegocio = new VoucherNegocio();

                // Llama al método para obtener el voucher
                voucher v = voucherNegocio.ObtenerVoucherPorCodigo(codigoVoucher);

                if (v != null && v.FechaCanje == null)
                {
                    Response.Redirect("Datosdelparticipante.aspx");
                }
                else if (v.FechaCanje != null)
                {
                    lblResultado.Text = "El voucher ya fue utilizado el " + v.FechaCanje.Value.ToShortDateString();
                    lblResultado.ForeColor = System.Drawing.Color.White;
                }
          
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error voucher no válido.";
                lblResultado.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}