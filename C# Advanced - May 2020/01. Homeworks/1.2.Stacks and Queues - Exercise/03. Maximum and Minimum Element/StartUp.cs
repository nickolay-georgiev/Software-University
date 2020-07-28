using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                int[] inputArg = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int command = inputArg[0];

                switch (command)
                {
                    case 1:
                        if (inputArg.Length > 1)
                            stack.Push(inputArg[1]);
                        break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;

                    case 3:
                        if (stack.Count > 0)
                            Console.WriteLine(stack.Max());
                        break;
                    case 4:
                        if (stack.Count > 0)
                            Console.WriteLine(stack.Min());
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
