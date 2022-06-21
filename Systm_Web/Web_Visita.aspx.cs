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
    public partial class Web_Visita : System.Web.UI.Page
    {

        Visita_Entidad cliente_entidad = new Visita_Entidad();

        Visita_Neg cliente_neg = new Visita_Neg();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                persona();
                departamento();

                txtentrada.Text = System.DateTime.Now.ToLongTimeString();

                txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


            }
        }

        private void borar()
        {




            txtcomentario.Text = "";
            txtfecha.Text = "";
      
            txtfecha.Text = "";

            cbopersona.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            cbodepartamento.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

        }

        private void persona()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTARPERSONA();

            cbopersona.DataSource = dt;

            this.cbopersona.DataTextField = "Apellidos";

            this.cbopersona.DataValueField = "cod_persona";

            this.cbopersona.DataBind();

            cbopersona.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        private void departamento()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTARDEPARTAMENTO();

            cbodepartamento.DataSource = dt;

            this.cbodepartamento.DataTextField = "Numero";

            this.cbodepartamento.DataValueField = "cod_dep";

            this.cbodepartamento.DataBind();

            cbodepartamento.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfecha.Text == "" || txtentrada.Text == "" || txtentrada.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {

               
                cliente_entidad.cod_dep = cbodepartamento.SelectedValue.ToString();

                cliente_entidad.cod_persona = cbopersona.SelectedValue.ToString();

                cliente_entidad.entrada = txtentrada.Text;


                cliente_entidad.salida = txtsalida.Text;


                cliente_entidad.estado = cboestado.Text;

                cliente_entidad.comentario = txtcomentario.Text;

                cliente_entidad.fecha = txtfecha.Text;







                cliente_neg.insert(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Guardado los Datos Correctamente')</script>");


                //ClientScript.RegisterStartupScript(this.GetType(),"randomtext", "alertme()", true);


                borar();




            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Visita.aspx");
        }
    }
}