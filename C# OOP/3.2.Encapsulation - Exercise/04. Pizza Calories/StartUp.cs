using System;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
			try
			{
                string[] inputCommand = Console.ReadLine().Split();
                string pizzaName = inputCommand[1];

                string[] inputInfo = Console.ReadLine().Split().ToArray();

                string doughType = inputInfo[1].ToLower();
                string bakingTehnique = inputInfo[2].ToLower();
                double weight = double.Parse(inputInfo[3]);

                Dough dough = new Dough(doughType, bakingTehnique, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    string inputArg = Console.ReadLine();

                    if (inputArg.Equals("END"))
                    {
                        break;
                    }

                    string[] input = inputArg.Split().ToArray();

                    string toppingType = input[1];
                    double toppingWeight = double.Parse(input[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);


                    pizza.AddTopping(topping);
                    //pizza.GetTotalPizzaCalories();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}

