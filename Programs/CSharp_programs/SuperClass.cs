using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharp_programs
{
    internal class SuperClass
    {
        public SuperClass() {
            Console.WriteLine("I am superclass constructor");
        }

        

        public virtual void add(int a,int b)
        {
            Console.WriteLine(a+b);        
        }
    }
}
