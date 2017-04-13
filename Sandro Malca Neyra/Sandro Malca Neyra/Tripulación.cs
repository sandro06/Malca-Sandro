using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
    class Tripulación:Empleado
    {
        public DateTime FechaRegistro { get; set; }

        public void Identificarse()
        {
            Console.WriteLine("Soy parte de la tripulación, " + " mi numero de DNI es " + this.DNI);
        }
        public Tripulación()
        {

        }
        public Tripulación(string dni) : base(dni){

        }
        private List<TipoTripulación> _TipoTripulacion;

        public Tripulación(int numTipoTripulacion)
        {
            _TipoTripulacion = new List<TipoTripulación>(numTipoTripulacion);
        }
    }
}
