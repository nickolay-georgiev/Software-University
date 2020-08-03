using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var currentName in names)
            {
                Console.WriteLine($"{currentName}");
            }
        }
    }
}
