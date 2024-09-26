<%@ Page Title="Canjea tu voucher" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Trabajo_practico_N4.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
    <link href="Content/boton.css" rel="stylesheet" />
    <main aria-labelledby="title">
        
        <h2 id="title"><%: Title %>.</h2>
       
        <h3>Ingresa el codigo de tu voucher!</h3>
        <p>ingresa el codigo , luego presiona en el boton siguiente.</p>
        <asp:TextBox ID="Texcodigovoucher" runat="server"></asp:TextBox>
        <asp:Button ID="Btnsiguiente" runat="server" Text="Siguiente" CssClass="customButton"/>
    </main>
</asp:Content>
