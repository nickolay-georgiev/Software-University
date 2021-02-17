using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private int minPizzaName = 1;

        private int maxPizzaName = 15;

        private int minToppingCount = 0;

        private int maxToppingCount = 10;

        private string name;

        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;

            this.Dough = dough;

            toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < minPizzaName || value.Length > maxPizzaName)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }


        public Dough Dough { get; }        

        public double TotalCalories => this.Dough.CalculateCalories() + this.toppings.Sum(x => x.GetCaloriesPerGram());

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count < minToppingCount || this.toppings.Count >= maxToppingCount)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        //public double GetTotalPizzaCalories()
        //{
        //    double doughCalories = this.Dough.CalculateCalories();

        //    double toppingCalories = 0;
        //    foreach (var topping in this.toppings)
        //    {
        //        toppingCalories += topping.GetCaloriesPerGram();
        //    }

        //    double totalPizzaCalories = doughCalories + toppingCalories;

        //    return totalPizzaCalories;
        //}
    }
}
