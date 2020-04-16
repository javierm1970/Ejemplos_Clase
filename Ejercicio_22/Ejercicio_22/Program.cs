using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_22_Biblioteca;
using Ejercicio_13;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = string.Format("Ejercicio Nº {0:##}", 22);
            NumeroBinario num_bin1;
            NumeroBinario num_bin2;
            NumeroBinario num_bin3;
            NumeroDecimal num_dec1;
            NumeroDecimal num_dec2;
            NumeroDecimal num_dec3;

            num_bin1 = "1010";
            num_dec1 = 10;
            num_dec2 = 150;

            Console.WriteLine("numero binario: {0}  es igual?  numero Decimal: {1}  {2}", 
                num_bin1.numero, num_dec1.numero,(num_bin1==num_dec1));
            
            Console.WriteLine("numero binario: {0}  es igual?  numero Decimal: {1}  {2}", 
                num_bin1.numero, num_dec2.numero,(num_bin1==num_dec2));

            Console.ReadKey();
            
            Console.WriteLine("numero binario: {0}   numero Decimal: {1}", (string)num_bin1, (double)num_dec1);

            num_bin2 = num_bin1 + num_dec1;


            Console.WriteLine("binario: {0}   +     Decimal: {1}    total {2}    {3}",
                (string)num_bin1, (double)num_dec1, (string)num_bin2,Conversor.BinarioDecimal((string)num_bin2));

            num_dec2 = (num_dec1 + num_bin2);

            Console.WriteLine("\nbinario: {0}   +    Decimal: {1}    total {2}   {3}",
                (string)num_bin2, (double)num_dec1, (double)num_dec2,Conversor.DecimalBinario((int)num_dec2));

            num_bin3 = "101010";
            num_dec3 = 20;
            
            Console.WriteLine("\nbinario: {0}   +    Decimal: {1}    ", (string)num_bin3, (double)num_dec3);
            
            Console.ReadKey();
        }
    }
}
