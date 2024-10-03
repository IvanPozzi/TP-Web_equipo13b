<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Trabajo_practico_N4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSheet1.css" rel="stylesheet" />

    <main>

        <section class="row" aria-labelledby="aspnetTitle">
             <div class="banner">
                 <div id="filtro">
                     <h1 class="align-middle" id="aspnetTitle">Promo Gana!</h1>
                     <p>Canjea tu voucher otorgado por tu compra , y participa del sorteo de increibles premios.</p>
                 </div>
            </div>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Canjea tu voucher</h2>
                <p>
              Para canjear tu voucher, dirígete al menú principal y selecciona la opción "Canjear Voucher". Alternativamente, puedes hacer clic en el botón que se encuentra justo debajo para completar el proceso de manera rápida y sencilla.
                </p>
                <p>
                    <a class="btn btn-default " href="/VoucherForm.aspx">click aca! &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Elegi un articulo</h2>
                <p>
                    Tenés la posibilidad de elegir el premio por el que querés participar, con una increíble variedad de artículos disponibles para seleccionar. ¡Luego de ingresar tu codigo promocional , explorá nuestras opciones y encontrá el premio perfecto para vos!
                </p>
               
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Completa tus datos</h2>
                <p>
                    Para finalizar, ingresá tus datos y ya estarás participando de este increíble sorteo. ¡Vos podés ser el próximo ganador! ¡No pierdas la oportunidad!.
                </p>
            
            </section>
        </div>
    </main>

</asp:Content>
