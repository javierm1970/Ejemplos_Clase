﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repaso_Estacionamiento
{
    public static class LogicaPrograma
    {

        private static Estacionamiento instanciaEstacionamiento;

        static LogicaPrograma()
        {
            instanciaEstacionamiento = LogicaPrograma.CrearEstacionamiento();
        }

        public static void Iniciar()
        {
            do
            {
                Console.Clear();
                MostrarMenu();

            } while (!seleccionarOpcion());

            LogicaPrograma.Continuar("Nos vemos pronto!! \n Presione una tecla para finalizar");
        }

        public static Estacionamiento CrearEstacionamiento()
        {
            string nombre = string.Empty;
            int capacidad = 0;
            double precio = 0;

            Menues.MostrarCabecera("**Alta inicial Estacionamiento **", '*');
     
            Console.WriteLine("\nIngresar nombre estacionamiento");
            nombre = Validaciones.ValidarCargaStringConsola(Console.ReadLine(), "Error,reingrese un nombre valido para su estacionamiento");

            Console.WriteLine("\ningresar capacidad del estacionamiento");
            capacidad = Validaciones.ValidarCargaEnteroConsola(Console.ReadLine(), "Error,capacidad no valida.Maximo 100 ", int.MaxValue, 1);

            Console.WriteLine("\ningresar precio en pesos por dia del estacionamiento");
            precio = Validaciones.ValidarCargaDoubleConsola(Console.ReadLine(), "Error,numero no valido.Debe ser mayor a 1 peso",double.MaxValue,1);

            return new Estacionamiento(nombre, capacidad, precio);

        }

        public static void MostrarMenu()
        {

           Menues.MostrarCabecera($"BIENVENIDOS AL ESTACIONAMIENTO: { instanciaEstacionamiento.RetornarNombre().ToUpper()}", '*');
           Console.ResetColor();
           Console.WriteLine($"\nSeleccione una opcion para continuar\n");
           Console.WriteLine(" 1. Ver informacion total del estacionamiento");
           Console.WriteLine(" 2. Agregar nuevo auto");
           Console.WriteLine(" 3. Salir");
        }

        public static void Continuar(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.ReadKey();
            Console.Clear();
        }

        public static bool seleccionarOpcion()
        {
            bool salir = false;
            bool opcionIncorrecta = false;
            do
            {
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        Console.Clear();
                        Menues.MostrarCabecera("1. informacion total del estacionamiento ", '*');
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(instanciaEstacionamiento.MostrarEstacionamiento());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        LogicaPrograma.Continuar("\n\nPresione una tecla para continuar");
                        Console.ResetColor();
                        opcionIncorrecta = false;
                        break;
                    case "2":
                        Console.Clear();
                        Menues.MostrarCabecera("2. Agregar auto ", '*');
                        LogicaPrograma.AgregarAutoAlEstacionamiento();
                        LogicaPrograma.Continuar("Presione una tecla para continuar");
                        opcionIncorrecta = false;
                        break;

                    case "3":
                        salir = LogicaPrograma.Salir("Desea salir del programa?");
                        opcionIncorrecta = false;
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta, por favor reingrese");
                        opcionIncorrecta = true;
                        break;
                }
            } while (opcionIncorrecta);

            return salir;
        }

        private static bool Salir(string mensaje)
        {

            return Validaciones.ValidarSioNo(mensaje);
      
        }

        private static Auto CrearAuto()
        {
            string patente = string.Empty;
            string marca = string.Empty;
            int cantidadPuertas = 0;
            int dniDueño = 0;

            Console.WriteLine("Ingresar patente auto");
            patente = Validaciones.ValidarCargaStringConsola(Console.ReadLine(), "Error,reingrese un nombre valido para la patente");

            Console.WriteLine("ingresar DNI dueño ");
            dniDueño = Validaciones.ValidarCargaEnteroConsola(Console.ReadLine(), "Error,dni no valido. Debe estar entre   1.000.000 Y 999.999.999 ", 999999999, 1000000);

            if (LogicaPrograma.Salir("\n\n ¿Desea ingresar marca y cantidad de puertas?"))
            {
                Console.WriteLine("\nIngresar marca auto");
                marca = Validaciones.ValidarCargaStringConsola(Console.ReadLine(), "Error,reingrese un nombre valido para la marca");

                Console.WriteLine("ingresar cantidad de puertas del estacionamiento");
                cantidadPuertas = Validaciones.ValidarCargaEnteroConsola(Console.ReadLine(), "Error,cantidad de puertas no valida", 5, 2);
               
                return new Auto(patente, marca, cantidadPuertas, dniDueño);
            }

            return new Auto(patente, dniDueño);
        }

        private static void AgregarAutoAlEstacionamiento()
        {
            if (instanciaEstacionamiento.tieneCapacidadLibre() > 0)
            {
                if (instanciaEstacionamiento + LogicaPrograma.CrearAuto()) // instanciaEsta + unAuto
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nAuto agregado perfectamente!\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\nEl auto no ha podido ser agregado porque ya existe\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEl auto no ha podido ser agregado porque no hay capacidad en el Estacionamiento\n");
            }

            Console.ResetColor();
        }

    }
}
