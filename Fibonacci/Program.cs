using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibNumbers = InitFibNumbers();

            PrintFibNumbers(fibNumbers);
        }

        public static void PrintFibNumbers(List<int> fibNumbers)
        {
            Console.WriteLine();
            foreach(var item in fibNumbers)
            {
                Console.Write($"{item} ");
            }
        }

        public static List<int> InitFibNumbers()
        {
            var fibNumbers = new List<int> {1, 1};

            do
            {
                var previous = fibNumbers[fibNumbers.Count - 1];
                var previous2 = fibNumbers[fibNumbers.Count - 2];

                fibNumbers.Add(previous + previous2);
            } while (fibNumbers.Count < 20);

            return fibNumbers;
        }
    }
}
