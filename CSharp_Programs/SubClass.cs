using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharp_programs
{
    internal class SubClass : SuperClass
    {
        public SubClass() {
            Console.WriteLine("I am Subclass constructor");
        }

        public override void add(int a, int b)
        {
            Console.WriteLine("Overridden");
        }


        public static void Main(string[] args)
        {
            SubClass a= new SubClass();
            a.add(1,2);

            SuperClass b=new SuperClass();
            b.add(3,4);

            SuperClass upcast = new SubClass();
            upcast.add(5,6);
        }
    }
}
