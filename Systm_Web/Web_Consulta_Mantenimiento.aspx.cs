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
    public partial class Web_Consulta_Mantenimiento : System.Web.UI.Page
    {



        Mantenimiento_Entidad cliente_entidad = new Mantenimiento_Entidad();

        Mantenimiento_Neg cliente_neg = new Mantenimiento_Neg();



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

            Session["Nª_Boleta"] = GridView1.SelectedRow.Cells[1].Text;



            Session["Dni"] = GridView1.SelectedRow.Cells[2].Text;


            Session["Nombres"] = GridView1.SelectedRow.Cells[3].Text;
            Session["Apellidos"] = GridView1.SelectedRow.Cells[4].Text;

            Session["Mes"] = GridView1.SelectedRow.Cells[5].Text;



            Session["Fecha_Pago"] = GridView1.SelectedRow.Cells[6].Text;


            Session["Servicio"] = GridView1.SelectedRow.Cells[7].Text;






            Response.Redirect("Web_Mantenimiento_Actualizar.aspx");


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}