<%@ Page Title="" Language="C#" MasterPageFile="~/Libreria.Master" AutoEventWireup="true" CodeBehind="ClientesMem.aspx.cs" Inherits="WebLibreria_GUI.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <div>
            <table>
                <tr>
                    <td >
                        <asp:GridView ID="grv1" runat="server" BackColor="LightGoldenrodYellow" 
                            BorderColor="Tan" BorderWidth="1px" CellPadding="2" Width="901px" GridLines="None" ForeColor="Black" AutoGenerateColumns="False">
                            <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            <Columns>
                                 <asp:BoundField DataField="cli_id" HeaderText="ID" />
                                 <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                                 <asp:BoundField DataField="cli_tel" HeaderText="Telefono" />
                                 <asp:BoundField DataField="cli_mail" HeaderText="E-mail" />
                                 <asp:BoundField HeaderText="Membresia" DataField="cli_memb_tipo" NullDisplayText="No posee" />
                                 <asp:BoundField DataField="cli_memb_cad" HeaderText="Caducidad" NullDisplayText="No posee" />
                            </Columns>
                            <FooterStyle BackColor="Tan" />
                            <HeaderStyle BackColor="Tan" Font-Bold="True" />
                            <PagerStyle ForeColor="DarkSlateBlue" HorizontalAlign="Center" BackColor="PaleGoldenrod" />
                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            <SortedAscendingCellStyle BackColor="#FAFAE7" />
                            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                            <SortedDescendingCellStyle BackColor="#E1DB9C" />
                            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="height: 31px;" colspan="2">
                        <asp:Label ID="lblMensaje" runat="server" BorderStyle="None" Width="721px" style="color: #FF0000"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <h2>Lista de clientes</h2>
            <asp:RadioButtonList id="rdbMemb" runat="server">
                <asp:ListItem Value="1">Con membresía</asp:ListItem>
                <asp:ListItem Value="0">Sin membresía</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button id="btnButton" Text="Filtrar" runat="server" OnClick="btnButton_Click"/>
        </div>
    </div>

</asp:Content>