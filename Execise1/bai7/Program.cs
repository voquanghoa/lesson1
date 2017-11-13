using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            var fiboIndex = Convert.ToInt32(Console.ReadLine());
            var fiboNumber = GetFiboNumber(fiboIndex);
            Console.WriteLine("The fibonaci number in index " + fiboIndex + " is : " + fiboNumber);
            Console.ReadKey();
        }

        private static int GetFiboNumber(int index)
        {
            if (index <=2)
            {
                return 1;
            }
            return GetFiboNumber(index - 1) + GetFiboNumber(index - 2);
        }
    }
}
