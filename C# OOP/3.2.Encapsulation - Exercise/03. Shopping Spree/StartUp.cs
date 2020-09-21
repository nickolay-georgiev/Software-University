using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {

            try
            {
                List<Person> people = new List<Person>();

                List<Product> bagWithProducts = new List<Product>();

                string[] inputArg = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < inputArg.Length; i++)
                {
                    string[] input = inputArg[i].Split("=");

                    string name = input[0];
                    decimal money = decimal.Parse(input[1]);

                    people.Add(new Person(name, money));
                }

                string[] productInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < productInfo.Length; i++)
                {
                    string[] currentProductInfo = productInfo[i].Split("=");

                    string name = currentProductInfo[0];
                    decimal cost = decimal.Parse(currentProductInfo[1]);

                    bagWithProducts.Add(new Product(name, cost));
                }

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command.Equals("END"))
                    {
                        break;
                    }

                    string[] inputInfo = command.Split().ToArray();

                    string personName = inputInfo[0];
                    string productName = inputInfo[1];

                    Person person = people.FirstOrDefault(x => x.Name == personName);

                    Product currentProduct = bagWithProducts.FirstOrDefault(x => x.Name == productName);

                    person.BuyProduct(currentProduct);
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
