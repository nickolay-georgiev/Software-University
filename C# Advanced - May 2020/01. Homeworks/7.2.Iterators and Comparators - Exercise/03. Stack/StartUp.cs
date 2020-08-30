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
            CustomStack<string> test = new CustomStack<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("END"))
                {
                    break;
                }

                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.TrimEnd(',')).ToArray();
                string action = data[0];

                try
                {
                    switch (action)
                    {
                        case "Push":

                            List<string> elementsToPush = data.Skip(1).ToList();
                            test.Push(elementsToPush);
                            break;

                        case "Pop":
                            test.Pop();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}
