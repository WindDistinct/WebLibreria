<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Libreria.master" CodeBehind="Principal.aspx.cs" Inherits="WebLibreria_GUI.Consultas.Principal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>Reportes</h2>
        <a class="nav-link" runat="server" href="LibrosRentados.aspx">Informe de libros rentados</a>
        <a class="nav-link" runat="server" href="TotalRentas.aspx">Gráfico de rentas anuales</a>
        <a class="nav-link" runat="server" href="ClientesMem.aspx">Lista de clientes</a>
    </main>
</asp:Content>