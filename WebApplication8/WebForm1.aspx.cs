using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication8.ServiceReference1;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            addDropDownCiudadItems();
        }

        protected void addDropDownCiudadItems()
        {
            Service1Client client = new Service1Client();
            String[] ciudades = client.getCiudades();
            Array.Sort(ciudades);
            for (int i = 0; i < ciudades.Length; i++)
            {
                string s = ciudades[i];
                city_dropdownlist.Items.Add(s);
            }
        }

        protected void Submit(object sender, EventArgs e)
        {
            string nombre = name_textbox.Text;
            string apellido = surnames_textbox.Text;
            string genre;
            if (genre_radiobuttonlist.Items.FindByText("Masculino").Selected)
            {
                genre = genre_radiobuttonlist_0.Value;
            }
            else
            {
                genre = genre_radiobuttonlist_1.Value;
            }

            string email = email_textbox.Text;
            string direccion = address_textbox.Text;
            string ciudad = city_dropdownlist.SelectedValue;
            string requerimientos = requirment_textarea.Text;

            Service1Client client = new Service1Client();
            string[] list = new string[6];
            list[0] = nombre;
            list[1] = apellido;
            list[2] = email;
            list[3] = genre;
            list[4] = ciudad;
            list[5] = requerimientos;
            string mensaje = client.addAlumno(list);

            createSesion(nombre, apellido);

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + mensaje + "')", true);

            name_textbox.Text = "";
            surnames_textbox.Text = "";
            genre_radiobuttonlist_0.Selected = false;
            genre_radiobuttonlist_1.Selected = false;
            email_textbox.Text = "";
            address_textbox.Text = "";
            city_dropdownlist.SelectedIndex = 0;
            requirment_textarea.Text = "";

            Response.Redirect("WebForm2");

        }

        private void createSesion(String nombre, String apellido)
        {
            Session["Nombre"] = nombre;
            Session["Apellido"] = apellido;
        }
    }
}