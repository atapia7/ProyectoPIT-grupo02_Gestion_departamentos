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
    public partial class Web_Consulta_Visita : System.Web.UI.Page
    {




        Visita_Entidad cliente_entidad = new Visita_Entidad();

        Visita_Neg cliente_neg = new Visita_Neg();




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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Session["Nro_Visita"] = GridView1.SelectedRow.Cells[1].Text;



            Session["N_Departamento"] = GridView1.SelectedRow.Cells[2].Text;


            Session["Codigo"] = GridView1.SelectedRow.Cells[3].Text;
            Session["Apellidos"] = GridView1.SelectedRow.Cells[6].Text;

            Session["hora_entrada"] = GridView1.SelectedRow.Cells[7].Text;

            Session["hora_salida"] = GridView1.SelectedRow.Cells[8].Text;


            Session["estado"] = GridView1.SelectedRow.Cells[9].Text;

            Session["comentario"] = GridView1.SelectedRow.Cells[10].Text;


        




            Response.Redirect("Web_Visita_Actualizar.aspx");

        }
    }
}