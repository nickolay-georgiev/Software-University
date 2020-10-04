using PolymorphismExercises.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercises
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        protected abstract bool CanDrive(double km);

        public abstract void Drive(double km);

        public abstract void Refuel(double liters);

    }
}
