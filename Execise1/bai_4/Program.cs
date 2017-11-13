using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("input another number : ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int result = GreatestCommonDivisor(numberA, numberB);
            Console.WriteLine("Greatest Common Divisor of the 2 numbers : " + result);
            Console.ReadKey();

        }

        private static int GreatestCommonDivisor(int numberA, int numberB)
        {
            return numberB == 0 ? numberA : GreatestCommonDivisor(numberB, numberA % numberB);
        }
    }
}
