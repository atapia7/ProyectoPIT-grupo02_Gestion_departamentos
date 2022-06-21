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
    public partial class Web_Visita_Actualizar : System.Web.UI.Page
    {

        Visita_Entidad cliente_entidad = new Visita_Entidad();

        Visita_Neg cliente_neg = new Visita_Neg();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {



     
                departamento();

                txtcodigo.Text = (String)Session["Nro_visita"];

      

                cbodepartamento.Text = (String)Session["N_departamento"];



               txtcodpersona.Text = (String)Session["codigo"];


               txtpersona.Text = (String)Session["Apellidos"];


               txtentrada.Text = (String)Session["hora_entrada"];

                //txtsalida.Text = (String)Session["hora_salida"];

                cboestado.Text = (String)Session["Estado"];

               txtcomentario.Text = (String)Session["Comentario"];

             

               txtsalidas.Text = System.DateTime.Now.ToLongTimeString();

               txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");



            }



        }



        private void persona()
        {

         
        }

        private void departamento()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTARDEPARTAMENTO();

            cbodepartamento.DataSource = dt;

            this.cbodepartamento.DataTextField = "Numero";

            this.cbodepartamento.DataValueField = "cod_dep";

            this.cbodepartamento.DataBind();

            //cbodepartamento.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfecha.Text == "" || txtcodpersona.Text == "" || txtentrada.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {


                cliente_entidad.id = txtcodigo.Text;

                cliente_entidad.cod_dep = cbodepartamento.SelectedValue.ToString();

                cliente_entidad.cod_persona = txtcodpersona.Text;

                cliente_entidad.entrada = txtentrada.Text;


                cliente_entidad.salida = txtsalidas.Text;


                cliente_entidad.estado = cboestado.Text;

                cliente_entidad.comentario = txtcomentario.Text;

                cliente_entidad.fecha = txtfecha.Text;







                cliente_neg.modificar(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Actualizado los Datos Correctamente')</script>");

 



            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Visita.aspx");
        }
    }
}