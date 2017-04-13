using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
    class Administrativo:Empleado
    {
        public DateTime FechaRegistro { get; set; }

        public void Identificarse()
        {
            Console.WriteLine("Soy un cliente, "+ " mi numero de DNI es "+ this.DNI);
        }
        public Administrativo()
        {

        }
        public Administrativo(string dni) : base(dni){

        }
    }
}
