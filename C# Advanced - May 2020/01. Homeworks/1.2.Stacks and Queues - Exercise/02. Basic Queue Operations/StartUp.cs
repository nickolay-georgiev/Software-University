using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementsToPush = input[0];
            int elementsToPop = input[1];
            int neededElement = input[2];

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                if (0 < stack.Count)
                {
                    stack.Dequeue();
                }
            }

            if (stack.Contains(neededElement))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
