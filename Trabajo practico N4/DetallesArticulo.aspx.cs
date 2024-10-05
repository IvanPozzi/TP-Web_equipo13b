using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Microsoft.Ajax.Utilities;
using Negocio;

namespace Trabajo_practico_N4
{
    public partial class DetallesArticulo : System.Web.UI.Page
    {
        public Articulo articulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["sesion"] == null)
            {
                Response.Redirect("VoucherForm.aspx?error=invalid");
            }

            try
            {
                if (Request.QueryString["Id"] != null)
                {
                    articulo = new Articulo();
                    Articulonegocio negocio = new Articulonegocio();

                    int id = int.Parse(Request.QueryString["Id"]);
                    articulo = negocio.buscarPorId(id);

                    lblCodigo.Text = articulo.Codigo.ToString();
                    lblNombre.Text = articulo.Nombre.ToString();
                    lblMarca.Text = articulo.Marca.ToString();
                    lblCategoria.Text = articulo.Categoria.ToString();
                    lblDescripcion.Text = articulo.Descripcion.ToString();
                    lblPrecio.Text = articulo.Precio.ToString();

                }
                else
                {
                    Response.Redirect("VoucherForm.aspx?error=invalid");
                }
 
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Add("ArticuloId", articulo.Id);
                Response.Redirect($"DatosParticipante.aspx");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}