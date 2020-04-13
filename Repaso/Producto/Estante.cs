using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ProductoEstante;

namespace ProductoEstante

{
    public class Estante
    {
        private Producto[] productos;
        private int UbicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.UbicacionEstante = ubicacion;
        }
        public Producto[] GetProducto()
        {
            return this.productos;
        }
        
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            
            if (!(e.productos is null))
            {
                sb.AppendFormat("La Ubicación en el estante es: {0}  \n",e.UbicacionEstante);
                
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (!(e.productos[i] is null))
                    {
                        sb.AppendFormat("{0,-15} {1,20} {2,20}  \n",e.productos[i].GetMarca(),(string)e.productos[i],e.productos[i].GetPrecio());
                    }
                }
            }
            else
            {
                sb.AppendLine("No se encontraron articulos en el estante");
            }
            return sb.ToString();
        }

        #region Operadores

        public static bool operator == (Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    return (e.productos[i]==p);
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        
        public static Estante operator - (Estante e, Producto p)
        {
            
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    Array.Clear(e.productos, i, 1);
                    return e;
                }
            }
            return e;
        }
        
        public static bool operator + (Estante e,Producto p)
        {
            for(int i = 0; i < e.productos.Length; i++)
            {
                if(e.productos[i] is null)
                {
                    e.productos[i] = p;
                    return true;
                }
            }
            return false;
        }
        
        
        #endregion


    }
}
