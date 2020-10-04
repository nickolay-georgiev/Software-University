using PolymorphismExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PolymorphismExercises
{
    public class StartUp
    {
        static void Main()
        {

            string[] carInfo = Console.ReadLine().Split().ToArray();
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);

            string[] truckInfo = Console.ReadLine().Split().ToArray();
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);

            var car = new Car(carFuelQuantity, carFuelConsumption);
            var truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandInfo = Console.ReadLine().Split().ToArray();
                string command = commandInfo[0];
                string vehicleType = commandInfo[1];

                if(command.Equals("Drive"))
                {
                    double km = double.Parse(commandInfo[2]);

                    if(vehicleType.Equals("Car"))
                    {
                        car.Drive(km);
                    }
                    else if(vehicleType.Equals("Truck"))
                    {
                        truck.Drive(km);
                    }
                }
                else if (command.Equals("Refuel"))
                {
                    double liters = double.Parse(commandInfo[2]);

                    if (vehicleType.Equals("Car"))
                    {
                        car.Refuel(liters);
                    }
                    else if (vehicleType.Equals("Truck"))
                    {
                        truck.Refuel(liters);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
