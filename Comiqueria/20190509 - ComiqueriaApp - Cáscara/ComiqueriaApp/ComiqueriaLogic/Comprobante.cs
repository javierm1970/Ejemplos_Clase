using ComiqueriaApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComrobanteLogic
{
    public abstract class Comprobante
    {
        protected DateTime fechaEmision;
        private Venta venta;

        public Comprobante(Venta venta)
        {
            
            this.venta = venta;
            this.fechaEmision = venta.Fecha;
        }
        protected internal Venta Venta
        {
            get
            {
                return this.venta;
            }
        }
        public override bool Equals(object obj)
        {
            if(obj is Comprobante)
            {
                if (Venta.Fecha == ((Comprobante)obj).fechaEmision)
                {
                    return true;
                }
            }
            else if (obj is Factura)
            {
                if (venta.Fecha == ((Factura)obj).fechaEmision)
                {
                    return true;
                } 
            }
            return false;
        }
        public abstract string GenerarComprobante();
        


    }
}
