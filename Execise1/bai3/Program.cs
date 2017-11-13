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
            string result = getDayOfWeek(number);
            Console.WriteLine(result);

            Console.ReadKey();
        }
        private static string getDayOfWeek(int number)
        {
            string[] DAY_OF_WEEK = {"Invalid day", "Sunday", "Monday", "Tuesday","Wednesday",
            "Thursday", "Friday", "Satuday"};

            return number > 7 ? "Invalid day" : DAY_OF_WEEK[number];
           
        }
    }
}
