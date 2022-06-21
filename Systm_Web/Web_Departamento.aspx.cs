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
    public partial class Web_Departamento : System.Web.UI.Page
    {

        Departamento_Entidad cliente_entidad = new Departamento_Entidad();

        Departamento_Neg cliente_neg = new Departamento_Neg();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {




                tipo();
                edificio();


                txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


            }
        }
        private void edificio()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTAREDIFICIO();

            cboedificio.DataSource = dt;

            this.cboedificio.DataTextField = "nombre";

            this.cboedificio.DataValueField = "cod_edf";

            this.cboedificio.DataBind();

            cboedificio.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        private void tipo()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTARPROPIETARIO();

            cbopropietario.DataSource = dt;

            this.cbopropietario.DataTextField = "apellidos";

            this.cbopropietario.DataValueField = "idprop";

            this.cbopropietario.DataBind();

            cbopropietario.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
        private void borar()
        {




           txtarea.Text = "";
           txtnumero.Text = "";

           txtpiso.Text = "";
           txtestacionamiento.Text = "";
            

            cboedificio.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            cbopropietario.Items.Insert(0, new ListItem("[Seleccionar]", "0"));


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfecha.Text == "" || txtarea.Text == "" || txtfecha.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {


                cliente_entidad.numero = txtnumero.Text;

                cliente_entidad.cod_edf = cboedificio.SelectedValue.ToString();

                cliente_entidad.idprop = cbopropietario.SelectedValue.ToString();


                cliente_entidad.area = txtarea.Text;
                cliente_entidad.piso = txtpiso.Text;
                cliente_entidad.estacimiento = txtestacionamiento.Text;
                cliente_entidad.estado = cboestado.Text;


                cliente_entidad.fecharegistro= txtfecha.Text;







                cliente_neg.insert(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Guardado los Datos Correctamente')</script>");

                borar();




            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Departamento.aspx");
        }
    }
}