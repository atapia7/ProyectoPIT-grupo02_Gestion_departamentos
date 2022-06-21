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
    public partial class Web_Consulta_Propietario : System.Web.UI.Page
    {



        Propietario_Entidad cliente_entidad = new Propietario_Entidad();

        Propietario_Neg cliente_neg = new Propietario_Neg();


        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            String dato = TextBox1.Text;

            dt = cliente_neg.BUSCAR(dato);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            String dato = TextBox1.Text;

            dt = cliente_neg.BUSCAR(dato);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Session["codigo"] = GridView1.SelectedRow.Cells[1].Text;



            Session["dni"] = GridView1.SelectedRow.Cells[2].Text;


            Session["Nombres"] = GridView1.SelectedRow.Cells[3].Text;
            Session["Apellidos"] = GridView1.SelectedRow.Cells[4].Text;

            Session["Celular"] = GridView1.SelectedRow.Cells[5].Text;

          

            Session["comentario"] = GridView1.SelectedRow.Cells[6].Text;







            Response.Redirect("Web_Propietario_Actualizar.aspx");




        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //try
            
            
            //{


            
            //int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());



            //cliente_entidad.id = id;


            //cliente_neg.Eliminar(cliente_entidad);


            //this.Response.Write("<script language='JavaScript'>window.alert('Ha sido  Eliminado los Datos Correctamente')</script>");

            //GridView1.EditIndex = -1;

            //}

            //catch (Exception ex)
            //{
            //    string error = "" + ex;

            //}

        }
    }
}