using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
    public class TipoViaje
    {
        string categoria1="Normal";
        string tipoViaje1 = "Bus Normal";
        string categoria2 = "VIP";
        string tipoViaje2 = "Bus VIP";
        public void TipoCat()
        {

            Console.WriteLine("Pasaje 1: \nCategoria: " + categoria1 + "    "+"Bus: " + tipoViaje1);
            Console.WriteLine("Pasaje 2: \nCategoria: " + categoria2 + "    "+"Bus: " + tipoViaje2);
            Console.WriteLine("Pasaje 3: \nCategoria: " + categoria2 + "    "+"Bus: " + tipoViaje2);
        }
        }
    }
      

