using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Entidades;
using AccesoDato;
using System.Data;
namespace Negocios
{
    public class Mantenimiento_Neg
    {
        Mantenimiento_Dato movimiento_dato = new Mantenimiento_Dato();



        public void insert(Mantenimiento_Entidad movimiento_entidad)
        {



            movimiento_dato.Insert(movimiento_entidad);


        }

        public void modificar(Mantenimiento_Entidad movimiento_entidad)
        {



            movimiento_dato.Modificar(movimiento_entidad);


        }


        public DataTable BUSCAR(String parametro)
        {

            return movimiento_dato.BUSCAR(parametro);

        }


        public DataTable LISTARDEPARTAMENTO()
        {

            return movimiento_dato.LISTADODEPARTAMENTO();


        }


        public DataTable LISTARTIPO()
        {

            return movimiento_dato.LISTADOTIPO();


        }



        //AUTOGENERAR CODIGO

        public List<Mantenimiento_Entidad> UltimoEmp()
        {


            Mantenimiento_Dato cd = new Mantenimiento_Dato();

            return cd.UltimoCod();
        }



    }
}

