﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Voucher_Magic._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Voucher Magic</h1>
      <div class="form-group">
        <div><label for="inputVoucher" class="col-lg-2 control-label">Ingrese el Número del Voucher</label></div> 
        <div class="col-lg-10">

       </div> <asp:TextBox ID="txtBuscarVoucher" BorderColor="Black" Height="40" Width="1000" placeholder="Número Voucher" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnBuscarVoucher" Width="200" Height="40" BackColor="Window" BorderColor="Black" OnClick="btnBuscarVoucher_Click" runat="server" Text="Buscar Voucher"  href="https://github.com/MBAlbornoz/tp3-albornoz/" />
         <%--<input type="text" class="form-control" id="inputVoucher" placeholder="Número Voucher"-- %>
        <%--
             <div>
            <asp:TextBox runat="server" Width="1000" Height="40" ID="txtBuscar" BorderColor="Black" BorderStyle="Double"></asp:TextBox>
        </div>--%>
        <%-- <p><a href="https://www.google.com" class="btn btn-primary btn-lg" id="txtBuscar" onclick="">Consultar Voucher &raquo;</a></p>--%>

    </div>
    <div></div>
</asp:Content>
