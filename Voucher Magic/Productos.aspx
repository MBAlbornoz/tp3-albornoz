<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Voucher_Magic.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <style>
        button {
         background-image: none;
         background-color: #0095ff;
         border-color: #07c;
         box-shadow: inset 0 1px 0 0 rgba(102,191,255,0.75), 0 0 0 0 rgba(0,149,255,0);
         color: #FFF;
            }
        
        </style>

  
      <div class="card-group">

        <%   foreach (var item in listaProductos)
            { %>
                <div onclick="dataLayer.push({ 'event' : 'GAEvent', 'eventCategory' :'landing_20170322_big-sale','eventAction':'03-categorias-secundarias','eventLabel':'01-audio'})" id="bloque-1" class="col-lg-4 col-md-4 col-sm-4 col-xs-12 recetas">
                <div class="text-hover"></div>
              
               <%--<a href="FindClient.aspx?ID=<%=item.id%>"><img src="<%=item.urlImagen%>"></a>--%>
                <%---<div class="div-overflow"> <img src="<%=item.urlImagen %>" alt="" id="<%=item.id %>"> </div>--%> 
                <div><a href="FindClient.aspx?ID=<%=item.id%>"><img id="imagen" src="<%=item.urlImagen%>" alt="" onclick="redirige" property="og:image"/></a></div>
                 <div class="titulo-destacado">
                  <h3><%= item.descripcion%></h3>
                      </div>
                  <div><a href="FindClient.aspx?ID=<%=item.id%>" class="button"  style="border: 1px double #000000; padding: 2px; margin: 3px; -moz-border-bottom-colors:cornflowerblue; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: italic; color: #000000; background-color: #6699FF; visibility: visible; overflow: visible;">Seleccionar Producto</a></div> 
                   
                </div>
        <% } %>
      </div>

      <%----<button id="buttonElegido" itemid="<%=item.id %>"  onclick="ProductoSeleccionado" name="boton">Selelcionar Producto</button>---%> 

</asp:Content>
