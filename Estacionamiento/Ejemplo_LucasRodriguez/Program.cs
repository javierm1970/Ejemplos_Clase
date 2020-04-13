using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento1;

namespace Estacionamiento1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("abc123", 11222333);

            string informacionDeAuto;

            informacionDeAuto = (string)auto1;


            //Console.WriteLine(auto1.GetInformacion());
            //Console.ReadKey();
            //auto1.Setinformacion(5);
            //Console.WriteLine(auto1.GetInformacion());
            //Console.ReadKey();
            //auto1.Setinformacion("Audi");
            //Console.WriteLine(auto1.GetInformacion());
            //Console.ReadKey();

            Estacionamiento estacion1 = new Estacionamiento("sector1", 10);
            Estacionamiento estacion2 = new Estacionamiento("sector2", 5);

            Console.WriteLine(Estacionamiento.PrecioEstacionamiento());
            Console.WriteLine(Estacionamiento.PrecioEstacionamiento());
            Console.WriteLine(Estacionamiento.PrecioEstacionamiento());
            Console.WriteLine(Estacionamiento.PrecioEstacionamiento());
            Console.WriteLine(Estacionamiento.PrecioEstacionamiento());
            Console.WriteLine(Estacionamiento.PrecioEstacionamiento());
            
            
            Console.ReadKey();



        }
    }
}
