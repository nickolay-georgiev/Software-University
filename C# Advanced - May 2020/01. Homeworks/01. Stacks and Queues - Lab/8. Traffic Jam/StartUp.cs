using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int numberOfCarsToPass = int.Parse(Console.ReadLine());
            int counter = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("end"))
                {
                    break;
                }

                else if (command.Equals("green"))
                {
                    for (int i = 0; i < numberOfCarsToPass; i++)
                    {
                        if (0 >= cars.Count)
                        {
                            continue;
                        }
                        Console.WriteLine($"{cars.Peek()} passed!");
                        cars.Dequeue();
                        counter++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
