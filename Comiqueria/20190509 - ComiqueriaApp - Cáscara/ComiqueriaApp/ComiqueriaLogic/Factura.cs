using ComiqueriaApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComrobanteLogic
{
    public class Factura : Comprobante
    {
        public enum TipoFactura
        {
            A, B, C, E
        }
        private DateTime fechaVencimiento;
        private TipoFactura tipoFactura;

        public Factura(Venta venta, int diasParaVencimiento, TipoFactura tipoFactura)
            :this(venta,tipoFactura)
        {
            
            this.fechaVencimiento = DateTime.Now.AddDays((double)diasParaVencimiento);
        }
        public Factura(Venta venta, TipoFactura tipoFactura)
            :base(venta)
        {
            this.tipoFactura = tipoFactura;
            this.fechaVencimiento = DateTime.Now.AddDays(15);
        }
        public override bool Equals(object obj)
        {
            return (obj.Equals(obj));
        }
        public override string GenerarComprobante()
        {
            throw new NotImplementedException();
        }

    }
}
