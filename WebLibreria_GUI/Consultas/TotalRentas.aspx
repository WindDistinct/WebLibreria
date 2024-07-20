<%@ Page Title="" Language="C#" MasterPageFile="~/Libreria.Master" AutoEventWireup="true" CodeBehind="TotalRentas.aspx.cs" Inherits="WebLibreria_GUI.WebForm3" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Rentas anuales</h2>
        <div>
            <div>
                <div>
                    <p>Estadisticas de las rentas por mes</p>
                    
                </div>
                <div>
                    <asp:Chart ID="grafTotales" runat="server" Height="304px">
                        <series>
                            <asp:Series Name="Series1">
                            </asp:Series>
                        </series>
                        <chartareas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </chartareas>
                        <Titles>
                            <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 8.25pt, style=Bold" Name="Titulo1" Text="Total de rentas por mes"></asp:Title>
                        </Titles>
                    </asp:Chart>
                </div>
            </div>
            <div>
                <div>
                    <p>Gráfico circular de ventas por categoría</p>
                </div>
                <div style="height: 302px">
                    <asp:Chart ID="Chart1" runat="server" Height="291px">  
                        <Titles>
                            <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 8.25pt, style=Bold" Name="Titulo2" Text="Porcentaje de libros rentados"></asp:Title>
                        </Titles>  
                        <Legends>  
                            <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default"  
                                LegendStyle="Row" />  
                        </Legends>  
                        <Series>  
                            <asp:Series Name="Default" />  
                        </Series>  
                        <ChartAreas>  
                            <asp:ChartArea Name="ChartArea1" BorderWidth="0" />  
                        </ChartAreas>  
                    </asp:Chart>  
                </div>
            </div>
        </div>
</asp:Content>
