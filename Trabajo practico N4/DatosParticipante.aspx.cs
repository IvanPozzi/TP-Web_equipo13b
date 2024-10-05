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
        public Cliente cliente { get; set; }
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sesion"] == null)
            {
                Response.Redirect("VoucherForm.aspx?error=invalid");
            }

        }
        protected void TexDocumento_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TexboxDNI.Text))
            {
                string dni = TexboxDNI.Text;

                ClienteNegocio clienteNegocio = new ClienteNegocio();
                cliente = clienteNegocio.ObtenerClientePorDNI(dni);
                Session.Add("Cliente", cliente);


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
            LabelErrorEmail.Visible = false;
            Labelerrorapellido.Visible = false;
            LabelErrorDireccion.Visible = false;

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
            // Validaciones para apellido:
            if (string.IsNullOrEmpty(TextBoxapellido.Text.Trim()))
            {
                Labelerrorapellido.Text = "El apellido no puede estar vacío.";
                Labelerrorapellido.Visible = true;
                return;
            }
            if (!Regex.IsMatch(TextBoxapellido.Text.Trim(), pattern))
            {
                Labelerrorapellido.Text = "El apellido solo puede contener letras y espacios.";
                Labelerrorapellido.Visible = true;
                return;
            }
            // Validacion para Email:
            LabelErrorEmail.Visible = false;

            
            if (string.IsNullOrEmpty(TextBoxemail.Text.Trim()))
            {
                LabelErrorEmail.Text = "El email no puede estar vacío.";
                LabelErrorEmail.Visible = true;
                return; 
            }

            
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            
            if (!Regex.IsMatch(TextBoxemail.Text.Trim(), emailPattern))
            {
                LabelErrorEmail.Text = "El email no es válido.";
                LabelErrorEmail.Visible = true;
                return; 
            }

            //Validacion para direccion :

            LabelErrorDireccion.Visible = false;


            if (string.IsNullOrEmpty(TextBoxdireccion.Text.Trim()))
            {
                LabelErrorDireccion.Text = "La Direccion no puede estar vacío.";
                LabelErrorDireccion.Visible = true;
                return;
            }


            string direccionPattern = @"^[a-zA-Z0-9áéíóúÁÉÍÓÚ\s.,-]+$";


            if (!Regex.IsMatch(TextBoxdireccion.Text.Trim(), direccionPattern))
            {
                LabelErrorDireccion.Text = "La Direccion no es válido.";
                LabelErrorDireccion.Visible = true;
                return;
            }

            //Validaciones para ciudad :

            if (string.IsNullOrEmpty(TextBoxciudad.Text.Trim()))
            {

                Labelerrorciudad.Text = "El campo ciudad no puede estar vacio";
                Labelerrorciudad.Visible = true;
                return;
            }

            string ciudadParttern = @"^[a-zA-ZáéíóúÁÉÍÓÚ0-9\s]+$";

            if (!Regex.IsMatch(TextBoxciudad.Text.Trim(), ciudadParttern))
            {
                Labelerrorciudad.Text = "La Direccion no es válido.";
                Labelerrorciudad.Visible = true;
                return;
            }

            //Validacion codigo postal

            if (string.IsNullOrEmpty(TextBoxcp.Text.Trim()))
            {
                Labelerrorcodigopostal.Text = "El campo código postal no puede estar vacío.";
                Labelerrorcodigopostal.Visible = true;
                return;
            }

            
            string codigoPostalPattern = @"^\d+$"; 

            if (!Regex.IsMatch(TextBoxcp.Text.Trim(), codigoPostalPattern))
            {
                Labelerrorcodigopostal.Text = "El código postal debe seguir el formato correcto , solo puede contener numeros (por ejemplo, 1000).";
                Labelerrorcodigopostal.Visible = true;
                return;
            }

            if (TextBoxcp.Text.Trim().Length < 4 || TextBoxcp.Text.Trim().Length > 10)
            {
                Labelerrorcodigopostal.Text = "El código postal debe tener entre 4 y 10 caracteres.";
                Labelerrorcodigopostal.Visible = true;
                return;
            }

            // validacion de este palometeado el checkbox:

            if (!CheckBox1.Checked)
            {
               
                Labelterminosycondiciones.Text = "Debe aceptar los términos y condiciones.";
                Labelterminosycondiciones.ForeColor = System.Drawing.Color.Red; 
                Labelterminosycondiciones.Visible = true;

                return;

            }
            else
            {
                
                Labelterminosycondiciones.Text = "Acepto los terminos y condiciones."; 
                Labelterminosycondiciones.Visible = false;
              
            }

            Labelerrorcodigopostal.Visible = false;
            Labelerrorciudad.Visible = false;
            Labelerrorapellido.Visible = false;
            LabelErrorDNI.Visible = false;
            Labelerrornombre.Visible = false;
            LabelErrorEmail.Visible = false;

            if (Session["Cliente"] != null)
            {
                cliente = (Cliente)Session["Cliente"];
                
            }

           

            if (cliente == null || cliente.Id == 0)
            {
                cliente = new Cliente();
                cliente.Documento = (String)TexboxDNI.Text;
                cliente.Nombre = (String)TextBoxnombre.Text;
                cliente.Apellido = (String)TextBoxapellido.Text;
                cliente.Email = (String)TextBoxemail.Text;
                cliente.Direccion = (String)TextBoxdireccion.Text;
                cliente.Ciudad = (String)TextBoxciudad.Text;
                cliente.CP = int.Parse(TextBoxcp.Text);

                ClienteNegocio clienteNegocio = new ClienteNegocio();
                clienteNegocio.AgregarCliente(cliente);

              

                Session["IdCliente"] = clienteNegocio.ObtenerUltimoIdCliente();  
                Session["FechaCanje"] = DateTime.Now;
            }
            else
            {
                Session["IdCliente"] = cliente.Id;
            }
            try
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
               
                // Recuperar los datos de la sesión
                string codigoVoucher = Session["Voucher"] as string;
                int idCliente =(int) Session["IdCliente"];
                string idArticulo = Session["ArticuloId"] as string; 
                DateTime fechaCanje = DateTime.Now; 

                
                Voucher v = new Voucher
                {
                    CodigoVoucher = codigoVoucher,
                    IdCliente = idCliente,
                    FechaCanje = fechaCanje,
                    IdArticulo = !string.IsNullOrEmpty(idArticulo) ? (int?)Convert.ToInt32(idArticulo) : null // Convertir a entero
                };
                VoucherNegocio voucherNegocio = new VoucherNegocio();
                
                voucherNegocio.validarVoucherComoUsado(v);

                // Mostrar un mensaje de éxito o redirigir a otra página si es necesario
                Session.Remove("Voucher");
                Session.Remove("ArticuloId");
                Session.Remove("Cliente");
            }
            catch (Exception ex)
            {
      
            }





        }
    }
}