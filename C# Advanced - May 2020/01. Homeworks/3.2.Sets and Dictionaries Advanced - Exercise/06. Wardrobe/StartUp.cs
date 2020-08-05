using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string collor = input[0];

                string[] allClothes = input[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(collor))
                {
                    wardrobe.Add(collor, new Dictionary<string, int>());
                }

                for (int j = 0; j < allClothes.Length; j++)
                {
                    string currentClothe = allClothes[j];

                    if (!wardrobe[collor].ContainsKey(currentClothe))
                    {
                        wardrobe[collor].Add(currentClothe, 0);
                    }
                    wardrobe[collor][currentClothe]++;
                }
            }

            string[] searchFor = Console.ReadLine().Split();
            string searchingCollor = searchFor[0];
            string searchingdress = searchFor[1];

            foreach (var collor in wardrobe)
            {
                Console.WriteLine($"{collor.Key} clothes:");

                foreach (var dress in collor.Value)
                {
                    if (searchingCollor.Equals(collor.Key) && dress.Key.Equals(searchingdress))
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }
                }
            }
        }
    }
}
