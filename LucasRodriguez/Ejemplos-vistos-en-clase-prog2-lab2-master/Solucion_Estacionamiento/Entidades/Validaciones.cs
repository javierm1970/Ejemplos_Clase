﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {


        public static string ValidarCargaStringConsola(string s, string mensajeError)
        {
            while (s == string.Empty)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensajeError);
                Console.ResetColor();
                s = Console.ReadLine();
            }
            return s;
        }
        public static int ValidarCargaEnteroConsola(string s, string mensajeError, int max, int min)
        {
            int numeroARetornar = 0;
            while (!(int.TryParse(s, out numeroARetornar)) || numeroARetornar < min || numeroARetornar > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensajeError);
                Console.ResetColor();
                s = Console.ReadLine();
            }

            return numeroARetornar;
        }
        public static double ValidarCargaDoubleConsola(string s, string mensajeError, double max, double min)
        {
            double numeroARetornar = 0;
            while (!(double.TryParse(s, out numeroARetornar)) || numeroARetornar < min || numeroARetornar > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensajeError);
                Console.ResetColor();
                s = Console.ReadLine();
            }
            return numeroARetornar;
        }

        public static bool ValidarSioNo(string v)
        {
            string respuesta = String.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(v + " SI en caso afirmativo, NO en caso negativo");
            Console.ResetColor();
            respuesta = Console.ReadLine().ToUpper();

            while (respuesta != "SI" && respuesta != "NO")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error, dato ingresado no valido");
                Console.WriteLine(v + " SI en caso afirmativo, NO en caso negativo");
                Console.ResetColor();

                respuesta = Console.ReadLine().ToUpper();
            }

            if (respuesta == "SI")
                return true;
            return false;
        }


        public static bool ValidarCargaDoubleForms(string s, double max, double min)
        {

            return (double.TryParse(s, out double numeroARetornar) && numeroARetornar > min && numeroARetornar < max);
        }
        public static bool ValidarCargaEnteroForms(string s, int max, int min)
        {
            return (int.TryParse(s, out int numeroARetornar) && numeroARetornar > min && numeroARetornar < max);
        }
        public static bool ValidarCargaStringForms(string s)
        {
            return !(string.IsNullOrEmpty(s));
        }

    }
}
