<%@ Page Title="" Language="C#" MasterPageFile="~/Libreria.Master" AutoEventWireup="true" CodeBehind="LibrosRentados.aspx.cs" Inherits="WebLibreria_GUI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5 container-custom">
        <h3>Informe de libros rentados</h3>
        <div class="row mt-4">
            <div class="col-md-9">
                <table>
                    <tr>
                        <td >
                            <asp:GridView ID="grv1" runat="server" BackColor="LightGoldenrodYellow" 
                                BorderColor="Tan" BorderWidth="1px" CellPadding="2" Width="901px" GridLines="None" ForeColor="Black" AutoGenerateColumns="False">
                                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                                <Columns>
                                    <asp:BoundField DataField="lib_id" HeaderText="ID" />
                                    <asp:BoundField DataField="lib_nom" HeaderText="Libro" />
                                    <asp:BoundField DataField="gen_desc" HeaderText="Categoría" />
                                    <asp:BoundField DataField="autor" HeaderText="Autor" />
                                    <asp:BoundField DataField="rent_count" HeaderText="Total de rentas" ReadOnly="True" />
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
            <div class="col-md-3">
                <div class="filters">
                    <h5>Filtros:</h5>
                    <div class="form-group">
                        <label for="genre">Ingrese un género:</label>
                        <asp:DropDownList ID="ddlGenero" runat="server" CssClass="form-control" AppendDataBoundItems="True">
                            <asp:ListItem Selected="True" Value="0">--Seleccione un género--</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="author">Ingrese un autor:</label>
                        <asp:DropDownList ID="ddlAutor" runat="server" CssClass="form-control" AppendDataBoundItems="True">
                            <asp:ListItem Selected="True" Value="0">--Seleccione un autor--</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <span">Ingrese un range de fechas:</span>
                        <div class="row align-items-center">
                            <div class="my-2 col-2">
                                <label for="txtFecIn" class="form-label">De: </label>
                            </div>
                            <div class="my-2 col-8">
                                <asp:TextBox ID="txtFecIn" runat="server" CssClass="TextBoxDerecha" Width="100px"></asp:TextBox>
                
                                <ajaxToolkit:CalendarExtender ID="txtFecIn_CalendarExtender" runat="server" BehaviorID="txtFecIn_CalendarExtender" TargetControlID="txtFecIn">
                                </ajaxToolkit:CalendarExtender>
                            </div>
                        </div>
                        <div class="row align-items-center">
                            <div class="my-2 col-3">
                                <label for="txtFecEnd" class="form-label">Hasta: </label>
                            </div>
                            <div class="my-2 col-8">
                                <asp:TextBox ID="txtFecEnd" runat="server" CssClass="TextBoxDerecha" Width="100px"></asp:TextBox>
                
                                <ajaxToolkit:CalendarExtender ID="txtFecEnd_CalendarExtender" runat="server" BehaviorID="txtFecEnd_CalendarExtender" TargetControlID="txtFecEnd">
                                </ajaxToolkit:CalendarExtender>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btnAplicar" runat="server" Text="Aplicar" OnClick="btnAplicar_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
