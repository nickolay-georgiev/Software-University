using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Child : Person
    {
        private int age;

        public Child(string name, int age) : base(name, age)
        {

        }

        public override int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 15)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be less than 15!");
                };
            }
        }
    }
}
