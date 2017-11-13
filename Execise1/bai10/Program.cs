using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a string : ");
            var input = Convert.ToString(Console.ReadLine());
            var revertedString = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine("string after reverted : " + revertedString);
            Console.ReadKey();
        }
    }
}
