using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductoEstante;


namespace Ejercico_05
{
    class Program
    {
        static void Main(string[] args)
        {
			// Creo un estante 
			Estante estante = new Estante(3, 1);
			// Creo 4 productos 
			Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
			Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
			Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
			Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);
			
			Producto p5 = new Producto("Pepsi", "PESDS97413", (float)18.5);
			Producto p6;

			Console.WriteLine("{0}", (p1 == p2));
			Console.WriteLine("{0}", (p1.GetMarca() == p2.GetMarca()));
			Console.WriteLine("{0}", (p1 == p5));
			Console.WriteLine("{0}", (p1.GetMarca() == p5.GetMarca()));

			Console.WriteLine("{0}", (p1 != p2));
			Console.WriteLine("{0}", (p1.GetMarca() != p2.GetMarca()));
			Console.WriteLine("{0}", (p1 != p5));
			Console.WriteLine("{0}", (p1.GetMarca() != p5.GetMarca()));

			Estante estantePrueba = new Estante(5, 2);

			Producto [] produtoPrueba;
			produtoPrueba = new Producto[5];

			produtoPrueba[0] = p2;

			if (produtoPrueba is null)
				Console.WriteLine("Esta vacio");
			else
			{
				Console.WriteLine(produtoPrueba.Length);
				p6 = produtoPrueba[0];
				Console.WriteLine("Esto es producto 6: {0} {1} {2}", p6.GetMarca(), (string)p6, p6.GetPrecio());
				Console.WriteLine("No esta vacio");
			}

			if (estantePrueba + p1)
			{
				Console.WriteLine("Articulo agragado");
			}
			if (estantePrueba + p2)
			{
				Console.WriteLine("Articulo agragado");
			}
			if (estantePrueba + p3)
			{
				Console.WriteLine("Articulo agragado");
			}
			
			Console.WriteLine(Estante.MostrarEstante(estantePrueba));

			estantePrueba = (estantePrueba - p2);
			//
			Console.WriteLine(Estante.MostrarEstante(estantePrueba));

			estantePrueba = (estantePrueba - p3);
			Console.WriteLine(Estante.MostrarEstante(estantePrueba));

			if (estantePrueba + p4)
			{
				Console.WriteLine("Articulo agragado");
			}
			if (estantePrueba + p2)
			{
				Console.WriteLine("Articulo agragado");
			}
			if (estantePrueba + p3)
			{
				Console.WriteLine("Articulo agragado");
			}
			if (estantePrueba + p4)
			{
				Console.WriteLine("Articulo agragado");
			}

			Console.WriteLine(Estante.MostrarEstante(estantePrueba));
			Console.ReadKey();
			/*
			// Agrego los productos al estante 
			
			if (estante + p1)
			{
				Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
			}
			else
			{
				Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
			}
			if (estante + p1)
			{
				Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
			}
			else
			{
				Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
			}
			if (estante + p2)
			{
				Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
			}
			else
			{
				Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
			}
			if (estante + p3)
			{
				Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
			}
			else
			{
				Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
			}
			if (estante + p4)
			{
				Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
			}
			else
			{
				Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
			}

			// Muestro todo el estante 
			Console.WriteLine();
			Console.WriteLine("<------------------------------------------------->");
			
			Console.WriteLine(Estante.MostrarEstante(estante));
			*/
			Console.ReadKey();
		}
    }
}
