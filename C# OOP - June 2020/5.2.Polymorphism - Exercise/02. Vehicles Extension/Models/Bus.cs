using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercises.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double km)
        {
            if (this.FuelQuantity >= km * (this.FuelConsumption + 1.4))
            {
                Console.WriteLine($"Bus travelled {km} km");

                this.FuelQuantity -= km * (this.FuelConsumption + 1.4);
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveEmpty(double km)
        {
            if (CanDrive(km))
            {
                Console.WriteLine($"Bus travelled {km} km");

                this.FuelQuantity -= km * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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
                this.FuelQuantity += liters;
            }
        }

        protected override bool CanDrive(double km)
        {
            if (this.FuelQuantity >= km * this.FuelConsumption)
            {
                return true;
            }

            return false;
        }
    }
}
