using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a full name : ");
            var name = Convert.ToString(Console.ReadLine());
            var formatedName = FormatName(name);
            Console.WriteLine("Output name : " + formatedName);
            Console.ReadKey();
        }

        private static string FormatName(string name)
        {
            return "";
        }
    }
}
