﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public void Drive(double kilometers)
        {
            bool canDrive = this.FuelConsumption * kilometers <= this.Fuel;

            if (canDrive)
            {
                this.Fuel -= this.FuelConsumption * kilometers;
            }
        }
    }
}
