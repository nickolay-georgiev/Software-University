using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command.Equals("end"))
                {
                    break;
                }

                string[] commands = command.Split();
                string action = commands[0];

                switch (action)
                {
                    case "add":
                        int firstNum = int.Parse(commands[1]);
                        int secondNum = int.Parse(commands[2]);

                        numbers.Push(firstNum);
                        numbers.Push(secondNum);

                        break;

                    case "remove":
                        {
                            int countToRemove = int.Parse(commands[1]);

                            for (int i = 0; i < countToRemove; i++)
                            {
                                if (numbers.Count == 0)
                                {
                                    break;
                                }
                                else if (countToRemove > numbers.Count)
                                {
                                    break;
                                }
                                numbers.Pop();
                            }
                            break;
                        }
                }

            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
