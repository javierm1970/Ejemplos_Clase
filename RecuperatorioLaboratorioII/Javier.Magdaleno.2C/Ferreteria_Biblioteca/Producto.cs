using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Biblioteca
{
    /// <summary>
    /// Enumerado de TipoAmbito caracteristica de los productos segun
    /// el ambito donde se los utilice.
    /// </summary>
    public enum TipoAmbito
    {
        Profesional, Hogar
    }
    /// <summary>
    /// Enumerado de TipoUsuario caracteristica de los productos segun
    /// el tipo de usuario que los utilice.
    /// </summary>
    public enum TipoUsuario
    {
        Principiante, Experimentado, Profesional
    }
    /// <summary>
    /// Clase Producto clase base que unifica atributos y metodos comunes a 
    /// los productos de una ferreteria.
    /// </summary>
    public abstract class Producto
    {
        private int codigo;
        private string descripcion;
        private double precio;
        private int stock;
        private TipoAmbito tipoAmbito;
        private TipoUsuario tipoUsuario;

        /// <summary>
        /// Constructor de la clase Productos / si bien es una clase abstracta y no puede
        /// instanciarse permite construir los objetos de sus derivadas.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="tipoAmbito"></param>
        /// <param name="tipoUsuario"></param>
        public Producto(int codigo, string descripcion, double precio, int stock,TipoAmbito tipoAmbito, TipoUsuario tipoUsuario)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.tipoAmbito = tipoAmbito;
            this.tipoUsuario = tipoUsuario;
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado int codigo
        /// </summary>
        public int Codigo
        {
            get { 
                return this.codigo;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado string descripcion
        /// </summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado double precio
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        /// <summary>
        /// Propiedad de lectura/escritura que devuelve el atributo privado int stock
        /// y tambien le asigna un valor.
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado TipoAmbito tipoAmbito
        /// </summary>
        public TipoAmbito TipoAmbitoH
        {
            get
            {
                return this.tipoAmbito;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado TipoUsuario tipoUsuario
        /// </summary>
        public TipoUsuario TipoUsuarioH
        {
            get
            {
                return this.tipoUsuario;
            }
        }
        /// <summary>
        /// Propiedad abstracta de solo lectura que retorna el calculo del margen de ganancia 
        /// segun la Clase derivada, tomando como base el atributo precio.
        /// </summary>
        public abstract float CalcularMargenDeGanancia { get; }
        /// <summary>
        /// Metodo abstracto que implementa para cada devirada un manual de instrucciones
        /// </summary>
        /// <returns></returns>
        public abstract string InstruccionesDeUso();
        /// <summary>
        /// Sobre escritura del metodo ToString que devuelve los datos de contenidos
        /// en los atributos comunes de todos los productos.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Codigo: {0}", this.Codigo));
            sb.AppendLine(string.Format("Descripcion: {0}", this.Descripcion));
            sb.AppendLine(string.Format("Precio: {0} pesos / Margen de Ganancia: {1}"
                ,this.Precio,this.CalcularMargenDeGanancia));
            sb.AppendLine(string.Format("Cantidad en Stock: {0} unidades", this.Stock));
            sb.AppendLine(string.Format("Ambito: {0}", this.TipoAmbitoH));
            sb.AppendLine(string.Format("Nivel de Usuario: {0}", this.TipoUsuarioH));
            
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador + que realiza la incorporacion de un producto 
        /// a una lista de productos. devuelve true si la operacion fue exitosa y 
        /// false sino lo fue.
        /// </summary>
        /// <param name="listaP"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(List<Producto> listaP, Producto p)
        {
            foreach (Producto item in listaP)
            {
                if (item == p)
                {
                    return false;
                }
            }
            listaP.Add(p);
            return true;
        }
        /// <summary>
        /// Sobrecarga del operador - que remueve un producto de
        /// una lista de productos. devuelve true si la operacion fue exitosa y 
        /// false sino lo fue.
        /// </summary>
        /// <param name="listaP"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator -(List<Producto> listaP, Producto p)
        {
            foreach (Producto item in listaP)
            {
                if (item == p)
                {
                    listaP.Remove(p);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador == compara 2 productos 
        /// son iguales si coinciden su descripcion, TipoAmbito y TipoUsuario
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Producto p1, Producto p2)
        {
            if (p1.Descripcion == p2.Descripcion &&
                p1.TipoAmbitoH == p2.TipoAmbitoH &&
                p1.TipoUsuarioH == p2.TipoUsuarioH)
            {
                return true;
            }
            return false;
        }
        public static bool operator != (Producto p1, Producto p2)
        {
            return (!(p1 == p2));
        }
    }
}
