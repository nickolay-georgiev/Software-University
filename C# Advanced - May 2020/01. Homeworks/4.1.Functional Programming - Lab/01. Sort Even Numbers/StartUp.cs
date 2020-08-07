using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Func<int, bool> func = x => x % 2 == 0;

            var filteredNumbers = input.Where(func).ToList();
            filteredNumbers.Sort();

            Console.WriteLine(string.Join(", ", filteredNumbers));
        }
    }
}
