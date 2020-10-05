﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercises.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double km)
        {
            if (CanDrive(km))
            {
                Console.WriteLine($"Truck travelled {km} km");

                this.FuelQuantity -= (km * (this.FuelConsumption + 1.6));
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");

                return;
            }

            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters * 0.95;
            }
        }

        protected override bool CanDrive(double km)
        {
            if (this.FuelQuantity >= km * (this.FuelConsumption + 1.6))
            {
                return true;
            }

            return false;
        }
    }
}
