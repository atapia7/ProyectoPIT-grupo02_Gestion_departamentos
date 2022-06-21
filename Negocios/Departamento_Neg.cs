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
    public class Departamento_Neg
    {
        Departamento_Dato movimiento_dato = new Departamento_Dato();



        public void insert(Departamento_Entidad movimiento_entidad)
        {



            movimiento_dato.Insert(movimiento_entidad);


        }





        public DataTable BUSCAR(String parametro)
        {

            return movimiento_dato.BUSCAR(parametro);

        }



        public DataTable LISTAREDIFICIO()
        {

            return movimiento_dato.LISTADOEDIFICIO();


        }


        public DataTable LISTARPROPIETARIO()
        {

            return movimiento_dato.LISTADODEPROPIETARIO();


        }



    }
}

