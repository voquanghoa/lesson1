using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.Write("input a number : " );
            int number = Convert.ToInt32(Console.ReadLine());
            // get the output day
            string dayOfWeek = GetDayOfWeek(number);
            Console.WriteLine(dayOfWeek);
            Console.ReadKey();
        }

        // get day of week 
        private static string GetDayOfWeek(int number)
        {
            if (number == 1)
                return "Sunday";
            else if (number == 2)
                return "Monday";
            else if (number == 3)
                return "Tuesday";
            else if (number == 4)
                return "Wednesday";
            else if (number == 5)
                return "Thursday";
            else if (number == 6)
                return "Friday";
            else if (number == 7)
                return "Satuday";
            else return "Invalid day";
        }
    }
}
