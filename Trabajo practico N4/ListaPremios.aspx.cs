using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Trabajo_practico_N4
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["sesion"] == null)
            {
                Response.Redirect("VoucherForm.aspx?error=invalid");
            }

            Articulonegocio negocio = new Articulonegocio();
            listaArticulos = negocio.listar();

            if (!IsPostBack)
            {
                repRepetidor.DataSource = listaArticulos;
                repRepetidor.DataBind();
            }

        }

        protected void repRepetidor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string IdArticulo = ((Button)sender).CommandArgument;
            Session["ArticuloId"] = IdArticulo;
            Response.Redirect($"DatosParticipante.aspx");
        }
    }
}