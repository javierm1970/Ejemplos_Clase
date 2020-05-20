using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_Biblioteca;
namespace TestFerreteria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inventario ferreteria1 = new Inventario();

            //Console.WriteLine(Tienda.MostrarProductos(Tienda.MostrarInventario(),"Productos del inventario"));

            Console.WriteLine(Tienda.Inventario.MostrarPedido());
            //Console.WriteLine(Tienda.MostrarInventario());

            //Console.ReadKey();

            //Console.WriteLine(Tienda.MostrarProductos(Tienda.Inventario.ListaPedidos,"Lista de todos los Productos"));
            
            Console.ReadKey();
            
            
            
            //Producto clavo = new Buloneria(1, "ClavoZincado", 15, 100,TipoAmbito.Hogar,TipoUsuario.Principiante,
            //    1.0f, 1.0f, Buloneria.TipoRosca.NoTiene);
            //Producto bulon = new Buloneria(2, "BulonAcero", 15, 150, TipoAmbito.Hogar, TipoUsuario.Principiante,
            //    1.5f, 3.0f, Buloneria.TipoRosca.PasoGrueso);
            //Producto bulonBronce = new Buloneria(3, "BulonBronce", 15, 200, TipoAmbito.Hogar, TipoUsuario.Principiante,
            //    2.0f, 2.5f, Buloneria.TipoRosca.PasoFino);
            
            //Producto amoladora = new HerramientasElectricas(4, "Amoladora Gama", 1500, 5, TipoAmbito.Hogar,
            //    TipoUsuario.Principiante, 1, HerramientasElectricas.TipoManual.ManualMoladora);
            //Producto taladro = new HerramientasElectricas(5, "Taladro Percutor", 2500, 12, TipoAmbito.Profesional,
            //    TipoUsuario.Experimentado, 1, HerramientasElectricas.TipoManual.ManualTaladro);


            //Producto apliquePared = new MaterialesElectricos(6, "Aplique pared 3 lamparas", 500, 3, TipoAmbito.Hogar,
            //    TipoUsuario.Experimentado, "China", true, 220);
            //Producto alargue = new MaterialesElectricos(7, "Alargue 25 mts", 280, 30, TipoAmbito.Hogar,
            //    TipoUsuario.Principiante, "China", false, 220);


            //Pedido pedido1 = new Pedido();
            //Pedido pedido2 = new Pedido();
            //Pedido pedido3 = new Pedido();

            //bool pudo = (pedido1 + clavo);
            //pudo = (pedido1 + bulon);
            //pudo = (pedido1 + bulonBronce);
            
            //pudo = (pedido2 + amoladora);
            //pudo = (pedido2 + taladro);

            //pudo = (pedido3 + apliquePared);
            //pudo = (pedido3 + alargue);


            ////Console.ReadKey();

            //ferreteria1 = ferreteria1 + pedido1;
            //ferreteria1 = ferreteria1 + pedido2;
            //ferreteria1 = ferreteria1 + pedido3;

            //Console.WriteLine(ferreteria1.MostrarPedido());

            //Console.ReadKey();
            

            //Console.WriteLine(clavo.ToString());
            //Console.WriteLine(bulon.ToString());
            //Console.WriteLine(bulonBronce.ToString());
            //Console.WriteLine(amoladora.ToString());
            //Console.WriteLine(apliquePared.ToString());

            
            //Console.WriteLine(clavo.InstruccionesDeUso());

        }
    }
}
