using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Negocios;

namespace Systm_Web
{
    public partial class Web_Mantenimiento_Actualizar : System.Web.UI.Page
    {

        Mantenimiento_Entidad cliente_entidad = new Mantenimiento_Entidad();

        Mantenimiento_Neg cliente_neg = new Mantenimiento_Neg();

        Departamento_Neg cliente_neg1 = new Departamento_Neg();


        Mascota_Neg cliente_neg2 = new Mascota_Neg();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {






                txtcodigo.Text = (String)Session["Nª_Boleta"];



                txtpropietario.Text = (String)Session["apellidos"];



                txtdescripcion.Text = (String)Session["mes"];


                txtfecha.Text = (String)Session["fecha_pago"];


                txtservicio.Text = (String)Session["servicio"];



              


            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Mantenimiento.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfecha.Text == "" || txtdescripcion.Text == "" || txtpropietario.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {

                cliente_entidad.id = txtcodigo.Text;


             

                cliente_entidad.estado = cboestado.Text;





                cliente_neg.modificar(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Actualizado los Datos Correctamente')</script>");

               


            }
        }
    }
}