using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            var numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("input another number : ");
            var numberB = Convert.ToInt32(Console.ReadLine());
            var revertedSum = RevertSum(numberA, numberB);
            Console.WriteLine("Sum of the two numbers afther reverted : " +  revertedSum);
            Console.ReadKey();
        }

        private static string RevertSum(int a, int b)
        {
            return new string(Convert.ToString(a + b).ToCharArray().Reverse().ToArray());
        }
    }
}
