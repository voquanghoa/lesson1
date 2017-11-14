using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("line "+ number + " in the pascal triangle table : " + GetLineFromPascalTriangle(number));
            Console.ReadKey();
        }

        private static string GetLineFromPascalTriangle(int number)
        {
            var pascalTriangleLine = "";
            for (int i = 0; i <= number; i++)
            {
                pascalTriangleLine += ToHop(i, number) + " ";
            }
            return pascalTriangleLine;
        }

        private static int ToHop(int i, int number)
        {
            if (i == 0 || i == number)
                return 1;
            return ToHop(i, number - 1) + ToHop(i - 1, number - 1);
        }
    }
}
