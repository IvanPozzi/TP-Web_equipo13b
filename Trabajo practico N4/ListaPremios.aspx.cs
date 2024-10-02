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
            Articulonegocio negocio = new Articulonegocio();
            listaArticulos = negocio.listar();

        }

        protected void repRepetidor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string IdArticulo = ((Button)sender).CommandArgument;
            Response.Redirect($"DatosParticipante.aspx?ArticuloId={IdArticulo}");
        }
    }
}