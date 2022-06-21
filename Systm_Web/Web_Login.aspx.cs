using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using Entidades;
using Negocios;






namespace Systm_Web
{
    public partial class Web_Login : System.Web.UI.Page
    {


   

        Usuario_Entidad obje = new Usuario_Entidad();

        Usuario_Neg objn = new Usuario_Neg();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();

            obje.usuario = txtusuario.Text;
            obje.contraseña = txtcontraseña.Text;
             //obje.cargo = cbocargo.Text;


            dt = objn.N_login(obje);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][3].ToString() == "Administrador")
                {

                    obje.usuario = dt.Rows[0][1].ToString();
                    obje.contraseña = dt.Rows[0][2].ToString();
                    //obje.cargo = dt.Rows[0][3].ToString();





                    Response.Redirect("Web_Menu_Principal.aspx");




                }

                else if (dt.Rows[0][3].ToString() == "Supervisor")
                {

                    obje.usuario = dt.Rows[0][1].ToString();
                    obje.contraseña = dt.Rows[0][2].ToString();
                    //obje.cargo = dt.Rows[0][3].ToString();





                       Response.Redirect("Web_Menu_Supervisor.aspx");

                }




            }
            else
            {


                Response.Write("<script>alert('El Usuario y Contraseña es Incorrecto') </Script>");

            }



        }
    }
}