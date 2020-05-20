using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Biblioteca
{
    /// <summary>
    /// Clase estatica que administrara un pedidos y contendra un inventarios
    /// y sus respectivas lista para guardar un historial de las operaciones 
    /// </summary>
    public static class Tienda
    {
        /// <summary>
        /// atributos estaticos de la Tienda un inventario (lista de productos y pedidos) una lista
        /// de todos los productos ingresados en stock y no en stock y un pedido
        /// </summary>
        static Inventario inventario;
        static List<Producto> productosGral;
        static Pedido carrito;
        /// <summary>
        /// Comstructor statico que inicializa los atributos estaticos y llama a un 
        /// metodo HardCored que incorpora datos ya establecidos al sistema para su
        /// prueba y puesta a punto
        /// </summary>
        static Tienda()
        {
            Tienda.inventario = new Inventario();
            Tienda.productosGral = new List<Producto>();
            Tienda.carrito = new Pedido();
            Tienda.HardCored();
        }
        /// <summary>
        /// Propiedad estatica de solo lectura que devuelve el atributo 
        /// estatico del Tipo List<Producto> productosGral.(todos los productos)
        /// </summary>
        public static List<Producto> ListaProductosTienda
        {
            get
            {
                return Tienda.productosGral;
            }
        }
        /// <summary>
        /// Propiedad estatica de solo lectura que devuelve el atributo 
        /// estatico del Tipo List<Producto> ListaProductos (productos en stock)
        /// </summary>
        public static List<Producto> ListaProductosInventario 
        {
            get
            {
                return Tienda.inventario.ListaProductos;
            }
        }
        /// <summary>
        /// Propiedad estatica de solo lectura que devuelve el atributo 
        /// estatico del Tipo Inventario inventario
        /// </summary>
        public static Inventario Inventario
        {
            get
            {
                return Tienda.inventario;
            }
        }
        /// <summary>
        /// Propiedad estatica de solo lectura que devuelve el atributo 
        /// estatico del Tipo Pedido carrito
        /// </summary>
        public static Pedido Pedido
        {
            get
            {
                return Tienda.carrito;
            }
        }
        /// <summary>
        /// El metodo estatico MostrarProductos devolvera un reporte con un titulo 
        /// pasado como parametro de todos los productos que contenga la 
        /// lista que tambien se le pase como parametro.
        /// </summary>
        /// <param name="listaProducto"></param>
        /// <param name="tituloReporte"></param>
        /// <returns></returns>
        public static string MostrarProductos(List<Producto> listaProducto, string tituloReporte)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}",tituloReporte);
            sb.Append("\n");
            sb.Append('-', 80);
            sb.Append("\n");
            foreach (Producto item in listaProducto)
            {
                sb.AppendFormat("\n{0}", item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// El metodo estatico MostrarProductos devolvera un reporte con un titulo 
        /// pasado como parametro de todos los 
        /// pedidos que contenga. A su vez cada pedido sera desglosado en
        /// cada producto que este ultimo contenga.
        /// dicho pedido con su fecha y total del pedido.
        /// </summary>
        /// <returns></returns>
        public static string MostrarInventario()
        {
            return Tienda.inventario.MostrarPedido();
        }
        /// <summary>
        /// El metodo estatico AgregarAlCarrito controlara cada vez
        /// que se quiera agregar un producto a un pedido. y actualizara
        /// el stock del producto y si este producto se quedara sin stock
        /// lo eliminara de la lista de productos en stock del inventario
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool AgregarAlCarrito(Producto p)
        {
            if (p.Stock > 0)
            {
                p.Stock--;
                if (!(p.Stock > 0))
                {
                    Tienda.QuitarProductoDeInventario(p);
                }
                if (Tienda.carrito + p)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// El metodo estatico QuitarDelCarrito controlara cada vez
        /// que se quiera quitar un producto a un pedido. y actualizara
        /// el stock del producto y si este producto no se encontrara en el 
        /// listado de productos del inventario por quedarse sin stock se lo
        /// reincorporara al mismo. 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool QuitarDelCarrito(Producto p)
        {
            Producto p2;
            p.Stock++;
            if (Tienda.carrito==p)
            {
                if(Tienda.carrito - p)
                {
                    //busca si Producto p fue quitado del inventario x falta
                    //de stock si es asi, cuando lo saca del carrito lo agrega al inventario

                    p2 = Tienda.BuscarProducto(Tienda.inventario.ListaProductos,
                        p.Descripcion, p.TipoAmbitoH, p.TipoUsuarioH);
                    if (p2 is null)
                        Tienda.AgregarProducto(Tienda.Inventario.ListaProductos, p);

                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// El metodo estatico Comprar controlara que el pedido no este vacio
        /// y agregara el pedido al historial del inventario (lista de pedidos)
        /// vaciara el carrito 
        /// </summary>
        /// <returns></returns>
        public static bool Comprar()
        {
            int i = 0;
            foreach (Producto item in Tienda.carrito.ListaDePedidos)
            {
                i++;
            }
            if (i>0)
            {
                Tienda.inventario += Tienda.carrito;
                Tienda.VaciarCarrito();
                return true; 
            }
            return false;
        }
        /// <summary>
        /// El metodo estatico ActualizarStock controla que una compra quede
        /// incoclusa y devuelve los productos que contenga el carrito frustrado
        /// al inventario actualizando su stock. finaliza vaciando el carrito
        /// </summary>
        /// <param name="pedido"></param>
        public static void ActualizaStock(Pedido pedido)
        {
            bool loEncontro = false;
            foreach (Producto item in pedido.ListaDePedidos)
            {
                foreach (Producto item2 in Tienda.inventario.ListaProductos)
                {
                    if (item2 == item)
                    {
                        item2.Stock++;
                        loEncontro = true;
                        break;
                    }
                }
                if (!(loEncontro))
                {
                    item.Stock = 1;
                }
                bool pudo = Tienda.inventario.ListaProductos + item;
            }
            Tienda.VaciarCarrito();
        }
        /// <summary>
        /// El Metodo QuitarProductoDeInventario se encarga de quitar
        /// los productos que el stock esta igual o por debajo de 0
        /// utiliza la sobrecarga del operador - 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool QuitarProductoDeInventario(Producto p)
        {
            if (p.Stock <= 0)
            {
                if(Tienda.inventario.ListaProductos - p)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// El metodo estatico VaciarCarrito inicializa el pedido 
        /// de la tienda asignandole el valor de un nuevo pedido
        /// </summary>
        /// <returns></returns>
        public static bool VaciarCarrito()
        {
            Tienda.carrito = new Pedido();
            return true;
        }
        /// <summary>
        /// El metodo estatico MostrarCarrito llama al metodo incluido
        /// en la Clase pedido que muestra un pedido (carrito es un pedido)
        /// </summary>
        /// <returns></returns>
        public static string MostrarCarrito()
        {
            return Tienda.carrito.ObtenerPedido();
        }
        /// <summary>
        /// Metodo estatico que agrega un producto pasado por parametro
        /// dentro de una lista Producto tambien pasada como parametro
        /// </summary>
        /// <param name="listaProducto"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool AgregarProducto(List<Producto> listaProducto, Producto p)
        {
            if (listaProducto + p)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Metodo estatico BuscarProducto se encarga de comparar los
        /// campos pasados como parametros dentro de una lista de productos
        /// tambien pasada como parametro
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="descripcion"></param>
        /// <param name="tipoAmbito"></param>
        /// <param name="tipoUsuario"></param>
        /// <returns></returns>
        public static Producto BuscarProducto(List<Producto> listaProductos,
            string descripcion, TipoAmbito tipoAmbito, TipoUsuario tipoUsuario)
        {
            foreach (Producto item in listaProductos)
            {
                if (item.Descripcion==descripcion &&
                    item.TipoAmbitoH==tipoAmbito &&
                    item.TipoUsuarioH==tipoUsuario)
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Metodo estatico que harcodea datos para poder realizar pruebas con
        /// datos cargados de antemano
        /// </summary>
        static void HardCored()
        {
            //Se crean 7 objetos productos de 3 Derivadas (Buloneria - HerramientasElectricas - MaterialesElectricos)

            Producto clavo = new Buloneria(1, "Clavo Zincado x 100u", 275, 1, TipoAmbito.Hogar, TipoUsuario.Principiante,
                1.0f, 1.0f, Buloneria.TipoRosca.NoTiene);
            Producto bulon = new Buloneria(2, "Bulon Acero x 100u", 380, 15, TipoAmbito.Hogar, TipoUsuario.Principiante,
                1.5f, 3.0f, Buloneria.TipoRosca.PasoGrueso);
            Producto bulonBronce = new Buloneria(3, "Bulon Bronce x 100u", 425, 12, TipoAmbito.Hogar, TipoUsuario.Principiante,
                2.0f, 2.5f, Buloneria.TipoRosca.PasoFino);

            Producto amoladora = new HerramientasElectricas(4, "Amoladora Gama", 1500, 5, TipoAmbito.Hogar,
                TipoUsuario.Principiante, 1, HerramientasElectricas.TipoManual.ManualMoladora);
            Producto taladro = new HerramientasElectricas(5, "Taladro Percutor", 2500, 12, TipoAmbito.Profesional,
                TipoUsuario.Experimentado, 1, HerramientasElectricas.TipoManual.ManualTaladro);


            Producto apliquePared = new MaterialesElectricos(6, "Aplique pared 3 lamparas", 500, 3, TipoAmbito.Hogar,
                TipoUsuario.Experimentado, "China", true, 220);
            Producto alargue = new MaterialesElectricos(7, "Alargue 25 mts", 280, 30, TipoAmbito.Hogar,
                TipoUsuario.Principiante, "China", false, 220);


            //utilizando el metodo static AgregarProducto - se cargan los productos a la lista productos del inventario

            Tienda.AgregarProducto(Tienda.inventario.ListaProductos, clavo);
            Tienda.AgregarProducto(Tienda.inventario.ListaProductos, bulon);
            Tienda.AgregarProducto(Tienda.inventario.ListaProductos, bulonBronce);
            Tienda.AgregarProducto(Tienda.inventario.ListaProductos, amoladora);
            Tienda.AgregarProducto(Tienda.inventario.ListaProductos, taladro);
            Tienda.AgregarProducto(Tienda.inventario.ListaProductos, apliquePared);
            Tienda.AgregarProducto(Tienda.inventario.ListaProductos, alargue);

            //utilizando el metodo static AgregarProducto - se cargan los productos a la lista de Productos

            Tienda.AgregarProducto(Tienda.productosGral, clavo);
            Tienda.AgregarProducto(Tienda.productosGral, bulon);
            Tienda.AgregarProducto(Tienda.productosGral, bulonBronce);
            Tienda.AgregarProducto(Tienda.productosGral, amoladora);
            Tienda.AgregarProducto(Tienda.productosGral, taladro);
            Tienda.AgregarProducto(Tienda.productosGral, apliquePared);
            Tienda.AgregarProducto(Tienda.productosGral, alargue);

            //se crea el carrito del tipo Pedido - se cargan tres carritos y se incorporan al inventario a la lista de pedidos
            Pedido Carrito = new Pedido();

            bool pudo = (carrito + clavo);
            pudo = (carrito + bulon);
            pudo = (carrito + bulonBronce);

            Tienda.inventario = Tienda.inventario + carrito;
            //---------------------------------------------------------
            //---------------------------------------------------------
            Tienda.VaciarCarrito();

            pudo = (carrito + amoladora);
            pudo = (carrito + taladro);

            Tienda.inventario = Tienda.inventario + carrito;
            //---------------------------------------------------------
            Tienda.VaciarCarrito();

            pudo = (carrito + apliquePared);
            pudo = (carrito + alargue);

            Tienda.inventario = Tienda.inventario + carrito;
            
            Tienda.VaciarCarrito();
        }



    }
}
