using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
          
        }

        protected override List<Type> FoodTypes => new List<Type>() { typeof(Meat)};

        protected override double WeightMultiplier => 1.0;

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
