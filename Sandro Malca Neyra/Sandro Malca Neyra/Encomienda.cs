using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
   class Encomienda:Servicio
    {
        public int EncomiendaId { get; private set; }
        public int NumeroEncomienda { get; private set; }
        public Bus Bus { get; set; }

        public Encomienda()
        {

        }
        public Encomienda(string nombre) : base(nombre)
        {

        }
        public Encomienda(Bus bus)
        {
            Bus = bus;
        }

        public Encomienda(int encomiendaId)
        {
            EncomiendaId = encomiendaId;
        }

        public override void Service()
        {
            string encomienda1 = "Saco de Arroz";
            string encomienda2 = "Saco de Azucar";
            string encomienda3 = "Saco de Papas";
            Console.WriteLine("Encomienda 1: " + encomienda1 + "\nEncomienda 2: " + encomienda2);
            
        }

        private LugarViaje _lugar;

        public Encomienda(LugarViaje lugar)
        {
            _lugar = lugar;
        }
     }
}
