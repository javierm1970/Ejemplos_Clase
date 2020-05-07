using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_Herencia_Polimorfismo
{
    public class A
    {
        public void F() { Console.WriteLine("A.F"); }

        public virtual void G() { Console.WriteLine("A.G"); }
    }
}
