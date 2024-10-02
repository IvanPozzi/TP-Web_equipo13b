<%@ Page Title="Formulario para participar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosParticipante.aspx.cs" Inherits="Trabajo_practico_N4.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
    <link href="Content/boton.css" rel="stylesheet" />
    <link href="Content/espaciomargen.css" rel="stylesheet" />
    <link href="Content/margenlabelytextbox.css" rel="stylesheet" />
    <main aria-labelledby="title">
        
        <h2 id="title"><%: Title %>.</h2>
       
        <h3>Ingresa tus datos</h3>
        <p>luego presiona en el boton participar.</p>

        <div class="spacing">
        <asp:Label ID="LabelDNI" runat="server" Text="DNI:"></asp:Label>
            <div>
        <asp:TextBox ID="TexboxDNI" runat="server" OnTextChanged="TexDocumento_TextChanged" AutoPostBack="true"></asp:TextBox>
            </div>
             
    <asp:Label ID="LabelErrorDNI" runat="server" Text="El DNI no puede estar vacío." ForeColor="Red" Visible="false"></asp:Label>
        </div >

   
        <table>
            <tr>
                <td>
                   <div>
                    <asp:Label ID="Labelnombre" runat="server" Text="Nombre:"></asp:Label>
                    
               
                    <div >
                    <asp:TextBox ID="TextBoxnombre" runat="server"></asp:TextBox>
                    </div>
                       <asp:Label ID="Labelerrornombre" runat="server" Text="El nombre no puede estar vacio" ForeColor="Red" Visible="false"></asp:Label>
               </div>
            
                <td>
                    <div class="spacing">
                    <asp:Label ID="Labelapellido" runat="server" Text="Apellido:"></asp:Label>
                <div>
                    <asp:TextBox ID="TextBoxapellido" runat="server"></asp:TextBox>
                </div>
                    </div>
                </td>


                     <td>


                <div class="spacing">

                 <asp:Label ID="Labelemail" runat="server" Text="Email:"></asp:Label>

                <div>

                <asp:TextBox ID="TextBoxemail" runat="server"></asp:TextBox>

                </div>

                </div>

                </td>


                 </tr>
        </table>

         <table>
             <tr>
                 <td>

                     <div class="spacing">

                            <asp:Label ID="Labeldireccion" runat="server" Text="Direccion:"></asp:Label>

                      <div>

                            <asp:TextBox ID="TextBoxdireccion" runat="server"></asp:TextBox>

                      </div>


                     </div>
                 </td>

                   <td>

      <div class="spacing">

             <asp:Label ID="Labelciudad" runat="server" Text="Ciudad:"></asp:Label>

       <div>

             <asp:TextBox ID="TextBoxciudad" runat="server"></asp:TextBox>

       </div>


      </div >
  </td>
                     <td>

     <div class="spacing">

            <asp:Label ID="Labelcp" runat="server" Text="CP:"></asp:Label>

      <div>

            <asp:TextBox ID="TextBoxcp" runat="server"></asp:TextBox>

      </div>


     </div>
 </td>


             </tr>




         </table>
        <div class="checkbox-spacing">
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:Label ID="Labelterminosycondiciones" runat="server" Text="">Acepto los terminos y condiciones.</asp:Label>
        </div>

        <div class="button-spacing">
            
        <asp:Button ID="Btnparticipar" runat="server" Text="Participar" CssClass="customButton" class="spacing" OnClick="Btnparticipar_Click"/>
        </div>
    
    </main>
</asp:Content>
