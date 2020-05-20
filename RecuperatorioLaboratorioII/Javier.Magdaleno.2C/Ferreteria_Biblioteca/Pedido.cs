using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Biblioteca
{
    /// <summary>
    /// Clase que contendra el modelo de una nota de pedido
    /// constara de una fecha y un total del pedido, contendra una
    /// lista de productos (renglones en una nota de pedidos)
    /// </summary>
    public class Pedido
    {
        /// <summary>
        /// Atributos de la Clase pedido fecha precio y lista de productos
        /// </summary>
        private DateTime fecha;
        private double precioFinal;
        private List<Producto> listaProductoPedidos;
        /// <summary>
        /// constructor por defecto inicializara el atributo fecha con la fecha
        /// actual del sistema e inicializara la lista de productos
        /// </summary>
        public Pedido()
        {
            listaProductoPedidos = new List<Producto>(); 
            this.fecha = DateTime.Now;
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado tipo DateTime fecha
        /// </summary>
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado 
        /// tipo List<Producto> listaProductoPedidos 
        /// </summary>
        public List<Producto> ListaDePedidos
        {
            get
            {
                return this.listaProductoPedidos;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado tipo double precioFinal
        /// </summary>
        public double PrecioFinalPedido
        {
            get
            {
                return this.precioFinal;
            }
        }
        /// <summary>
        /// Metodo que calcula el precio final = precio del producto + tasa de ganancia
        /// de cada clase derivada y lo acumula para obtener un precio final del pedido
        /// </summary>
        /// <param name="precioProducto"></param>
        public void CalcularPrecioFinal(double precioProducto)
        {
            this.precioFinal += precioProducto ;
        }
        /// <summary>
        /// Metodo que devuelve un string donde detalla los campos de la clase
        /// fecha, cada item incluido en la lista de productos (renglones) y 
        /// precio final.
        /// </summary>
        /// <returns></returns>
        public string ObtenerPedido()
        {
            StringBuilder sb = new StringBuilder();
            double precioTotal=0;

            sb.AppendFormat("\nFecha Pedido: {0}", this.fecha.ToShortDateString());
            foreach (Producto item in this.listaProductoPedidos)
            {
                sb.AppendFormat("\n{0}  {1}  {2}  {3}", item.Codigo, item.Descripcion, item.Precio,item.CalcularMargenDeGanancia);
                precioTotal += (item.Precio+item.CalcularMargenDeGanancia);
            }
            sb.AppendFormat("\n Total del Pedido: {0}",precioTotal);
            sb.Append("\n");
            sb.Append('-', 80);
            sb.Append("\n");
            
            return sb.ToString();
        }
        /// <summary>
        /// sobrecarga del operadot == compara si un pedido es igual a un 
        /// producto dando true si este ultimo esta contenido en la lista
        /// y false si no lo esta.
        /// </summary>
        /// <param name="pedido"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool operator ==(Pedido pedido, Producto p1)
        {
            foreach (Producto item in pedido.listaProductoPedidos)
            {
                if (item==p1)
                {
                    return true;
                } 
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != necesaria por sobrecargar el ==
        /// devuelve lo contrario al ==. True si el producto no esta contenido en la 
        /// lista y false si lo esta.
        /// </summary>
        /// <param name="pedido"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool operator !=(Pedido pedido, Producto p1)
        {
            return !(pedido == p1);
        }
        /// <summary>
        /// Sobrecarga del operador + devolvera True si el producto es
        /// cargado dentro de la lista y false si no es posible.
        /// </summary>
        /// <param name="pedido"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Pedido pedido, Producto p)
        {
            if (!(pedido is null || p is null))
            {
                pedido.listaProductoPedidos.Add(p);
                pedido.CalcularPrecioFinal(p.Precio);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador - devolvera True si el producto es
        /// quitado de la lista y false si no es posible quitarlo.
        /// </summary>
        /// <param name="pedido"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator -(Pedido pedido, Producto p)
        {
            if (pedido == p)
            {
                pedido.listaProductoPedidos.Remove(p);
                pedido.CalcularPrecioFinal(p.Precio*-1);
                return true;
            }
            return false;
        }
    }
}
