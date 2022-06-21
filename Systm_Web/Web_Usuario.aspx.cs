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
    public partial class Web_Usuario : System.Web.UI.Page
    {
       
        Usuario_Entidad cliente_entidad = new Usuario_Entidad();

        Usuario_Neg cliente_neg = new Usuario_Neg();


        protected void Page_Load(object sender, EventArgs e)
        {


            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }
        private void borar()
        {

            txtusuario.Text = "";

            cbocargo.Items.Insert(0, new ListItem("[]", "0"));




            txtcontraseña.Text = "";
           


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtcontraseña.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {

                cliente_entidad.usuario = txtusuario.Text;

                cliente_entidad.contraseña = txtcontraseña.Text;





                cliente_entidad.cargo = cbocargo.Text;

                cliente_entidad.fecha = txtfecha.Text;

                cliente_neg.insert(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Guardado los Datos Correctamente')</script>");

                borar();




            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Usuario.aspx");
        }
    }
}