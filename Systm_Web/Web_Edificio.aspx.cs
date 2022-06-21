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
    public partial class Web_Edificio : System.Web.UI.Page
    {

        Edificio_Entidad cliente_entidad = new Edificio_Entidad();

        Edificio_Neg cliente_neg = new Edificio_Neg();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtciudad.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void borar()
        {

            txtnombre.Text = "";

           
            txtdireccion.Text = "";

            txtciudad.Text = "";


        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "" || txtdireccion.Text == "" || txtciudad.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {

            

            cliente_entidad.nombre = txtnombre.Text;


            cliente_entidad.direccion = txtdireccion.Text;



                cliente_entidad.fecharegistro = txtciudad.Text;

            cliente_neg.insert(cliente_entidad);

            this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Guardado los Datos Correctamente')</script>");

            borar();

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Edificio.aspx");
        }
    }
}