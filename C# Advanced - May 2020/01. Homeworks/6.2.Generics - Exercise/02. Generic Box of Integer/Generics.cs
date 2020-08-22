using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
    {
        public List<T> Elemets { get; set; }

        public Box()
        {
            this.Elemets = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var element in this.Elemets)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Add(T element)
        {
            this.Elemets.Add(element);
        }
    }
}
