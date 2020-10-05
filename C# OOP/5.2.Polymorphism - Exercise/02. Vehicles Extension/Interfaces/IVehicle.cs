using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercises.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get;}
        double FuelConsumption { get;}
        double TankCapacity { get;}


        void Drive(double km);

        void Refuel(double liters);
    }
}
