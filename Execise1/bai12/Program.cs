using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a date : ");
            string inputDate = Convert.ToString(Console.ReadLine());
            Console.WriteLine("output : " + FormatDate(inputDate));
            Console.ReadKey();
        }

        private static string FormatDate(string inputDate)
        {
            DateTime date = DateTime.ParseExact(inputDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return "ngay " + date.Day + " thang " + date.Month + " nam " + date.Year;
        }
    }
}
