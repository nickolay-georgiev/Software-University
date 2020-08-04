using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            int[] setsLenght = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstSet = setsLenght[0];
            int secondSet = setsLenght[1];

            for (int i = 0; i < firstSet; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                first.Add(nums);
            }

            for (int i = 0; i < secondSet; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                second.Add(nums);
            }

            foreach (var item in first)
            {
                if (second.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
