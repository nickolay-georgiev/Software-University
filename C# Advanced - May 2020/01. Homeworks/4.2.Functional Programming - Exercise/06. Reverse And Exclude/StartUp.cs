using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int num = int.Parse(Console.ReadLine());

            Func<int, bool> func = x => x % num != 0;

            var result = input.Where(func).Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
