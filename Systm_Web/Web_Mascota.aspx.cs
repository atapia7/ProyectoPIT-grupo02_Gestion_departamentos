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
    public partial class Web_Mascota : System.Web.UI.Page
    {
        Mascota_Entidad cliente_entidad = new Mascota_Entidad();

        Mascota_Neg cliente_neg = new Mascota_Neg();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                propietario();              
                    txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");              
            }
        }
        private void propietario()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTAR();

            cbopropietario.DataSource = dt;

            this.cbopropietario.DataTextField = "Apellidos";

            this.cbopropietario.DataValueField = "idprop";

            this.cbopropietario.DataBind();

            cbopropietario.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
        private void borar()
        {




            txttipo.Text = "";
            txtnombre.Text = "";
            txtsexo.Text = "";
            txtraza.Text = "";
            txtfecha.Text = "";

            cbopropietario.Items.Insert(0, new ListItem("[Seleccionar]", "0"));



        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfecha.Text == "" || txtnombre.Text == "" || txttipo.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {

                cliente_entidad.idprop = cbopropietario.SelectedValue.ToString();


                cliente_entidad.mascota = txttipo.Text;

                cliente_entidad.nombre= txtnombre.Text;


                cliente_entidad.sexo = txtsexo.Text;
                cliente_entidad.raza = txtraza.Text;

                cliente_entidad.fecha = txtfecha.Text;
          






                cliente_neg.insert(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Guardado los Datos Correctamente')</script>");

                borar();




            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Mascota.aspx");
        }
    }
}