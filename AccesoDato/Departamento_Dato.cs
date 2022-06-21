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
    public class Departamento_Dato
    {


        Conexion con = new Conexion();

              



         public void Insert(Departamento_Entidad cliente_entidad)
        {
            //    try
            //    {

            SqlCommand cmd = new SqlCommand("insert into Departamentos values (@Numero,@Cod_edf,@idprop,@Area_total_dep,@Piso,@N_Estacionamiento,@estado,@fecharegistro)", con.con);

            cmd.CommandType = CommandType.Text;






            cmd.Parameters.Add("@numero", SqlDbType.VarChar, 100).Value = cliente_entidad.numero;


            cmd.Parameters.Add("@cod_edf", SqlDbType.VarChar, 100).Value = cliente_entidad.cod_edf;


            cmd.Parameters.Add("@idprop", SqlDbType.VarChar, 100).Value = cliente_entidad.idprop;
            cmd.Parameters.Add("@area_total_dep", SqlDbType.VarChar, 100).Value = cliente_entidad.area;
            cmd.Parameters.Add("@piso", SqlDbType.VarChar, 100).Value = cliente_entidad.piso;

            cmd.Parameters.Add("@n_estacionamiento", SqlDbType.VarChar, 100).Value = cliente_entidad.estacimiento;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 100).Value = cliente_entidad.estado;
         



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



            string query = "SELECT        DEPARTAMENTOS.Cod_dep as Codigo, DEPARTAMENTOS.Numero AS N_Departamento, PROPIETARIO.Nombres, PROPIETARIO.Apellidos, EDIFICIO.Nombre, DEPARTAMENTOS.Area_total_dep as Area_Total, DEPARTAMENTOS.Piso, DEPARTAMENTOS.N_Estacionamiento, DEPARTAMENTOS.Estado, DEPARTAMENTOS.FechaRegistro FROM            DEPARTAMENTOS INNER JOIN  PROPIETARIO ON DEPARTAMENTOS.idprop = PROPIETARIO.idprop INNER JOIN EDIFICIO ON DEPARTAMENTOS.Cod_edf = EDIFICIO.Cod_edf where  (propietario.apellidos Like rtrim(@param)+'%')";
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@param", "%" + Nombres);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;





        }


        public DataTable LISTADOEDIFICIO()
        {


            SqlDataAdapter da = new SqlDataAdapter("select cod_edf,nombre from edificio ", con.con);
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

        public DataTable LISTADODEPROPIETARIO()
        {


            SqlDataAdapter da = new SqlDataAdapter("select idprop,(Nombres+' '+Apellidos) AS apellidos from propietario", con.con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }

    }

}
