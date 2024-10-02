<%@ Page Title="Canjea tu voucher" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VoucherForm.aspx.cs" Inherits="Trabajo_practico_N4.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        
        <h2 id="title"><%: Title %>.</h2>

        <h3>Ingresa el codigo de tu voucher!</h3>
            <p>Luego presiona en el boton siguiente.</p>

        <div class="form">
            <asp:TextBox ID="Texcodigovoucher" runat="server"></asp:TextBox>
            <asp:Button ID="Btnsiguiente" runat="server" Text="Siguiente" CssClass="customButton" OnClick="Btnsiguiente_Click"/>
        <div>

        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
        </div>
        </main>
</asp:Content>
