﻿using ComiqueriaApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ComrobanteLogic;
namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        

        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }
        public Producto this[Guid codigo]
        {
            get
            {
                if (!(this.productos is null))
                {
                    foreach (Producto item in this.productos)
                    {
                        if ((Guid)item == codigo)
                        {
                            return item;
                        }
                    }
                }
                return null;
            }
        }
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> respuesta = new Dictionary<Guid, string>();

            foreach (Producto producto in this.productos)
            {
                respuesta.Add((Guid)producto, producto.Descripcion);
            }

            return respuesta;
        }

        //public Dictionary<Guid, string> ListarProductos()
        //{
        //    bool flagEncontrado = false;
        //    Dictionary<Guid, string> nuevoDic = new Dictionary<Guid, string>();
        //    if (!(this.ventas is null))
        //    {
        //        foreach (Producto item in this.productos)
        //        {
        //            foreach (KeyValuePair<Guid, string> item2 in nuevoDic)
        //            {
        //                if (item2.Key == (Guid)item)
        //                {
        //                    flagEncontrado = true;
        //                    break;
        //                }
        //                flagEncontrado = false;
        //            }
        //            if (!(flagEncontrado))
        //            {
        //                nuevoDic.Add((Guid)item, item.Descripcion);
        //            }
        //        }
        //    }
        //    return nuevoDic;
        //}
        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            if (!(this.ventas is null))
            {
                foreach (Venta item in this.ventas)
                {
                    sb.AppendFormat("\n{0}",item.ObtenerDescripcionBreve());
                }
            }
            else
            {
                sb.AppendLine("No se encontraron Ventas");
            }
            return sb.ToString();
        }
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }
        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            if (!(comiqueria is null || producto is null))
            {
                foreach (Producto item in comiqueria.productos)
                {
                    if (item.Descripcion == producto.Descripcion)
                    {
                        return comiqueria == producto;
                    }
                }
            }
            return false;
        }
        public static bool operator != (Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            bool encontrado = false;
            if (comiqueria != null && producto != null)
            {
                foreach (Producto item in comiqueria.productos)
                {
                    if (item == producto)
                    {
                        encontrado = true;
                    }
                }
            }
            if (!(encontrado))
            {
                comiqueria.productos.Add(producto); 
            }
            return comiqueria;
        }
    }






}
