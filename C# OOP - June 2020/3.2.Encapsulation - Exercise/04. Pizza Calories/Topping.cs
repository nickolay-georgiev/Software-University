using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double baseCalories = 2.0;

        private const double minWeight = 1;
        private const double maxWeight = 50;

        private Dictionary<string, double> toppingTypes;

        private string type;

        private double weight;


        public Topping(string type, double weight)
        {
            toppingTypes = new Dictionary<string, double>
            {
                {"meat", 1.2 },
                {"veggies", 0.8 },
                {"cheese", 1.1 },
                {"sauce", 0.9 },
            };

            this.Type = type;
            this.Weight = weight;
        }


        private string Type
        {
            get { return type; }

            set 
            {
                if (!toppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }

                this.type = value; 
            }
        }


        private double Weight
        {
            get { return weight; }
            set 
            {
                if (value < minWeight || maxWeight < value)
                {
                    throw new Exception($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value; 
            }
        }


        public double GetCaloriesPerGram()
        {

            double typeCalories = this.toppingTypes.FirstOrDefault(x => x.Key == this.Type.ToLower()).Value;

            double totalCalories = this.Weight * typeCalories * baseCalories;

            return totalCalories;
        }
    }
}
