using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._List_Of_Predicates
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int, bool> myFunc = (x, y) => x.All(x => y % x == 0);

            List<int> results = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                if (myFunc(dividers, i))
                {
                    results.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
