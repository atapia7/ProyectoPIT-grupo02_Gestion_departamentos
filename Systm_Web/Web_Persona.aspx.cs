using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace Systm_Web
{
    public partial class Web_Persona : System.Web.UI.Page
    {



        Persona_Entidad cliente_entidad = new Persona_Entidad();

        Persona_Neg cliente_neg = new Persona_Neg();



        protected void Page_Load(object sender, EventArgs e)
        {
            txtciudad.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void borar()
        {

            txtnombre.Text = "";

            txtruc.Text = "";



            txttelefono.Text = "";
            txtdireccion.Text = "";

            txtciudad.Text = "";


        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Personas.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

              if (txtnombre.Text == "" || txtdireccion.Text == "" || txtciudad.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {


            cliente_entidad.dni = txtruc.Text;

            cliente_entidad.nombre = txtnombre.Text;


            cliente_entidad.apellido= txtdireccion.Text;

            cliente_entidad.telefono= txttelefono.Text;

            cliente_entidad.fecha = txtciudad.Text;


            cliente_neg.insert(cliente_entidad);

            this.Response.Write("<script language='JavaScript'>window.alert('insertado correctamente')</script>");

            borar();

        }

        }

    }
}