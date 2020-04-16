using Ejercicio_13;
using Ejercicio_22_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22_Biblioteca
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numeroBin)
        {
            this.numero = numeroBin;
        }
        public static string operator +(NumeroBinario num_bin,NumeroDecimal num_dec)
        {
            return Conversor.DecimalBinario((int)(num_dec.numero + (double)Conversor.BinarioDecimal(num_bin.numero)));
        }
        public static string operator -(NumeroBinario num_bin,NumeroDecimal num_dec)
        {
            return Conversor.DecimalBinario((int)((double)Conversor.BinarioDecimal(num_bin.numero) - num_dec.numero));
        }
        public static bool operator ==(NumeroBinario num_bin,NumeroDecimal num_dec)
        {
            return ((double)Conversor.BinarioDecimal(num_bin.numero) == num_dec.numero);
        }
        public static bool operator !=(NumeroBinario num_bin,NumeroDecimal num_dec)
        {
            return (!((double)Conversor.BinarioDecimal(num_bin.numero) == num_dec.numero));
        }
        public static implicit operator NumeroBinario(string num_bin)
        {
            return new NumeroBinario(num_bin);
        }
        public static explicit operator string(NumeroBinario num_bin)
        {
            return num_bin.numero.ToString();
        }
    }
}
