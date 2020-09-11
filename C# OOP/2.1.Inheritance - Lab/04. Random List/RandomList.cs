using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public RandomList()
        {
            this.Items = new List<string>();
        }

        public List<string> Items { get; set; }

        public string RandomString()
        {
            Random random = new Random();
            int index = random.Next(0, this.Count);

            string element = this[index];            

            return element;
        }

        public string RemoveString()
        {
            Random random = new Random();
            int index = random.Next(0, this.Count);

            string element = this[index];
            this.RemoveAt(index);

            return element;
        }
    }
}
