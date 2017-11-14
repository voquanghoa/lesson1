using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum of " + number + " powed numbers : " + SumPow(number));
            Console.ReadKey();
        }

        private static long SumPow(int number)
        {
            var sum = 0L;
            for (var i = 1; i <= number; i++)
            {
                sum += (long)Math.Pow(i, i);
            }
            return sum;
        }
    }
}
