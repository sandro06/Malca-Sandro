using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro_Malca_Neyra
{
    class Venta
    {
        private Cliente _cliente;

        public Venta(Cliente cliente)
        {
            _cliente = cliente;
        }

        private Administrativo _administrativo;

        public Venta(Administrativo administrativo)
        {
            _administrativo=administrativo;
        }

        private TipoComprobante _tipoComprobante;

        public Venta(TipoComprobante tipoComprobante)
        {
            _tipoComprobante = tipoComprobante;
        }

        private TipoPago _tipoPago;

        public Venta(TipoPago tipoPago)
        {
            _tipoPago=tipoPago;
        }

        private Servicio _servicio;

        public Venta(Servicio servicio)
        {
            _servicio=servicio;
        }

    }
}
