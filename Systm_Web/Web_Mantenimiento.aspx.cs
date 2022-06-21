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
    public partial class Web_Mantenimiento : System.Web.UI.Page
    {


        Mantenimiento_Entidad cliente_entidad = new Mantenimiento_Entidad();

        Mantenimiento_Neg cliente_neg = new Mantenimiento_Neg();

        Departamento_Neg cliente_neg1 = new Departamento_Neg();


        Mascota_Neg cliente_neg2 = new Mascota_Neg();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {



                edificio();
                tipo();

                //  txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                DateTime fechaActual = DateTime.Now;



                string mes = fechaActual.ToString("MMMM");


                txtdescripcion.Text = mes;

                propietario();

                Ultimo();




            }

           
        }
        private void Ultimo()
        {
           Mantenimiento_Neg cnper = new Mantenimiento_Neg();
            List<Mantenimiento_Entidad> per = cnper.UltimoEmp();
            foreach (Mantenimiento_Entidad ma in per)
            {
                int codigo = 0;
                codigo = Convert.ToInt32(ma.Codigo);
                codigo = codigo + 1;
                if (codigo < 10)
                {
                    ma.Codigo = "000" + codigo.ToString();
                }
                if (codigo < 100 && codigo > 9)
                {
                    ma.Codigo = "00" + codigo.ToString();
                }
                if (codigo < 1000 && codigo > 99)
                {
                    ma.Codigo = "0" + codigo.ToString();
                }
                txtcodigo.Text = ma.Codigo;
            }
        }
        private void borar()
        {




            //txtdescripcion.Text = "";
            txtmonto.Text = "";


           // cbopropietario.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

           // //cbodepartamento.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

           //cbotipo.Items.Insert(0, new ListItem("[Seleccionar]", "0"));


        }

      
        private void edificio()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg1.LISTAREDIFICIO();

            cbodepartamento.DataSource = dt;

            this.cbodepartamento.DataTextField = "nombre";

            this.cbodepartamento.DataValueField = "cod_edf";

            this.cbodepartamento.DataBind();

           
        }

        private void tipo()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg.LISTARTIPO();

            cbotipo.DataSource = dt;

            this.cbotipo.DataTextField = "nombre";

            this.cbotipo.DataValueField = "Id_tipoMantenimiento";

            this.cbotipo.DataBind();

            cbotipo.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        private void propietario()
        {

            DataTable dt = new DataTable();
            dt = cliente_neg2.LISTAR();

            cbopropietario.DataSource = dt;

            this.cbopropietario.DataTextField = "Apellidos";

            this.cbopropietario.DataValueField = "idprop";

            this.cbopropietario.DataBind();

            cbopropietario.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Web_Consulta_Mantenimiento.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txtfecha.Text == "" || txtdescripcion.Text == "" || txtmonto.Text == "")
            {

                this.Response.Write("<script language='JavaScript'>window.alert('Ingrese los Datos Correctamente')</script>");
            }

            else
            {

                cliente_entidad.id = txtcodigo.Text;


                cliente_entidad.idtipo = cbotipo.SelectedValue.ToString();

                cliente_entidad.edificio = cbodepartamento.SelectedValue.ToString();


                cliente_entidad.propietario= cbopropietario.SelectedValue.ToString();

                cliente_entidad.descripcion = txtdescripcion.Text;

                cliente_entidad.monto = txtmonto.Text;



                cliente_entidad.fecha = txtfecha.Text;

                cliente_entidad.estado = cboestado.Text;





                cliente_neg.insert(cliente_entidad);

                this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Guardado los Datos Correctamente')</script>");

                borar();

                Ultimo();


            }
        }

        protected void cbodepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {


            DateTime fechaActual = DateTime.Now;



            string mes = fechaActual.ToString("MMMM");


            txtdescripcion.Text = mes;

        }

        protected void cbodepartamento_TextChanged(object sender, EventArgs e)
        {

            DateTime fechaActual = DateTime.Now;



            string mes = fechaActual.ToString("MMMM");


            txtdescripcion.Text = mes;
        }
    }
}