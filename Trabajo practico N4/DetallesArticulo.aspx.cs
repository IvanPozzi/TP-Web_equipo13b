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
    public partial class DetallesArticulo : System.Web.UI.Page
    {
        public Articulo articulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            articulo = new Articulo();
            Articulonegocio negocio = new Articulonegocio();

            try
            {
                if (Request.QueryString["Id"] != null)
                {
                    int id = int.Parse(Request.QueryString["Id"]);
                    articulo = negocio.buscarPorId(id);

                    lblCodigo.Text = articulo.Codigo.ToString();
                    lblNombre.Text = articulo.Nombre.ToString();
                    lblMarca.Text = articulo.Marca.ToString();
                    lblCategoria.Text = articulo.Categoria.ToString();
                    lblDescripcion.Text = articulo.Descripcion.ToString();
                    lblPrecio.Text = articulo.Precio.ToString();
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}