using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> register = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!register.ContainsKey(continent))
                {
                    register.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!register[continent].ContainsKey(country))
                {
                    register[continent].Add(country, new List<string>());
                }
                register[continent][country].Add(city);
            }

            foreach (var currentContinent in register)
            {
                Console.WriteLine($"{currentContinent.Key}:");

                foreach (var currentCountry in currentContinent.Value)
                {
                    Console.WriteLine($"  {currentCountry.Key} -> {string.Join(", ", currentCountry.Value)}");
                }
            }
        }
    }
}
