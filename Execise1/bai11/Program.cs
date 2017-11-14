using System;
using System.Collections.Generic;
using System.Globalization;
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
            var firstPos = 0;
            var lastPos = name.Length;
            while (name[firstPos] == ' ') firstPos++;
            while (name[lastPos-1] == ' ') lastPos--;
            StringBuilder formatedName = new StringBuilder();
            var isFirstLetter = true;
            for (int i = firstPos; i < lastPos; i++)
            {
                if (isFirstLetter)
                {
                    formatedName.Append(name[i] < 'a' ? name[i] : (char)(name[i] - 'a' + 'A'));
                    isFirstLetter = false;
                }
                else
                {
                    if (name[i] != ' ')
                    {
                        formatedName.Append(name[i] >= 'a' ? name[i] : (char) (name[i] + 'a' - 'A'));
                    }
                    else
                    {
                        if (name[i + 1] != ' ')
                        {
                            formatedName.Append(name[i]);
                            isFirstLetter = true;
                        }
                    }
                }
            }
            return formatedName.ToString();
        }
    }
}
