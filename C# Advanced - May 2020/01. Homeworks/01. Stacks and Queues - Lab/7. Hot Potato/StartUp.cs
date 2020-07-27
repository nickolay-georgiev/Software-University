using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>(
                Console.ReadLine()
                .Split());

            int count = int.Parse(Console.ReadLine());

            while (names.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    names.Enqueue(names.Dequeue());
                }
                Console.WriteLine($"Removed {names.Dequeue()}");
            }

            Console.WriteLine($"Last is {names.Peek()}");
        }
    }
}
