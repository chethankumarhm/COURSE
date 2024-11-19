using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COURSE
{
    internal class CSharp_Programs
    {
        public static void Main(string[]args)
        {
            int[] a = {2, 5, 6, 9, 3, 5, 7};
            Array.Sort(a);

            foreach (int i in a)
            {
                Console.WriteLine(i+" ");
            }

            Console.WriteLine(a[0]+" It is the smallest number");
            Console.WriteLine(a[a.Length-1] + " It is the largest number");
        }
    }
}
