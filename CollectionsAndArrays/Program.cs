using System;
using System.Collections.Generic;

namespace CollectionsAndArrays
{
    class Program
    {
        public static void PrintNamesInList(List<string> names)
        {
            Console.WriteLine();

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
        }

        public static void PrintNumbersInList(List<int> nums)
        {
            Console.WriteLine();

            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }
        }
        public static void PrintNamesTotalAndInfo(List<string> names)
        {
            Console.WriteLine();
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I added {names[2]} and {names[3]}.");

            Console.WriteLine();
            Console.WriteLine($"WOW THAT IS A TOTAL OF {names.Count} NAMES!");

        }

        public static List<string> EditNamesList(List<string> names)
        {
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            return names;
        }

        public static void OrderedNumbers()
        {

        }

        public static List<string> InitNamesList()
        {
            return new List<string> { "MCCORDINATOR", "Ana", "Felipe" };
        }

        public static List<int> InitNumbersList()
        {
            return new List<int> { 0, 1, 2, 3, 10, 11, 20, 21, 30, 31, 32 };
        }
        static void Main(string[] args)
        {
            var names = InitNamesList();
            var nums = InitNumbersList();

            PrintNamesInList(names);
            names = EditNamesList(names);
            PrintNamesInList(names);
            PrintNamesTotalAndInfo(names);
            nums.Sort();
            PrintNumbersInList(nums);
        }
    }
}
