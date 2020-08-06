using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._The_V_Logger___Copy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> vloggers = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("Statistics"))
                {
                    break;
                }

                string[] input = command.Split().ToArray();
                string name = input[0];
                string action = input[1];
                var temp = input.Skip(2);

                string joinedName = string.Empty;
                foreach (var item in temp)
                {
                    joinedName += item + " ";
                }
                joinedName = joinedName.TrimEnd();

                if (action.Equals("joined"))
                {
                    if (!vloggers.ContainsKey(name))
                    {
                        vloggers.Add(name, new Dictionary<string, List<string>>());
                        vloggers[name].Add("followers", new List<string>());
                        vloggers[name].Add("following", new List<string>());
                    }
                }
                else if (action.Equals("followed"))
                {
                    if (!vloggers.ContainsKey(name) || !vloggers.ContainsKey(joinedName) || name.Equals(joinedName))
                    {
                        continue;
                    }
                    if (!vloggers[name]["following"].Contains(joinedName))
                    {
                        vloggers[name]["following"].Add(joinedName);
                    }

                    if (!vloggers[joinedName]["followers"].Contains(name))
                    {
                        vloggers[joinedName]["followers"].Add(name);
                    }
                }
            }

            int counter = 1;

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value["followers"].Count()).ThenBy(x => x.Value["following"].Count()))
            {
                Console.WriteLine($"{counter++}. {vlogger.Key} : {vlogger.Value["followers"].Count()} followers, {vlogger.Value["following"].Count()} following");

                if (counter.Equals(2))
                {
                    foreach (var item in vlogger.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
            }
        }
    }
}
