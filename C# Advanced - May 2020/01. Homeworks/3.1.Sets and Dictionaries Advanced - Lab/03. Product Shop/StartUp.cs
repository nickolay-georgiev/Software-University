using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> foodShops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("Revision"))
                {
                    break;
                }

                string[] input = command.Split(", ").ToArray();
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!foodShops.ContainsKey(shop))
                {
                    foodShops.Add(shop, new Dictionary<string, double>());
                }

                if (!foodShops[shop].ContainsKey(product))
                {
                    foodShops[shop].Add(product, 0);
                }

                foodShops[shop][product] = price;
            }

            foreach (var currentShop in foodShops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{currentShop.Key}->");

                foreach (var currentProduct in currentShop.Value)
                {
                    Console.WriteLine($"Product: {currentProduct.Key}, Price: {currentProduct.Value}");
                }
            }
        }
    }
}
