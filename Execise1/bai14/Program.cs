using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("output : " + Sum(number));
            Console.ReadKey();
        }

        private static long Sum(int number)
        {
            var sum = 0L;
            for (var i = 1; i <= number; i++)
            {
                sum += i*(i+1);
            }
            return sum;
        }
    }
}
