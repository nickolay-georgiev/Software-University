using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int minAge = 0;
        private const int maxAge = 15;

        protected string name;
        internal int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            internal set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            protected set
            {
                if (value < minAge || value > maxAge)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }

                this.age = value;
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        private double CalculateProductPerDay()
        {
            if (this.Age < 4)
            {
                return 1.5;

            }
            else if (this.Age < 8)
            {
                return 2;
            }
            else if (this.Age < 12)
            {
                return 1;
            }
            else
            {
                return 0.75;
            }
        }
    }
}

