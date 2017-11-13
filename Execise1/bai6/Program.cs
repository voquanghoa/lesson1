using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three edges of a triangle : ");
            Console.Write("edge a : ");
            var edgeA = Convert.ToInt32(Console.ReadLine());
            Console.Write("edge b : ");
            var edgeB = Convert.ToInt32(Console.ReadLine());
            Console.Write("edge c : ");
            var edgeC = Convert.ToInt32(Console.ReadLine());

            var triangleType = GetTypeOfTriangle(edgeA, edgeB, edgeC);
            Console.WriteLine("It is " + triangleType);
            Console.ReadKey();
        }

        private static string GetTypeOfTriangle(int edgeA, int edgeB, int edgeC)
        {
            if ((edgeA + edgeB > edgeC) && (edgeA + edgeC > edgeB)
                && (edgeB + edgeC > edgeA))
            {
                if ((edgeA == edgeB) && (edgeA == edgeC))
                {
                    return "an equilateral Triangle";
                }
                else if ((edgeA == edgeB) || (edgeA == edgeC) || (edgeB == edgeC))
                {
                    return "an isosceles Triangle";
                }
                else
                {
                    return "a scalene Triangle";
                }
            }
            else
            {
                return "Not a triangle";
            }
        }
    }
}
