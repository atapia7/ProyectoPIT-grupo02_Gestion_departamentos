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
    public class Visita_Dato
    {


        Conexion con = new Conexion();


        public void Insert(Visita_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("insert into Visitas values (@cod_dep,@cod_persona,@hora_entrada,@hora_salida,@estado,@comentario,@fecharegistro)", con.con);

            cmd.CommandType = CommandType.Text;






            cmd.Parameters.Add("@cod_dep", SqlDbType.VarChar, 100).Value = cliente_entidad.cod_dep;


            cmd.Parameters.Add("@cod_persona", SqlDbType.VarChar, 100).Value = cliente_entidad.cod_persona;
            cmd.Parameters.Add("@hora_entrada", SqlDbType.VarChar, 100).Value = cliente_entidad.entrada;
            cmd.Parameters.Add("@hora_salida", SqlDbType.VarChar, 100).Value = cliente_entidad.salida;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 100).Value = cliente_entidad.estado;
            cmd.Parameters.Add("@comentario", SqlDbType.VarChar, 100).Value = cliente_entidad.comentario;


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
        public void Modificar(Visita_Entidad cliente_entidad)
        {
            //    try
            //    {


            SqlCommand cmd = new SqlCommand("update visitas set cod_dep=@cod_dep,cod_persona=@cod_persona,hora_entrada=@hora_entrada,hora_salida=@hora_salida,estado=@estado,comentario=@comentario,fecharegistro=@fecharegistro  where  nro_visita=@nro_visita", con.con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@nro_visita", SqlDbType.Int).Value = cliente_entidad.id;



            cmd.Parameters.Add("@cod_dep", SqlDbType.VarChar, 100).Value = cliente_entidad.cod_dep;


            cmd.Parameters.Add("@cod_persona", SqlDbType.VarChar, 100).Value = cliente_entidad.cod_persona;
            cmd.Parameters.Add("@hora_entrada", SqlDbType.VarChar, 100).Value = cliente_entidad.entrada;
            cmd.Parameters.Add("@hora_salida", SqlDbType.VarChar, 100).Value = cliente_entidad.salida;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 100).Value = cliente_entidad.estado;
            cmd.Parameters.Add("@comentario", SqlDbType.VarChar, 100).Value = cliente_entidad.comentario;


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



        public DataTable BUSCAR(String Nombres)
        {



            string query = "SELECT        VISITAS.Nro_visita, DEPARTAMENTOS.Numero as N_Departamento,PERSONA.cod_persona as Codigo,PERSONA.Dni, PERSONA.Nombres, PERSONA.Apellidos, VISITAS.hora_entrada, VISITAS.hora_salida, VISITAS.Estado, VISITAS.Comentario, VISITAS.FechaRegistro FROM            VISITAS INNER JOIN DEPARTAMENTOS ON VISITAS.Cod_dep = DEPARTAMENTOS.Cod_dep INNER JOIN  PERSONA ON VISITAS.cod_persona = PERSONA.cod_persona   where  (persona.apellidos Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", "%" + Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }

        public DataTable LISTADOPERSONA()
        {


  SqlDataAdapter da=new SqlDataAdapter("SELECT cod_persona, (Nombres+' '+Apellidos) AS apellidos  from persona ", con.con);
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



    }

}
