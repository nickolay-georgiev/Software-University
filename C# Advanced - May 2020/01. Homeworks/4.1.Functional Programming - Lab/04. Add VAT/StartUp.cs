using System;
using System.Linq;

namespace _04._Add_VAT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();

            foreach (var number in input)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
