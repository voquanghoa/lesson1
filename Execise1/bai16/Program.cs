using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
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

        private static double Sum(int number)
        {
            var sum = 0.0;
            var tempt = 1;
            for (var i = 1; i <= number; i++)
            {
                tempt = tempt * i;
                sum += 1.0*tempt/i/(i+1);
            }
            return sum;
        }
    }
}
