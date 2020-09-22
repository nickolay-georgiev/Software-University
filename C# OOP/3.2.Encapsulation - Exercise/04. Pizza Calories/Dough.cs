using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const double baseCalories = 2;

        private double minWeight = 1;

        private double maxWeight = 200;

        private Dictionary<string, double> flourTypes;

        private Dictionary<string, double> bakingTechniques;

        private string type;

        private string bakingTechnique;

        private double weight;
        
        public Dough(string type, string bakingTechnique, double weight)
        {

            flourTypes = new Dictionary<string, double>
            {
                {"white", 1.5 },
                {"wholegrain", 1.0},
            };

            bakingTechniques = new Dictionary<string, double>
            {
                {"crispy", 0.9 },
                {"chewy", 1.1},
                {"homemade", 1.0},
            };

            this.Type = type;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (!this.flourTypes.ContainsKey(value))
                {
                    throw new Exception("Invalid type of dough.");
                }

                this.type = value;
            }
        }


        private string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                if (!this.bakingTechniques.ContainsKey(value))
                {
                    throw new Exception("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }


        private double Weight
        {
            get 
            { 
                return this.weight; 
            }

            set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }


        public double CalculateCalories()
        {

            double currentFlourType = this.flourTypes.FirstOrDefault(x => x.Key == this.Type).Value;
            double bakingTechniqueValue = this.bakingTechniques.FirstOrDefault(x => x.Key == this.BakingTechnique).Value;

            double totalCalories = (baseCalories * this.Weight) * currentFlourType * bakingTechniqueValue;

            return totalCalories;
        }

    }
}
