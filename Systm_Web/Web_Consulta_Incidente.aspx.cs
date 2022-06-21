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
    public partial class Web_Consulta_Incidente : System.Web.UI.Page
    {




        Incidente_Entidad cliente_entidad = new Incidente_Entidad();

        Incidente_Neg cliente_neg = new Incidente_Neg();



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



            Session["Departamento"] = GridView1.SelectedRow.Cells[2].Text;


            Session["causa"] = GridView1.SelectedRow.Cells[3].Text;
           




            Response.Redirect("Web_Incidente_Actualizar.aspx");









        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}