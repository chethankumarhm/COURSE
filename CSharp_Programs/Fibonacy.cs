using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharp_programs
{
    internal class Fibonacy
    { 
        public static void Main()
        {
            int itteration=int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 0;

            for (int i = 0; i < itteration; i++)
            {
                sum = a + b;
                Console.WriteLine(sum);
                a++;
                b++;
            }
        }
    }
}
