using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
            this.FoodType = new List<string>() { "Meat", "Vegetable"};
        }

        protected override List<Type> FoodTypes => new List<Type>() { typeof(Meat), typeof(Vegetable) };
        protected override double WeightMultiplier => 0.30;

        private List<string> FoodType { get; }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
