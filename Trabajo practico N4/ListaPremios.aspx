<%@ Page Title="Elige tu premio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaPremios.aspx.cs" Inherits="Trabajo_practico_N4.Formulario_web1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
    <link href="Content/boton.css" rel="stylesheet" />
    <main aria-labelledby="title">
        
        <h2 id="title"><%: Title %>.</h2>
       
        <p>Elige entre los siguientes articulos por cual de estos deseas participar.</p>

        <div class="row row-cols-1 row-cols-md-3 g-4">

            <%foreach(Dominio.Articulo articulo in listaArticulos) { %>
                    <div class="col">
                        <div class="card">
                            <div class="altura-cards">
                                <div id="carouselExample" class="carousel slide">
                                    <div class="carousel-inner">
                                        <%bool bandera = false; %>
                                         <% foreach (Dominio.Imagen imagen in articulo.Imagen) {  %>
                                                <div class="carousel-item
                                                                        <%if(bandera == false) { %>
                                                                           active
                                                                        <% ;bandera = true;} %>
                                                    
                                                 ">
                                                   <img src="<%: imagen.ToString() %>" class="card-img-top" alt="...">
                                                </div>
                                        <% } %>
                                       
                                    </div>
                                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                        <span class="visually-hidden">Previous</span>
                                    </button>
                                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                        <span class="visually-hidden">Next</span>
                                    </button>
                                </div>
                                
                            </div>
                            <div class="card-body">
                                <h5 class="card-title"><%: articulo.Nombre%></h5>
                                <p class="card-text"><%: articulo.Descripcion%></p>
                                <a class="btn btn-secondary" href="DetallesArticulo.aspx?Id=<%#Eval("Id")%>">Ver detalles</a>
                                <asp:Button ID="btnSeleccionar" runat="server" cssClass="btn btn-primary" Text="Participar"  CommandName="ArticuloId" CommandArgument='<%# Eval("Id")%>'  OnClick="btnSeleccionar_Click"/>
                            </div>
                        </div>
                    </div>
                <%}%>
        </div>


      
    </main>
</asp:Content>
