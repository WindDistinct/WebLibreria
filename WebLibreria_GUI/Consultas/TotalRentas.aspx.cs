using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using WebLibreria_BE;
using WebLibreria_BL;

namespace WebLibreria_GUI
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Bindchart();
                Renta_BL renta_BL = new Renta_BL();

                grafTotales.Series.Add("Totales");
                grafTotales.Series["Totales"].Points.DataBindXY(renta_BL.ListarRentaMensual(), "Mes", renta_BL.ListarRentaMensual(), "Rentas");
            }
        }

        private void Bindchart()
        {
            Renta_BL rentaBL = new Renta_BL();
            List<RentaxGenero_BE> rentas = rentaBL.ListarRentaxGenero();

            // Almacenar la cantidad total de filas para recorrer cada registro
            string[] XPointMember = new string[rentas.Count];
            decimal[] YPointMember = new decimal[rentas.Count];

            for (int count = 0; count < rentas.Count; count++)
            {
                // Almacenar valores para el eje X
                XPointMember[count] = rentas[count].genero;
                // Almacenar valores para el eje Y
                YPointMember[count] = rentas[count].porcentaje;
            }

            // Enlazar el control Chart
            Chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);

            // Configurar el ancho de la línea
            Chart1.Series[0].BorderWidth = 10;
            // Configurar el tipo de gráfico
            Chart1.Series[0].ChartType = SeriesChartType.Pie;

            // Colorear las porciones del gráfico
            foreach (DataPoint point in Chart1.Series[0].Points)
            {
                switch (point.AxisLabel)
                {
                    case "Ficción":
                        point.Color = Color.CornflowerBlue;
                        break;
                    case "Novela":
                        point.Color = Color.OrangeRed;
                        break;
                    case "Fantasía":
                        point.Color = Color.MediumPurple;
                        break;
                    case "Ciencia ficción":
                        point.Color = Color.LimeGreen;
                        break;
                    case "Realismo mágico":
                        point.Color = Color.Gold;
                        break;
                    case "Romance":
                        point.Color = Color.DeepPink;
                        break;
                    case "Misterio":
                        point.Color = Color.DarkSlateBlue;
                        break;
                    case "Terror":
                        point.Color = Color.Crimson;
                        break;
                    case "Novela gótica":
                        point.Color = Color.SaddleBrown;
                        break;
                    case "Novela histórica":
                        point.Color = Color.DarkGoldenrod;
                        break;
                    case "Literatura infantil":
                        point.Color = Color.SkyBlue;
                        break;
                    case "Ensayo":
                        point.Color = Color.SeaGreen;
                        break;
                    case "Poesía":
                        point.Color = Color.LightCoral;
                        break;
                    case "Biografía":
                        point.Color = Color.MediumSeaGreen;
                        break;
                    case "Autobiografía":
                        point.Color = Color.CadetBlue;
                        break;
                    case "Drama":
                        point.Color = Color.IndianRed;
                        break;
                    case "Aventura":
                        point.Color = Color.Tomato;
                        break;
                    case "Fábula":
                        point.Color = Color.MediumOrchid;
                        break;
                    case "Crónica":
                        point.Color = Color.DarkKhaki;
                        break;
                    case "Epístola":
                        point.Color = Color.SlateGray;
                        break;
                }
                point.Label = string.Format("{0:0.0}% - {1}", point.YValues[0], point.AxisLabel);
            }

            // Habilitar 3D
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        }
    }
}
