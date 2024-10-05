<%@ Page Title="Elige tu premio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaPremios.aspx.cs" Inherits="Trabajo_practico_N4.Formulario_web1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
    <link href="Content/boton.css" rel="stylesheet" />
    <main aria-labelledby="title">
        
        <h2 id="title"><%: Title %>.</h2>
       
        <p>Elige entre los siguientes articulos por cual de estos deseas participar.</p>
        <div class="row row-cols-1 row-cols-md-3 g-4">
            <asp:Repeater runat="server" ID="repRepetidor">
                <ItemTemplate>

               
                    <div class="col">
                        <div class="card">
                            <div class="altura-cards">
                                <img src=" <%#Eval("Imagen[0]")%>" class="card-img-top" alt="...">
                            </div>
                        </div>
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre")%></h5>
                            <p class="card-text"><%#Eval("Descripcion")%></p>
                            <a class="btn btn-secondary" href="DetallesArticulo.aspx?Id=<%#Eval("Id")%>">Ver detalles</a>
                            <asp:Button ID="btnSeleccionar" runat="server" CssClass="btn btn-primary" Text="Participar" CommandName="ArticuloId" CommandArgument='<%# Eval("Id")%>' OnClick="btnSeleccionar_Click" />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        



      
    </main>
</asp:Content>
