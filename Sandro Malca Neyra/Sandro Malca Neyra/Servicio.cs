using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
    public abstract class Servicio
    {
        public int ServicioId { get; set; }

        public string Nombre { get; set; }

        public Servicio()
        {

        }
        public Servicio(string nombre)
        {
            Nombre = nombre;
        }
        public abstract void Service();


    }
}
