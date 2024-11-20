using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharp_programs
{
    internal class accendingOrder
    {
        public static void Main(string[] args)
        {
            int[] a = { 5, 2, 4, 8, 1 };

            for (int i = 0; i < a.Length; i++)
            { 
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j+1];   
                        a[j+1] = temp;
                    }
                }
            }
            for (int b=0;b<a.Length ;b++){
                Console.Write(a[b]+" ");
            }
        }
    }
}
