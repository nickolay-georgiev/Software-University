using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Models
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private string favoriteFood;

        public Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }


        public string Name { get; private set; }

        public string FavoriteFood { get; private set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
        }
    }
}
