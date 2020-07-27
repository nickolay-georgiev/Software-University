using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>();

            foreach (var currentNumber in inputNums)
            {
                if (currentNumber % 2 == 0)
                {
                    numbers.Enqueue(currentNumber);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
