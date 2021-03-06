﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            codigo = new Guid();
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
            sb.AppendFormat("Descripcion: {0}", this.descripcion);
            sb.AppendFormat("Codicgo: {0}", this.codigo);
            sb.AppendFormat("Precio: {0}", this.precio);
            sb.AppendFormat("Stock: {0}", this.stock);

            return sb.ToString();

        }




    }
}
