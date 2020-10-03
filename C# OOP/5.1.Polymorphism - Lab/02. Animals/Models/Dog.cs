using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Models
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, string favoriteFood)
            : base(name, favoriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";
        }
    }
}
