using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using static Trabajo_practico_N4.AcsesoDatos;

namespace Trabajo_practico_N4
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TexDocumento_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TexboxDNI.Text))
            {
                string dni = TexboxDNI.Text;

                ClienteNegocio clienteNegocio = new ClienteNegocio();
                cliente cliente = clienteNegocio.ObtenerClientePorDNI(dni);


                if (cliente != null)
                {

                    TextBoxnombre.Text = cliente.Nombre;
                    TextBoxapellido.Text = cliente.Apellido;
                    TextBoxemail.Text = cliente.Email;
                    TextBoxdireccion.Text = cliente.Direccion;
                    TextBoxciudad.Text = cliente.Ciudad;
                    TextBoxcp.Text = cliente.CP.ToString();
                }
                else
                {
                    LimpiarCampos();
                } 

            }
            else
            {
                
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            TextBoxnombre.Text = string.Empty;
            TextBoxapellido.Text = string.Empty;
            TextBoxemail.Text = string.Empty;
            TextBoxdireccion.Text = string.Empty;
            TextBoxciudad.Text = string.Empty;
            TextBoxcp.Text = string.Empty;
        }
     
    }
}