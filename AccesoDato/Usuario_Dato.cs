using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using Entidades;
namespace AccesoDato
{
    public class Usuario_Dato
    {


        Conexion con = new Conexion();


        public void Insert(Usuario_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("insert into Usuarios values (@Usuario,@contraseña,@cargo,@fechaReg)", con.con);

            cmd.CommandType = CommandType.Text;




            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = cliente_entidad.usuario;

            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 100).Value = cliente_entidad.contraseña;

            cmd.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Value = cliente_entidad.cargo;


            cmd.Parameters.Add("@fechaReg", SqlDbType.DateTime).Value = cliente_entidad.fecha;





            con.con.Open();

            cmd.ExecuteNonQuery();

            con.con.Close();
            //}

            //catch (Exception ex)

            //{
            //    string error = "Error" + ex;

            //}


        }

       

      



        public DataTable BUSCAR(String Nombres)
        {



            string query = "SELECT        Id_Usuario as Codigo, Usuario , Contraseña,Cargo,FechaReg FROM     Usuarios   where  (Usuario Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", "%" + Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }


        public DataTable D_Login(Entidades.Usuario_Entidad obje)
        {

            SqlCommand cmd = new SqlCommand("select  id_usuario,usuario,contraseña,cargo from usuarios  where  Usuario =@usuario  and contraseña=@contraseña", con.con);

            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@usuario", obje.usuario);

            cmd.Parameters.AddWithValue("@contraseña", obje.contraseña);

           //cmd.Parameters.AddWithValue("@cargo", obje.cargo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable1 = new DataTable();

            da.Fill(dtable1);

            return dtable1;



        }




    }

}
