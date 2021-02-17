using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;

        private decimal money;

        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag =>
            this.bagOfProducts.AsReadOnly();


        public void BuyProduct(Product currentProduct)
        {
            bool haveEnoughtMoney = this.Money - currentProduct.Cost >= 0;

            if (haveEnoughtMoney)
            {
                this.bagOfProducts.Add(currentProduct);

                this.money -= currentProduct.Cost;

                Console.WriteLine($"{this.Name} bought {currentProduct.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {currentProduct.Name}");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.bagOfProducts.Count == 0)
            {
                sb.AppendLine($"{this.Name} - Nothing bought");
            }
            else
            {
                sb.AppendLine($"{this.Name} - {string.Join(", ", this.Bag.Select(x => x.Name))}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
