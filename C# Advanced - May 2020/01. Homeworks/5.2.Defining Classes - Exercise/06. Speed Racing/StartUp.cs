using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                if (cars.Any(x => x.Model == model))
                {
                    continue;
                }

                cars.Add(new Car(model, fuelAmount, fuelConsumptionFor1km));
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("End"))
                {
                    break;
                }

                string[] data = command.Split();

                string carModel = data[1];
                int amountOfKm = int.Parse(data[2]);

                foreach (var car in cars.Where(x => x.Model == carModel))
                {
                    car.Drive(amountOfKm);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
