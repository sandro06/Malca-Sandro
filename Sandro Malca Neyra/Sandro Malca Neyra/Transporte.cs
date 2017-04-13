using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
    class Transporte:Servicio
    {
        public Transporte()
        {

        }
        private List<Bus> _Bus;

        public List<Bus> Bus
        {
            get
            {
                return _Bus;
            }
            set
            {
                if (value.Count == 8)
                    _Bus = value;
            }
        }
        public Transporte(string nombre) : base(nombre)
        {

        }
        public Transporte(List<Bus> bus)
        {
            Bus = bus;
        }
        private TipoViaje _TipoViaje;
        public Transporte(TipoViaje tipoViaje)
        {
            _TipoViaje = tipoViaje;
        }

        private Cliente _Cliente;
        public Transporte(Cliente cliente)
        {
            _Cliente = cliente;
        }

        private LugarViaje _LugarViaje;
        public Transporte(LugarViaje lugar)
        {
            _LugarViaje = lugar;
        }
        public override void Service()
        {
            Console.WriteLine("Informacion del Pasaje: " +
                               _TipoViaje);
        }
    }
}
