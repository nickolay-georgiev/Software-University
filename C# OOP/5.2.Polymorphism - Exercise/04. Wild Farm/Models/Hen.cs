using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override List<Type> FoodTypes => new List<Type>() { typeof(Meat), typeof(Vegetable), typeof(Fruit), typeof(Seeds) };

        protected override double WeightMultiplier => 0.35;

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
