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
    public class Edificio_Neg
    {
        Edificio_Dato movimiento_dato = new Edificio_Dato();



        public void insert(Edificio_Entidad movimiento_entidad)
        {



            movimiento_dato.Insert(movimiento_entidad);


        }




        public DataTable BUSCAR(String parametro)
        {

            return movimiento_dato.BUSCAR(parametro);

        }





    }
}

