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
                string[] data = Console.ReadLine().Split();

                string model = data[0];

                int engineSpeed = int.Parse(data[1]);
                int enginePower = int.Parse(data[2]);

                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];

                Tire[] tires = new Tire[4]
                {
                    new Tire(double.Parse(data[5]), int.Parse(data[6])),
                    new Tire(double.Parse(data[7]), int.Parse(data[8])),
                    new Tire(double.Parse(data[9]), int.Parse(data[10])),
                    new Tire(double.Parse(data[11]), int.Parse(data[12]))
                };

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command.Equals("fragile"))
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "fragile"))
                {
                    if (car.Tires.Any(x => x.TirePressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "flamable"))
                {
                    if (car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
