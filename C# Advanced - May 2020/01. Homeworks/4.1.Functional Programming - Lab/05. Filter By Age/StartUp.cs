using System;
using System.Collections.Generic;

namespace _05._Filter_By_Age
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int linese = int.Parse(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < linese; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ");

                AddPeople(dict, input);
            }

            string[] conditions = new string[3];

            for (int i = 0; i < 3; i++)
            {
                string data = Console.ReadLine();
                conditions[i] = data;
            }

            string olderOrYounger = conditions[0];
            int age1 = int.Parse(conditions[1]);
            string temp = conditions[2];

            var filter = CreateFilter(olderOrYounger, age1);
            var write = CreateWriter(temp);

            foreach (var kv in dict)
            {
                if (filter(kv.Value))
                {
                    write(kv);
                }
            }
        }

        static Func<int, bool> CreateFilter(string condition, int compareAge)
        {
            if (condition == "older")
            {
                return x => x >= compareAge;
            }

            return x => x < compareAge;
        }

        static Action<KeyValuePair<string, int>> CreateWriter(string outputFormat)
        {
            switch (outputFormat)
            {
                case "name":
                    return x => Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                default:
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
            }
        }

        private static void AddPeople(Dictionary<string, int> dict, string[] input)
        {
            string name = input[0];
            int age = int.Parse(input[1]);

            if (!dict.ContainsKey(name))
            {
                dict.Add(name, age);
            }
            else if (dict.ContainsKey(name))
            {
                dict[name] = age;
            }
        }
    }    
}
