using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    class StartUp
    {
        public static void Main()
        {
            string[] createCommand = Console.ReadLine().Split();
            List<string> collection = createCommand.Skip(1).ToList();

            ListyIterator<string> test = new ListyIterator<string>(collection);

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("END"))
                {
                    break;
                }

                try
                {
                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(test.Move());
                            break;

                        case "HasNext":
                            Console.WriteLine(test.HasNext());
                            break;

                        case "Print":
                            test.Print();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
