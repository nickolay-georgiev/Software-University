using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : ICitizen
    {
        public Rebel(string name, int age, string gropu)
        {
            this.Name = name;
            this.Age = age;
            this.Gropu = gropu;
            this.Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; }

        public string Gropu { get; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
