using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
    public class TipoTripulación
    {
        private int _NumeroTipo;

        public int NumeroTipo
        {
            get
            {
                return _NumeroTipo;
            }
            set
            {
                if (value > 0)
                    _NumeroTipo = value;
            }
        }
        public TipoTripulación(int numeroTipo)
        {
            NumeroTipo = numeroTipo;
        }
    }
}