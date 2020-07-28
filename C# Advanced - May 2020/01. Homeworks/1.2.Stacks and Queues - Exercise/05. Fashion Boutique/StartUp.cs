using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothesInTheBox);
            int sum = 0;
            int rackCounter = 1;

            while (stack.Count > 0)
            {
                sum += stack.Peek();

                if (sum <= rackCapacity)
                {
                    stack.Pop();
                }
                else
                {
                    rackCounter++;
                    sum = 0;

                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
