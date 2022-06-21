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
    public class Edificio_Dato
    {


        Conexion con = new Conexion();


         public void Insert(Edificio_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("insert into Edificio values (@nombre,@direccion,@fecharegistro)", con.con);

            cmd.CommandType = CommandType.Text;






            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = cliente_entidad.nombre;

      
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = cliente_entidad.direccion;

          
            cmd.Parameters.Add("@fecharegistro", SqlDbType.DateTime).Value = cliente_entidad.fecharegistro;






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



            string query = "SELECT  cod_edf as Codigo, Nombre,Direccion,FechaRegistro from edificio where  (nombre Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", "%" + Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }





    }

}
