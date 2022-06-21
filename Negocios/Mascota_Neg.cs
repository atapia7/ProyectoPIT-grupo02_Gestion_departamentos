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
    public class Mascota_Neg
    {
        Mascota_Dato movimiento_dato = new Mascota_Dato();



        public void insert(Mascota_Entidad movimiento_entidad)
        {



            movimiento_dato.Insert(movimiento_entidad);


        }




        public DataTable BUSCAR(String parametro)
        {

            return movimiento_dato.BUSCAR(parametro);

        }



        public DataTable LISTAR()
        {

            return movimiento_dato.LISTADO();


        }

    }
}

