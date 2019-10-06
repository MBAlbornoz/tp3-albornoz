<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Voucher_Magic.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <style>
        button btn-producto{
            border-bottom-color:deepskyblue;
            color:black;
            text-decoration-style:solid;
            width:auto;
            height:auto;
            text-align:center;
  
        }
        </style>
        
    

      <div class="card-group">
        <% foreach (var item in listaProductos)
            { %>
                <div onclick="dataLayer.push({ 'event' : 'GAEvent', 'eventCategory' :'landing_20170322_big-sale','eventAction':'03-categorias-secundarias','eventLabel':'01-audio'})" id="bloque-1" class="col-lg-4 col-md-4 col-sm-4 col-xs-12 recetas">
                <div class="text-hover">
                <%------CARGA LA PAGINA DE ALTA DEL CLIENTE------%>
                </div>
                 <div class="div-overflow"> <img src="<%=item.urlImagen %>" alt=""> </div>
                 <div class="titulo-destacado">
                  <h3><%= item.descripcion %></h3>
                 </div>
                  <button><a href="FormCliente.aspx" class="btn-producto"> Elegir Producto</a></button>
                 <a href="https://www.google.com" class="btn-producto black button-mobile hidden-lg hidden-md hidden-sm"> Ver que hace</a>
                </div>
        <% } %>
                </div>
    </div>
</asp:Content>
