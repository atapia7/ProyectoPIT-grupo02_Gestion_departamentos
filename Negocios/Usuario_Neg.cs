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
    public class Usuario_Neg
    {
        Usuario_Dato movimiento_dato = new Usuario_Dato();

  

        public void insert(Usuario_Entidad movimiento_entidad)
        {



            movimiento_dato.Insert(movimiento_entidad);


        }


    


        public DataTable BUSCAR(String parametro)
        {

            return movimiento_dato.BUSCAR(parametro);

        }



  


        public DataTable N_login(Entidades.Usuario_Entidad obje)
        {


            return movimiento_dato.D_Login(obje);

        }



    }
}

