using System;

namespace _01._Action_Print
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string> print = x => Console.WriteLine(x);

            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
