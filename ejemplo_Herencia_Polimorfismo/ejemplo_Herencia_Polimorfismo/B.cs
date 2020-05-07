using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_Herencia_Polimorfismo
{
    public class B : A
    {
        new public void F() { Console.WriteLine("B.F"); }

        public override void G() { Console.WriteLine("B.G"); }
    }
}
