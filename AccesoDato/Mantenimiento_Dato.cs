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
    public class Mantenimiento_Dato
    {


        Conexion con = new Conexion();


        public void Insert(Mantenimiento_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("insert into Mantenimiento values (@id,@id_tipomantenimiento,@cod_edf,@idprop,@descripcion,@monto,@fecharegistro,@estado)", con.con);

            cmd.CommandType = CommandType.Text;




            cmd.Parameters.Add("@id", SqlDbType.VarChar, 100).Value = cliente_entidad.id;

            cmd.Parameters.Add("@id_tipomantenimiento", SqlDbType.VarChar, 100).Value = cliente_entidad.idtipo;
           
            cmd.Parameters.Add("@cod_edf", SqlDbType.VarChar, 50).Value = cliente_entidad.edificio;

            cmd.Parameters.Add("@idprop", SqlDbType.VarChar, 100).Value = cliente_entidad.propietario;

            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 100).Value = cliente_entidad.descripcion;

            cmd.Parameters.Add("@monto", SqlDbType.VarChar, 50).Value = cliente_entidad.monto;


            cmd.Parameters.Add("@fecharegistro", SqlDbType.DateTime).Value = cliente_entidad.fecha;

            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 100).Value = cliente_entidad.estado;




            con.con.Open();

            cmd.ExecuteNonQuery();

            con.con.Close();
            //}

            //catch (Exception ex)

            //{
            //    string error = "Error" + ex;

            //}


        }


        public void Modificar(Mantenimiento_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("update  MANTENIMIENTO set estado=@estado  where id=@id", con.con);

            cmd.CommandType = CommandType.Text;







            cmd.Parameters.Add("@id", SqlDbType.Int, 1).Value = cliente_entidad.id;

         
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 100).Value = cliente_entidad.estado;






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



            string query = "SELECT        MANTENIMIENTO.id as Nª_Boleta, PROPIETARIO.dni as Dni, PROPIETARIO.Nombres ,PROPIETARIO.Apellidos, MANTENIMIENTO.descripcion as Mes, MANTENIMIENTO.fechaRegistro as Fecha_Pago, TIPO_MANTENIMIENTO.nombre as Servicio, MANTENIMIENTO.estado as Estado FROM MANTENIMIENTO INNER JOIN  TIPO_MANTENIMIENTO ON MANTENIMIENTO.Id_tipoMantenimiento = TIPO_MANTENIMIENTO.Id_tipoMantenimiento INNER JOIN PROPIETARIO ON MANTENIMIENTO.idprop = PROPIETARIO.idprop INNER JOIN EDIFICIO ON MANTENIMIENTO.Cod_edf = EDIFICIO.Cod_edf  where  (propietario.apellidos Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", "%" + Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }
        public DataTable LISTADOTIPO()
        {


            SqlDataAdapter da = new SqlDataAdapter("select id_tipomantenimiento,nombre from tipo_mantenimiento", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }

        public DataTable LISTADODEPARTAMENTO()
        {


            SqlDataAdapter da = new SqlDataAdapter("select cod_dep,numero from departamentos ", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }


        // AUTOGENERAR CODIGO  

        public string contador;

        public List<Mantenimiento_Entidad> UltimoCod()
        {
            //using (var cn = new SqlConnection(con.con))
            //{



            SqlCommand sqlcmd = new SqlCommand("select count(id),max (id) from MANTENIMIENTO", con.con);
            sqlcmd.CommandType = CommandType.Text;
            con.con.Open();
            SqlDataReader PaTable = sqlcmd.ExecuteReader();




            List<Mantenimiento_Entidad> Coleccion = new List<Mantenimiento_Entidad>();




            while (PaTable.Read())
            {
                this.contador = Convert.ToString(PaTable.GetInt32(0));
                if (contador == "0")
                {



                    Coleccion.Add(new Mantenimiento_Entidad(PaTable.GetInt32(0).ToString()));



                }
                else
                {



                    Coleccion.Add(new Mantenimiento_Entidad(PaTable.GetString(1)));


                }
            }
            return Coleccion;


        }
        //}




    }

}
