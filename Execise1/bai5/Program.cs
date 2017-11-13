using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input size of the arrays :");
            var input = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[input];
            for (int i = 0; i < input; i++)
            {
                list[i] = Convert.ToInt32(Console.ReadLine());
            }

            SortList(list);
            PrintList(list);
            Console.WriteLine(Console.ReadKey());

        }

        private static void PrintList(int[] list)
        {
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        private static void SortList(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        int foo = list[i];
                        list[i] = list[j];
                        list[j] = foo;
                    }
                }
            }
        }
    }
}
