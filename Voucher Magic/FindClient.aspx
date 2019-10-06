<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FindClient.aspx.cs" Inherits="Voucher_Magic.FindClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
       body{background-color:whitesmoke}
       txtIngreso{
        text-align:center;
        font:italic;
        font:700;
        font-size-adjust:initial;
        color:blue;
    }
</style>

 
<asp:Label ID="lblIngreso" CssClass="textIngreso" runat="server">Ingrese su numero de Documento</asp:Label>
 <h1></h1>
<asp:TextBox ID="TextVerDNICl" MaxLength="8" Width="605px" Height="30px" AutoPostBack="true" BorderColor="Black" BorderStyle="Double" ValidateRequestMode="Enabled" runat="server" OnTextChanged="TextVerDNICl_TextChanged"></asp:TextBox>
<asp:Button ID="BtnRegCl" OnClick="BtnRegistroCliente_Click" runat="server" Text="Ingresar" />


</asp:Content>

