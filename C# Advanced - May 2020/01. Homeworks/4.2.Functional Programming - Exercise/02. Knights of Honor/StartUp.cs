using System;

namespace _02._Knights_of_Honor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Action<string> print = x => Console.WriteLine($"Sir {x}");

                foreach (var name in input)
                {
                    print(name);
                }
            }
        }
    }
}
