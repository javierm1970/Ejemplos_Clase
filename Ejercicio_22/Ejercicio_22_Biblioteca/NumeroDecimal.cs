using Ejercicio_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22_Biblioteca
{
    public class NumeroDecimal
    {
        public double numero;
        private NumeroDecimal(double numeroDec)
        {
            this.numero = numeroDec;

        }
        public static double operator +(NumeroDecimal num_dec, NumeroBinario num_bin)
        {
            
            return ((double)Conversor.BinarioDecimal(num_bin.numero) + num_dec.numero);
        }
        public static double operator -(NumeroDecimal num_dec, NumeroBinario num_bin)
        {
            return (num_dec.numero - (double)Conversor.BinarioDecimal(num_bin.numero));
        }
        public static bool operator ==(NumeroDecimal num_dec, NumeroBinario num_bin)
        {
            return num_bin == num_dec;
        }
        public static bool operator !=(NumeroDecimal num_dec, NumeroBinario num_bin)
        {
            return num_bin != num_dec;
        }
        public static implicit operator NumeroDecimal(double num_dec)
        {
            return new NumeroDecimal(num_dec);
        }
        public static explicit operator double(NumeroDecimal num_dec)
        {
            return (double)num_dec.numero;
        }
    }
}
