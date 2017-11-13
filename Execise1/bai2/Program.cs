using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            // get the output day
            string dayOfWeek = GetDayOfWeek(number);
            Console.WriteLine(dayOfWeek);
            Console.ReadKey();
        }

        private static string GetDayOfWeek(int number)
        {
            switch (number)
            {
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Satuday";
                default:
                    return "Invalid day";
            }
        }
    }
}
