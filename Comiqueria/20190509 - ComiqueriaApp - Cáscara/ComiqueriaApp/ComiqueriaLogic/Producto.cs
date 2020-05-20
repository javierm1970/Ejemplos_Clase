using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ComrobanteLogic;
using ComiqueriaApp;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        protected Producto(string descripcion, int stock, double precio)
        {
            //this.codigo = new Guid();
            this.codigo = Guid.NewGuid();


            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if(value >= 1)
                {
                    this.precio = value;
                }
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >=0)
                    this.stock = value;
            }
        }
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDescripcion: {0}", this.descripcion);
            sb.AppendFormat("\nCodicgo: {0}", this.codigo);
            sb.AppendFormat("\nPrecio: {0}", this.precio);
            sb.AppendFormat("\nStock: {0}", this.stock);

            return sb.ToString();

        }




    }
}
