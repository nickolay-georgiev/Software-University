﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
           
        }

        protected override List<Type> FoodTypes => new List<Type>() {typeof(Meat) };

        protected override double WeightMultiplier => 0.25;

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
