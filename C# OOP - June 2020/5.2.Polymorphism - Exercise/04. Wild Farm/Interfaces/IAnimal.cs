using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Interfaces
{
    public interface IAnimal
    {
        public string Name { get; }

        public double Weight { get; }

        public int FoodEaten { get; }

        void ProduceSound();

        void Eating(IFood food);
    }
}
