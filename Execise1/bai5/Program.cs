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
            var arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
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

        // sort the list in increasing order
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
