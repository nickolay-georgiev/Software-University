using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        protected abstract List<Type> FoodTypes { get; }
        protected abstract double WeightMultiplier { get;}


        public abstract void ProduceSound();

        public void Eating(IFood food)
        {
            if (!this.FoodTypes.Contains(food.GetType()))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += WeightMultiplier * food.Quantity;
            this.FoodEaten += food.Quantity;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
