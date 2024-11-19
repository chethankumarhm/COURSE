using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharp_programs
{
    internal class primeNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter maximum number");
            int maxNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i <= maxNumber; i++)
            {
                int num = i;
                Boolean flag = true;
                for (int a = 2; a <= num / 2; a++)
                {
                    if (num % a == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("It is not a prime number = " + num);
                }
                else
                {
                    Console.WriteLine("It is a prime number = " + num);
                }
            }
        }
    }
}
