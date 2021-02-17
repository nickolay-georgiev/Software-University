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
            double carTankCapacity = double.Parse(carInfo[3]);

            string[] truckInfo = Console.ReadLine().Split().ToArray();
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            string[] busInfo = Console.ReadLine().Split().ToArray();
            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            var car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            var truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            var bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);
            
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
                    else if (vehicleType.Equals("Bus"))
                    {
                        bus.Drive(km);
                    }
                }
                else if(command.Equals("DriveEmpty"))
                {
                    double km = double.Parse(commandInfo[2]);

                    bus.DriveEmpty(km);
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
                    else if (vehicleType.Equals("Bus"))
                    {
                        bus.Refuel(liters);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
