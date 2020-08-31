using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    class StartUp
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            Lake lake = new Lake(input);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
