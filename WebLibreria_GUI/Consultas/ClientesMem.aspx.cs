using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLibreria_BL;

namespace WebLibreria_GUI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Cliente_BL cliente_BL = new Cliente_BL();
                    grv1.DataSource = cliente_BL.ListarClientes();
                    grv1.DataBind();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        protected void btnButton_Click(object sender, EventArgs e)
        {
            Cliente_BL cl = new Cliente_BL();

            string selectedValue = rdbMemb.SelectedValue;

            bool filtrarPorNulos = selectedValue == "0";

            grv1.DataSource = cl.FiltrarClientes(filtrarPorNulos);
            grv1.DataBind();
        }
    }
}