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
    public class Incidente_Neg
    {
        Incidente_Dato movimiento_dato = new Incidente_Dato();



        public void insert(Incidente_Entidad movimiento_entidad)
        {



            movimiento_dato.Insert(movimiento_entidad);


        }

        public void modificar(Incidente_Entidad movimiento_entidad)
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



    }
}

