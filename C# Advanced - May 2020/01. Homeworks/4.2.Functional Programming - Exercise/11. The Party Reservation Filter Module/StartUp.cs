using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Func<string, string, bool> startsWithFilter = (name, pattern) => name.StartsWith(pattern);
            Func<string, string, bool> endsWithFilter = (name, pattern) => name.EndsWith(pattern);
            Func<string, string, bool> containsFilter = (name, pattern) => name.Contains(pattern);
            Func<string, int, bool> lengthFilter = (name, length) => name.Length == length;

            List<string> filtersParameters = new List<string>();

            string[] names = Console.ReadLine().Split();

            while (true)
            {
                string inputCommand = Console.ReadLine();

                if (inputCommand.Equals("Print"))
                {
                    break;
                }

                string[] commandInfo = inputCommand.Split(";");
                string action = commandInfo[0];
                string command = commandInfo[1];
                string param = commandInfo[2];

                if (action.Equals("Add filter"))
                {
                    filtersParameters.Add(command + "->" + param);

                }
                else if (action.Equals("Remove filter"))
                {
                    filtersParameters.Remove(command + "->" + param);
                }
            }

            foreach (var currentParameter in filtersParameters)
            {
                string[] currentParam = currentParameter.Split("->");
                string parameter = currentParam[1];

                if (currentParam[0] == "Starts with")
                {
                    names = names.Where(x => !startsWithFilter(x, parameter)).ToArray();
                }
                else if (currentParam[0] == "Ends with")
                {
                    names = names.Where(x => !endsWithFilter(x, parameter)).ToArray();
                }
                else if (currentParam[0] == "Length")
                {
                    int length = int.Parse(parameter);
                    names = names.Where(p => lengthFilter(p, length)).ToArray();
                }
                else if (currentParam[0] == "Contains")
                {
                    names = names.Where(x => !containsFilter(x, parameter)).ToArray();
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
