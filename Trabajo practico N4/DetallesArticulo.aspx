<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetallesArticulo.aspx.cs" Inherits="Trabajo_practico_N4.DetallesArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section class="detalles-container">
        <div class="detalles-info">
            <label class="detalles">
                Codigo: <asp:Label ID="lblCodigo" runat="server"></asp:Label>
            </label> 

            <label class="detalles">
                Nombre: <asp:Label ID="lblNombre" runat="server"></asp:Label>
            </label> 

            <label class="detalles">
                Marca:<asp:Label ID="lblMarca" runat="server"></asp:Label>
            </label> 

            <label class="detalles">
                Categoria: <asp:Label ID="lblCategoria" runat="server"></asp:Label>
            </label> 

            <label class="detalles">
                Precio: $<asp:Label ID="lblPrecio" runat="server"></asp:Label>
            </label> 

            <label class="detalles descripcion">
                <asp:Label ID="lblDescripcion" runat="server"></asp:Label>
            </label> 

            <asp:Button ID="btnSeleccionar" runat="server" CssClass="btn btn-primary btn-form" Text="Participar" CommandName="ArticuloId" CommandArgument='<%:articulo.Id%>' OnClick="btnSeleccionar_Click" />
        </div>

        <div class="detalles-img">

            <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">

                <div class="carousel-inner marco">
                    <%bool primeraImagen = false; %>
                    <%foreach (Dominio.Imagen imagen in articulo.Imagen){ %>

                        <div class="carousel-item <%if (!primeraImagen) {%> active <%; primeraImagen = true;} %>">

                            <img class="d-block w-100" src="<%:imagen.ToString()%>"  alt="First slide">
                        </div>
                    <%}%>
                                     
                </div>

                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>

                
            </div>


        </div>
    </section>
</asp:Content>


