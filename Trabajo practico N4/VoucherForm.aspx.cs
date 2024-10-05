using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Trabajo_practico_N4
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnsiguiente_Click(object sender, EventArgs e)
        {
            
            string codigoVoucher = Texcodigovoucher.Text.Trim();

            try
            {
              
                VoucherNegocio voucherNegocio = new VoucherNegocio();

              
                Voucher v = voucherNegocio.ObtenerVoucherPorCodigo(codigoVoucher);

                if (v != null && v.FechaCanje == null)
                {
                    Session["sesion"] = true;
                    Session["Voucher"] = v.CodigoVoucher;

                    Response.Redirect("ListaPremios.aspx");
                }
                else if (v != null)
                {
                    lblResultado.Text = "El voucher ya fue utilizado el " + v.FechaCanje.Value.ToShortDateString();
                    lblResultado.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblResultado.Text = "Error voucher no válido.";
                    lblResultado.ForeColor = System.Drawing.Color.Red;
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