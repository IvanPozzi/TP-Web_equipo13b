<%@ Page Title="Canjea tu voucher" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VoucherForm.aspx.cs" Inherits="Trabajo_practico_N4.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        
        <h2 id="title"><%: Title %>.</h2>

       
            <p>Luego presiona en el boton siguiente.</p>

        <div class="form col-5">
             <h3>Ingresa el codigo de tu voucher!</h3>

            <asp:TextBox ID="Texcodigovoucher" for="validationCustom01" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            <asp:Button ID="Btnsiguiente" runat="server" Text="Siguiente" CssClass="btn btn-primary btn-form" OnClick="Btnsiguiente_Click"/>
        <div>

        
        </div>
        </div>
        </main>
</asp:Content>
