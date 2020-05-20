using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Biblioteca
{
    /// <summary>
    /// Clase encargada de contener la lista de productos en Stock
    /// y la lista de todos los pedidos atendidos
    /// </summary>
    public class Inventario
    {
        /// <summary>
        /// Atributos de tipo List <Producto> y <Pedidos> 
        /// </summary>
        protected List<Producto> productos;
        protected List<Pedido> pedidos;
        /// <summary>
        /// Constructor por defecto que inicializa ambas listas
        /// </summary>
        public Inventario()
        {
            productos = new List<Producto>();
            pedidos = new List<Pedido>();
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado 
        /// tipo List<Producto> productos 
        /// </summary>
        public List<Producto> ListaProductos
        {
            get
            {
                return this.productos;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado 
        /// tipo List<Pedidos> pedidos 
        /// </summary>
        public List<Pedido> ListaPedidos
        {
            get
            {
                return this.pedidos;
            }
        }
        /// <summary>
        /// Metodo que imprime los pedidos (lista) incluidos en la lista pedidos del 
        /// inventario. se nutre del metodo ObtenerPedido que devuelve un pedido
        /// requerido
        /// </summary>
        /// <returns></returns>
        public string MostrarPedido()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Pedido item in this.pedidos)
            {
                sb.AppendFormat(item.ObtenerPedido());
                sb.AppendLine();
                sb.Append('*', 60);
            }
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador + devolvera True si el pedido es
        /// cargado dentro de la lista y false si no es posible.
        /// </summary>
        /// <param name="inventario"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static Inventario operator + (Inventario inventario, Pedido pedido)
        {
            foreach (Pedido item in inventario.pedidos)
            {
                if (item == pedido)
                {
                    return inventario;
                }
            }
            inventario.pedidos.Add(pedido);
            return inventario;
        }
        /// <summary>
        /// Sobrecarga del operador == devolvera True si el pedido esta
        /// incluido dentro de la lista de pedidos del inventario 
        /// y false si no lo esta.
        /// </summary>
        /// <param name="inventario"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool operator == (Inventario inventario, Pedido pedido)
        {
            foreach (Pedido item in inventario.pedidos)
            {
                if (item.Fecha == pedido.Fecha && 
                    item.PrecioFinalPedido==pedido.PrecioFinalPedido) 
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != devolvera True si el pedido no esta
        /// incluido dentro de la lista de pedidos del inventario 
        /// y false si lo esta.
        /// </summary>
        /// <param name="inventario"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool operator != (Inventario inventario, Pedido pedido)
        {
            return !(inventario == pedido);
        }
        /// <summary>
        /// Sobrecarga del operador == devolvera True si el Producto esta
        /// incluido dentro de la lista de pedidos dentro del inventario 
        /// y false si no lo esta.
        /// </summary>
        /// <param name="inventario"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool operator == (Inventario inventario, Producto p1)
        {
            foreach (Producto item in inventario.productos)
            {
                if (item==p1)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador == devolvera False si el Producto esta
        /// incluido dentro de la lista de pedidos dentro del inventario 
        /// y True si no lo esta.
        /// </summary>
        /// <param name="inventario"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool operator !=(Inventario inventario, Producto p1)
        {
            return !(inventario == p1);
        }
    }
}
