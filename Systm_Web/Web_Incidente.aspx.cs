using Entidades;
using Negocios;
using System;
using System.Data;
using System.Web.UI.WebControls;
namespace Systm_Web
{
    public partial class Web_Incidente : System.Web.UI.Page
    {

        Incidente_Entidad cliente_entidad = new Incidente_Entidad();

        Incidente_Neg cliente_neg = new Incidente_Neg();
        Departamento_Neg cliente_neg1 = new Departamento_Neg();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {



                departamento();

                tipo();


                txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                edificio();

            }
        }

        private void edificio()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg1.LISTAREDIFICIO();

            cboedificio.DataSource = dt;

            this.cboedificio.DataTextField = "nombre";

            this.cboedificio.DataValueField = "cod_edf";

            this.cboedificio.DataBind();


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

        private void tipo()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTARTIPO();

            cbotipo.DataSource = dt;

            this.cbotipo.DataTextField = "nombre";

            this.cbotipo.DataValueField = "id_tipo";

            this.cbotipo.DataBind();

            cbotipo.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
        private void borar()
        {




            txtdescripcion.Text = "";


            //cbotipo.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            //cbodepartamento.Items.Insert(0, new ListItem("[Seleccionar]", "0"));


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfecha.Text == "" || txtdescripcion.Text == "" || txtfecha.Text == "")
            {                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }            else
            {

                cliente_entidad.edificio = cboedificio.SelectedValue.ToString();

                cliente_entidad.cod_dep = cbodepartamento.SelectedValue.ToString();

                cliente_entidad.idtipo = cbotipo.SelectedValue.ToString();

                cliente_entidad.descripcion = txtdescripcion.Text;




                cliente_entidad.fecha = txtfecha.Text;

                cliente_entidad.estado = cboestado.Text;





                cliente_neg.insert(cliente_entidad);


                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Guardado los Datos Correctamente')</script>");

                borar();




            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Incidente.aspx");
        }
    }
}