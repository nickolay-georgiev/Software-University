using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while (true)
            {
                string data = Console.ReadLine();

                if (data.Equals("Party!"))
                {
                    break;
                }

                string[] command = data.Split();
                string action = command[0];
                string startOrEnd = command[1];
                string pattern = command[2];

                Func<string, string, bool> startsWith = (name, pattern) => name.StartsWith(pattern);
                Func<string, string, bool> endsWith = (name, pattern) => name.EndsWith(pattern);
                Func<string, int, bool> nameLength = (name, length) => name.Length == length;

                if (action.Equals("Double"))
                {
                    if (startOrEnd.Equals("StartsWith"))
                    {
                        var temp = names.Where(x => startsWith(x, pattern)).ToList();
                        InsertName(names, temp);
                    }
                    else if (startOrEnd.Equals("EndsWith"))
                    {
                        var temp = names.Where(x => endsWith(x, pattern)).ToList();
                        InsertName(names, temp);
                    }
                    else if (startOrEnd.Equals("Length"))
                    {
                        int length = int.Parse(pattern);
                        var temp = names.Where(x => nameLength(x, length)).ToList();
                        InsertName(names, temp);
                    }

                }
                else if (action.Equals("Remove"))
                {
                    if (startOrEnd.Equals("StartsWith"))
                    {
                        names = names.Where(x => !startsWith(x, pattern)).ToList();
                    }
                    else if (startOrEnd.Equals("EndsWith"))
                    {
                        names = names.Where(x => !endsWith(x, pattern)).ToList();
                    }
                    else if (startOrEnd.Equals("Length"))
                    {
                        int length = int.Parse(pattern);
                        names = names.Where(x => !nameLength(x, length)).ToList();
                    }
                }
            }

            if (names.Count > 0)
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void InsertName(List<string> names, List<string> temp)
        {
            foreach (var name in temp)
            {
                int index = names.IndexOf(name);
                names.Insert(index, name);
            }
        }
    }    
}
