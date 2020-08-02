using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> counter = new Dictionary<double, int>();

            foreach (var number in input)
            {
                if (!counter.ContainsKey(number))
                {
                    counter.Add(number, 0);
                }
                counter[number]++;
            }

            foreach (var (number, times) in counter)
            {
                Console.WriteLine($"{number} - {times} times");
            }
        }
    }
}
