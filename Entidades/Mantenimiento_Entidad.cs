using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class Mantenimiento_Entidad
    {


        public String id { get; set; }

        public String idtipo { get; set; }

        public String edificio { get; set; }


        public String propietario{ get; set; }
        public String descripcion { get; set; }


        public String monto { get; set; }




        public String fecha { get; set; }

        public String estado{ get; set; }


        private string _codigo;

        public string Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public Mantenimiento_Entidad()
        {
        }

        public  Mantenimiento_Entidad(string ccodigo)
        {
            _codigo = ccodigo;


        }

    }
}
