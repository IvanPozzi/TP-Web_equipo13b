<%@ Page Title="Formulario para participar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosParticipante.aspx.cs" Inherits="Trabajo_practico_N4.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
    <link href="Content/boton.css" rel="stylesheet" />
    <link href="Content/espaciomargen.css" rel="stylesheet" />
    <link href="Content/margenlabelytextbox.css" rel="stylesheet" />
    <main aria-labelledby="title">

        <h2 id="title"><%: Title %>.</h2>

        <div class="form form-user col-6">
            <h3>Ingresa tus datos</h3>

            <div class="campo-dni">
                <asp:Label ID="LabelDNI" runat="server" Text="DNI:"></asp:Label>

                <asp:TextBox ID="TexboxDNI" runat="server" CssClass="form-control intput-form" OnTextChanged="TexDocumento_TextChanged" AutoPostBack="true"></asp:TextBox>
                <asp:Label ID="LabelErrorDNI" runat="server" Text="El DNI no puede estar vacío." ForeColor="Red" Visible="false"></asp:Label>
            </div>



            <asp:Label ID="Labelnombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="TextBoxnombre" runat="server" CssClass="form-control intput-form "></asp:TextBox>
            <asp:Label ID="Labelerrornombre" runat="server" Text="El campo no puede estar vacio" ForeColor="Red" Visible="false"></asp:Label>


            <asp:Label ID="Labelapellido" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="TextBoxapellido" runat="server" CssClass="form-control intput-form"></asp:TextBox>
            <asp:Label ID="Labelerrorapellido" runat="server" Text="El campo no puede estar vacio" ForeColor="Red" Visible="false"></asp:Label>

            <asp:Label ID="Labelemail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="TextBoxemail" runat="server" CssClass="form-control intput-form"></asp:TextBox>
            <asp:Label ID="LabelErrorEmail" runat="server" Text="El campo no puede estar vacio" ForeColor="Red" Visible="false"></asp:Label>




            <asp:Label ID="Labeldireccion" runat="server" Text="Direccion:"></asp:Label>
            <asp:TextBox ID="TextBoxdireccion" runat="server" CssClass="form-control intput-form"></asp:TextBox>
            <asp:Label ID="LabelErrorDireccion" runat="server" Text="El campo no puede estar vacio" ForeColor="Red" Visible="false"></asp:Label>


            <asp:Label ID="Labelciudad" runat="server" Text="Ciudad:"></asp:Label>
            <asp:TextBox ID="TextBoxciudad" runat="server" CssClass="form-control intput-form"></asp:TextBox>
            <asp:Label ID="Labelerrorciudad" runat="server" Text="El campo no puede estar vacio" ForeColor="Red" Visible="false"></asp:Label>

            <asp:Label ID="Labelcp" runat="server" Text="CP:"></asp:Label>
            <asp:TextBox ID="TextBoxcp" runat="server" CssClass="form-control intput-form"></asp:TextBox>
            <asp:Label ID="Labelerrorcodigopostal" runat="server" Text="El campo no puede estar vacio" ForeColor="Red" Visible="false"></asp:Label>

            <div class="checkbox-spacing">
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <asp:Label ID="Labelterminosycondiciones" runat="server" Text="">Acepto los terminos y condiciones.</asp:Label>
            </div>

            <asp:Button ID="Btnparticipar" runat="server" Text="Participar" CssClass="btn btn-primary" class="spacing" OnClick="Btnparticipar_Click" />

        </div>

    </main>
</asp:Content>
