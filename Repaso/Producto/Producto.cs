using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ProductoEstante
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public string MostrarProducto(Producto p)
        {
            return p.codigoDeBarra+" - "+p.marca+" - "+p.precio.ToString();;
        }
        public static explicit operator string (Producto p)
        {
            return (string)p.codigoDeBarra;
        } 
        #region Operadores

        public static bool operator == (Producto p, string marca)
        {
            return (p.marca==marca);
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p.marca==marca);
        }
        public static bool operator == (Producto p1, Producto p2)
        {
            if (!(p1 is null) && !(p2 is null))
            {
                return (p1.codigoDeBarra + p1.marca == p2.codigoDeBarra + p2.marca);
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }


        #endregion

    }
}
