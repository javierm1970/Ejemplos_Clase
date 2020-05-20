using ComrobanteLogic;
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
        private int cantidad;
        private Producto producto;

        static Venta()
        {
            porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            Vender(cantidad);
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
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
            sb.AppendFormat("\n{0} - {1} - {2}",this.fecha ,this.producto.Descripcion,(float)(this.precioFinal));
            return sb.ToString();
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.precioFinal, cantidad);

        }
        public static explicit operator Producto(Venta venta)
        {
            return venta.producto;
        }



    }
}
