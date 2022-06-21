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
    public class Mascota_Dato
    {


        Conexion con = new Conexion();


        public void Insert(Mascota_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("insert into Mascotas values (@idprop,@mascota,@nombre,@sexo,@raza,@fecharegistro)", con.con);

            cmd.CommandType = CommandType.Text;






            cmd.Parameters.Add("@idprop", SqlDbType.Int).Value = cliente_entidad.idprop;
            cmd.Parameters.Add("@mascota", SqlDbType.VarChar, 50).Value = cliente_entidad.mascota;

            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cliente_entidad.nombre;

            cmd.Parameters.Add("@sexo", SqlDbType.VarChar, 100).Value = cliente_entidad.sexo;

            cmd.Parameters.Add("@raza", SqlDbType.VarChar, 100).Value = cliente_entidad.raza;

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


        public DataTable BUSCAR(String Nombres)
        {



            string query = "SELECT        MASCOTAS.Idmascota,  MASCOTAS.Nombre,MASCOTAS.Mascota as Tipo, MASCOTAS.Sexo, MASCOTAS.Raza, PROPIETARIO.Nombres, PROPIETARIO.Apellidos, MASCOTAS.fechaRegistro FROM            MASCOTAS INNER JOIN  PROPIETARIO ON MASCOTAS.idprop = PROPIETARIO.idprop  where  (propietario.nombres Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", "%" + Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }

        public DataTable LISTADO()
        {


            SqlDataAdapter da = new SqlDataAdapter("select idprop,(Nombres+' '+Apellidos) AS apellidos from propietario", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }



    }

}
