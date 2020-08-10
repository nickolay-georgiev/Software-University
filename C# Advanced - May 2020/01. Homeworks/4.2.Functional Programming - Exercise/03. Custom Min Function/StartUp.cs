using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            Func<int[], int> smallestNumber = x => x.Min();

            var result = smallestNumber(input);

            Console.WriteLine(result);
        }
    }
}
