using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadSession();
            deleteSession();
        }

        protected void loadSession()
        {
            String Nombre = (String)(Session["Nombre"]);
            String Apellidos = (String)(Session["Apellidos"]);

            LabelName.Text = "Nombre: " + Nombre;
            LabelSurname.Text = "Apellidos: " + Apellidos;
        }
        protected void deleteSession()
        {
            Session.RemoveAll();
            Session.Abandon();
        }
    }
}