using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using Entidades;
using Negocios;
namespace Systm_Web
{
    public partial class Web_Incidente_Actualizar : System.Web.UI.Page
    {

        Incidente_Entidad cliente_entidad = new Incidente_Entidad();

        Incidente_Neg cliente_neg = new Incidente_Neg();
        Departamento_Neg cliente_neg1 = new Departamento_Neg();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {






                txtcodigo.Text = (String)Session["codigo"];



               txtdepartamento.Text = (String)Session["departamento"];



                txtcausa.Text = (String)Session["Causa"];


           





            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtcausa.Text == "" || txtcodigo.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {

                cliente_entidad.id = txtcodigo.Text;




                cliente_entidad.estado = cboestado.Text;





                cliente_neg.modificar(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Guardado los Datos Correctamente')</script>");

            




            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Incidente.aspx");
        }
    }
}