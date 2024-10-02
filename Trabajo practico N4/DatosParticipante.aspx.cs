using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using Dominio;
using Negocio;
using System.Text.RegularExpressions;

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
                Cliente cliente = clienteNegocio.ObtenerClientePorDNI(dni);


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

        protected void Btnparticipar_Click(object sender, EventArgs e)
        {
            
            LabelErrorDNI.Visible = false;
            Labelerrornombre.Visible = false;

            // Validaciones para dni:
            if (string.IsNullOrEmpty(TexboxDNI.Text.Trim()))
            {
                LabelErrorDNI.Text = "El DNI no puede estar vacío.";
                LabelErrorDNI.Visible = true;
                return; 
            }

            
            if (!int.TryParse(TexboxDNI.Text.Trim(), out int dni) || dni < 1)
            {
                LabelErrorDNI.Text = "El DNI debe ser un número positivo.";
                LabelErrorDNI.Visible = true;
                return; 
            }

            
            if (dni < 1000000 || dni > 99999999) 
            {
                LabelErrorDNI.Text = "El número de DNI es inválido.";
                LabelErrorDNI.Visible = true;
                return; 
            }

            // Validaciones para nombre:
            if (string.IsNullOrEmpty(TextBoxnombre.Text.Trim()))
            {
                Labelerrornombre.Text = "El nombre no puede estar vacío.";
                Labelerrornombre.Visible = true;
                return; 
            }

            
            string pattern = @"^[a-zA-ZáéíóúÁÉÍÓÚ\s]+$";
            if (!Regex.IsMatch(TextBoxnombre.Text.Trim(), pattern))
            {
                Labelerrornombre.Text = "El nombre solo puede contener letras y espacios.";
                Labelerrornombre.Visible = true;
                return;
            }



            LabelErrorDNI.Visible = false;
            Labelerrornombre.Visible = false;




            Cliente cliente = new Cliente();

            cliente.Documento = TexboxDNI.Text;
            cliente.Nombre = TextBoxnombre.Text;
            cliente.Apellido = TextBoxapellido.Text;
            cliente.Email = TextBoxemail.Text;
            cliente.Direccion = TextBoxdireccion.Text;  
            cliente.Ciudad = TextBoxciudad.Text;
            cliente.CP = int.Parse(TextBoxcp.Text);

            ClienteNegocio clienteNegocio = new ClienteNegocio();

            clienteNegocio.AgregarCliente(cliente);
        }
    }
}