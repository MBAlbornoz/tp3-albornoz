<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Voucher_Magic._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            color: black;
            text-align: center;
            background-color: lightblue;
            text-size-adjust: auto;
        }
    </style>

    <div class="jumbotron">
      <asp:Label  Font-Bold="true" Font-Size="50px"  CssClass="nombrePagina" runat="server">Magic Voucher</asp:Label>
      <div class="form-group">
          <div>
            <div><label for="inputVoucher" class="col-lg-2 control-label">Ingrese el Número del Voucher</label></div>
            <div><asp:TextBox ID="txtBuscarVoucher" AutoPostBack="true" BorderColor="Black" Height="40px" Width="504px" placeholder="Número Voucher" runat="server"></asp:TextBox></div>
          </div>
        </div>
        <asp:Button ID="btnBuscarVoucher" Width="200" Height="40" BackColor="Window" BorderColor="Black" OnClick="btnBuscarVoucher_Click" runat="server" Text="Buscar Voucher"  href="https://github.com/MBAlbornoz/tp3-albornoz/" />
        
    </div>
    <div></div>
</asp:Content>
