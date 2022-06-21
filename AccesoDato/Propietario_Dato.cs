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
    public class Propietario_Dato
    {


        Conexion con = new Conexion();




        public void Insert(Propietario_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("insert into Propietario values (@dni,@nombres,@apellidos,@celular,@fecharegistro)", con.con);

            cmd.CommandType = CommandType.Text;






            cmd.Parameters.Add("@dni", SqlDbType.VarChar, 100).Value = cliente_entidad.dni;
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar, 50).Value = cliente_entidad.nombre;

            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = cliente_entidad.apellido;

            cmd.Parameters.Add("@celular", SqlDbType.VarChar, 100).Value = cliente_entidad.telefono;


            cmd.Parameters.Add("@fecharegistro", SqlDbType.DateTime).Value = cliente_entidad.fecha;






            con.con.Open();

            cmd.ExecuteNonQuery();

            con.con.Close();
            //}

            //catch (Exception ex)

            //{
            //    string error = "Error" + ex;

            //}


        }


        public void Modificar(Propietario_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("update  propietario set dni=@dni,nombres=@nombres,apellidos=@apellidos,celular=@celular,fecharegistro=@fecharegistro where idprop=@idprop", con.con);

            cmd.CommandType = CommandType.Text;







            cmd.Parameters.Add("@idprop", SqlDbType.Int, 1).Value = cliente_entidad.id;

            cmd.Parameters.Add("@dni", SqlDbType.VarChar, 100).Value = cliente_entidad.dni;
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar, 50).Value = cliente_entidad.nombre;

            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = cliente_entidad.apellido;

            cmd.Parameters.Add("@celular", SqlDbType.VarChar, 100).Value = cliente_entidad.telefono;


            cmd.Parameters.Add("@fecharegistro", SqlDbType.VarChar, 100).Value = cliente_entidad.fecha;






            con.con.Open();

            cmd.ExecuteNonQuery();

            con.con.Close();
            //}

            //catch (Exception ex)

            //{
            //    string error = "Error" + ex;

            //}


        }
        public void Eliminar(Propietario_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("delete from  propietario where idprop=@idprop", con.con);

            cmd.CommandType = CommandType.Text;






            cmd.Parameters.Add("@idprop", SqlDbType.Int,1).Value = cliente_entidad.id;
          





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



            string query = "SELECT      idprop as Codigo,Dni,Nombres,Apellidos,Celular,FechaRegistro from propietario   where  (nombres Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", "%" + Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }





    }

}
