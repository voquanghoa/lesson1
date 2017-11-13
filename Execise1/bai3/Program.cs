using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            // get the output day
            string result = GetDayOfWeek(number);
            Console.WriteLine(result);

            Console.ReadKey();
        }
        private static string GetDayOfWeek(int number)
        {
            if (number < 0 || number > 7)
            {
                number = 0;
            }

            string[] dayOfWeek = {"Invalid day", "Sunday", "Monday", "Tuesday","Wednesday",
            "Thursday", "Friday", "Satuday"};

            return dayOfWeek[number];
           
        }
    }
}
