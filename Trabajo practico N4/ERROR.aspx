<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ERROR.aspx.cs" Inherits="Trabajo_practico_N4.ERROR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Site.css" rel="stylesheet" /> 
    <div class="centrar-texto mi-texto-error mi-texto-error"> 
        <h1 >A ocurrido un error inesperado, le sugerimos que vuelva a inicio y realice el proceso de carga nuevamente</h1>
    </div>  
    <div class="centrado">
        <asp:Button ID="ButtonError" runat="server" Text="Volver a Inicio" class="mi-boton" OnClick="ButtonError_Click"/>
    </div> 
</asp:Content>
