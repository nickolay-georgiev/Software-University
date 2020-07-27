using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name.Equals("End"))
                {
                    break;
                }

                else if (name.Equals("Paid"))
                {
                    if (names.Count > 0)
                    {
                        foreach (var currentName in names)
                        {
                            Console.WriteLine(currentName);
                        }

                        names.Clear();
                        continue;
                    }
                }
                names.Enqueue(name);
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
