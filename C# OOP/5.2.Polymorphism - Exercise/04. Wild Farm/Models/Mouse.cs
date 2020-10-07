using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override List<Type> FoodTypes => new List<Type>() {typeof(Vegetable), typeof(Fruit) };

        protected override double WeightMultiplier => 0.1;
                
        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
