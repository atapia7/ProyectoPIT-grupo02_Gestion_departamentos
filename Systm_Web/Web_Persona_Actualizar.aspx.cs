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
    public partial class Web_Persona_Actualizar : System.Web.UI.Page
    {



        Persona_Entidad cliente_entidad = new Persona_Entidad();

        Persona_Neg cliente_neg = new Persona_Neg();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {






                txtcodigos.Text = (String)Session["codigo"];



                txtruc.Text = (String)Session["dni"];



                txtnombre.Text = (String)Session["nombres"];


                txtdireccion.Text = (String)Session["Apellidos"];


                txttelefono.Text = (String)Session["telefono"];



                txtciudad.Text = DateTime.Now.ToString("dd/MM/yyyy");



            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "" || txtdireccion.Text == "" || txtciudad.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {



                cliente_entidad.id = txtcodigos.Text;

                cliente_entidad.dni = txtruc.Text;

                cliente_entidad.nombre = txtnombre.Text;


                cliente_entidad.apellido = txtdireccion.Text;

                cliente_entidad.telefono = txttelefono.Text;

                cliente_entidad.fecha = txtciudad.Text;


                cliente_neg.Modificar(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Actualizar los Datos Correctamente')</script>");

            

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "" || txtdireccion.Text == "" || txtciudad.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {


                cliente_entidad.id = txtcodigos.Text;


                cliente_neg.Eliminar(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Eliminado los Datos Correctamente')</script>");



            }
            
        }
    }
}