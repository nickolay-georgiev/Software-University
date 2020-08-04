using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> allElements = new HashSet<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] elements = Console.ReadLine().Split();

                foreach (var element in elements)
                {
                    allElements.Add(element);
                }
            }

            Console.WriteLine($"{string.Join(" ", allElements.OrderBy(x => x))}");
        }
    }
}
