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
            int number_a = Convert.ToInt32(Console.ReadLine());

            Console.Write("input another number : ");
            int number_b = Convert.ToInt32(Console.ReadLine());

            int result = gcd(number_a, number_b);
            Console.WriteLine("Greatest Common Divisor of the 2 numbers : " + result);
            Console.ReadKey();

        }

        private static int gcd(int number_a, int number_b)
        {
            return number_b == 0 ? number_a : gcd(number_b, number_a % number_b);
        }
    }
}
