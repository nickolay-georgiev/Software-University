using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;

        private string color;

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}");
            sb.AppendLine("Engine start");
            sb.AppendLine("Breaaak!");

            return sb.ToString().TrimEnd();
        }
    }
}
