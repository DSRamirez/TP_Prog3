using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Prog3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblprimera.Text = "Hola Mundo - Es la primera vez que se ha cargado la página";
                lblcontador.Text = "0";
            }

            Response.Write("Cantidad de sesiones de usuario " + Application["Usuarios"]);
        }

        private int conteo = 1;

        protected void btncargar_Click(object sender, EventArgs e)
        {
            lblprimera.Text = "Esta página ya ha sido visitada";

            if (ViewState["click"] != null)
            {
                conteo = (int)ViewState["click"] + 1;
            }

            lblcontador.Text = conteo.ToString();
            ViewState["click"] = conteo;
        }

        protected void tbtreinicia_Click(object sender, EventArgs e)
        {
            lblprimera.Text = "Hola Mundo - Es la primera vez que se ha cargado la página";
            lblcontador.Text = "0";
            conteo = 0;
            ViewState["click"] = conteo;
        }

    }
}