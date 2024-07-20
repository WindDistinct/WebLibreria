using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLibreria_BL;

namespace WebLibreria_GUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                try
                {
                    Autor_BL autor = new Autor_BL();
                    
                    ddlAutor.DataSource = autor.listarAutor();
                    ddlAutor.DataTextField = "aut_nom_ape";
                    ddlAutor.DataValueField = "aut_id";
                    ddlAutor.DataBind();

                    Genero_BL genero = new Genero_BL();

                    ddlGenero.DataSource = genero.listarGenero();
                    ddlGenero.DataTextField = "gen_desc";
                    ddlGenero.DataValueField = "gen_id";
                    ddlGenero.DataBind();

                    Renta_BL renta = new Renta_BL();

                    DateTime inMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    txtFecIn.Text = inMes.ToString("dd/MM/yyyy");
                    txtFecEnd.Text = DateTime.Now.ToString("dd/MM/yyyy");

                    grv1.DataSource = renta.FiltrarLibrosRentados(null, null, (new DateTime(2020,1,1)), DateTime.Now);
                    grv1.DataBind();
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }
        }

        protected void btnAplicar_Click(object sender, EventArgs e)
        { 
            Renta_BL renta = new Renta_BL();
            int? gen = null;
            int? aut = null;

            if (ddlGenero.SelectedValue != "0")
            {
                gen = Int32.Parse(ddlGenero.SelectedValue);
            }

            if (ddlAutor.SelectedValue != "0")
            {
                aut = Int32.Parse(ddlAutor.SelectedValue);
            }

            DateTime fecIn = Convert.ToDateTime(txtFecIn.Text);
            DateTime fecOut = Convert.ToDateTime(txtFecEnd.Text);

            try
            {
                grv1.DataSource = renta.FiltrarLibrosRentados(gen,aut,fecIn,fecOut);
                grv1.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}