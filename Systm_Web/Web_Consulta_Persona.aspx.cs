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
    public partial class Web_Consulta_Persona : System.Web.UI.Page
    {






        Persona_Entidad cliente_entidad = new Persona_Entidad();

        Persona_Neg cliente_neg = new Persona_Neg();





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


            Session["v"] = GridView1.SelectedRow.Cells[2].Text;



            Session["v"] = GridView1.SelectedRow.Cells[4].Text;







            Response.Redirect("Web_visita.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            String dato = TextBox1.Text;

            dt = cliente_neg.BUSCAR(dato);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}