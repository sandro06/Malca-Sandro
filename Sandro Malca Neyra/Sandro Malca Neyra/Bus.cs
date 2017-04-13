using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
    class Bus
    {
        public string categoria { get; set; }
        public string conductor { get; set; }
        private List<Tripulación> _Tripulacion;

        public List<Tripulación> Tripulacion
        {
            get
            {
                return _Tripulacion;
            }
            set
            {
                if (value.Count == 8)
                    _Tripulacion = value;
            }
        }

        public Bus(List<Tripulación> tripulacion)
        {
            Tripulacion = tripulacion;
        }
        public int NumeroAsientos { get; private set; }

        public Bus(int numeroAsientos)
        {
            NumeroAsientos = numeroAsientos;
        }
    }
}
