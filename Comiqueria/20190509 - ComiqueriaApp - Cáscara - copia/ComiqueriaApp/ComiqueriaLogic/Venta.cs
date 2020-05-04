using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaApp
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        Producto producto;

        static Venta()
        {
            porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }
        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioSinIva;
            precioSinIva = precioUnidad * cantidad;
            return precioSinIva += precioSinIva * (porcentajeIva / 100);
        }
        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1} - {2,.2f}",this.fecha ,this.producto.Descripcion,(float)(this.precioFinal));
            return sb.ToString();
        }
        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.precioFinal,cantidad);
        }
    }
}
