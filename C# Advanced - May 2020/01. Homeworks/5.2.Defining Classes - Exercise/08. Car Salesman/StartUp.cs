using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);

                int displacement = -1;
                string efficiency = string.Empty;

                if (input.Length == 3)
                {
                    string current = input[2];

                    if (char.IsDigit(current[0]))
                    {
                        displacement = int.Parse(input[2]);
                        engines.Add(new Engine(model, power, displacement));
                    }
                    else
                    {
                        efficiency = input[2];
                        engines.Add(new Engine(model, power, efficiency));
                    }

                    engines.Add(new Engine(model, power, displacement));
                }
                else if (input.Length == 4)
                {
                    displacement = int.Parse(input[2]);
                    efficiency = input[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
                else
                {
                    engines.Add(new Engine(model, power));
                }
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engine = input[1];

                int weight = -1;
                string color = string.Empty;

                Engine currentEngine = engines.FirstOrDefault(x => x.Model == engine);

                if (input.Length == 3)
                {
                    string current = input[2];

                    if (char.IsDigit(current[0]))
                    {
                        weight = int.Parse(input[2]);
                        cars.Add(new Car(model, currentEngine, weight));
                    }
                    else
                    {
                        color = input[2];
                        cars.Add(new Car(model, currentEngine, color));
                    }

                }
                else if (input.Length == 4)
                {
                    weight = int.Parse(input[2]);
                    color = input[3];

                    cars.Add(new Car(model, currentEngine, weight, color));
                }
                else
                {
                    cars.Add(new Car(model, currentEngine));
                }
            }

            Car.PrintAllCars(cars);
        }        
    }
}
