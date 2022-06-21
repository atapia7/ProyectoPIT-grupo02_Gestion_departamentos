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
    public class Propietario_Neg
    {
        Propietario_Dato movimiento_dato = new Propietario_Dato();



        public void insert(Propietario_Entidad movimiento_entidad)
        {



            movimiento_dato.Insert(movimiento_entidad);


        }


        public void  Modificar(Propietario_Entidad movimiento_entidad)
        {



            movimiento_dato.Modificar(movimiento_entidad);


        }

        public void Eliminar(Propietario_Entidad movimiento_entidad)
        {



            movimiento_dato.Eliminar(movimiento_entidad);


        }






        public DataTable BUSCAR(String parametro)
        {

            return movimiento_dato.BUSCAR(parametro);

        }




        





    }
}

