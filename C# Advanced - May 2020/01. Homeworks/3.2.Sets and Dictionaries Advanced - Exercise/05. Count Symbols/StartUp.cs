using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> allElements = new HashSet<string>();
            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (!result.ContainsKey(currentChar))
                {
                    result.Add(currentChar, 0);
                }
                result[currentChar]++;
            }

            foreach (var (@char, times) in result)
            {
                Console.WriteLine($"{@char}: {times} time/s");
            }
        }
    }
}
