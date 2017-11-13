using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            var primeSum = SumOfPrimeNumbers(number);
            Console.WriteLine("Sum of all prime numbers from 2 to " + number + " is : " + primeSum);
            Console.ReadKey();
        }

        private static int SumOfPrimeNumbers(int number)
        {
            var sum = 0;
            for (var i = 2; i <= number; i++)
            {
                if (isPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static bool isPrime(int number)
        {
            if (number < 4)
            {
                return true;
            }
            else
            {
                for (var i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }
        }
    }
}
