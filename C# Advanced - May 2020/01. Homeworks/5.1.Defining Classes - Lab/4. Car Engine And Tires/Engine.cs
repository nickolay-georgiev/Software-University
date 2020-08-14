using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
		private int horsePower;
		private int cubicCapacity;

		public Engine(int horsePower, int cubicCapacity)
		{
			HorsePower = horsePower;
			CubicCapacity = cubicCapacity;
		}

		public int HorsePower
		{
			get { return  horsePower; }
			set {  horsePower = value; }
		}

		public int CubicCapacity
		{
			get { return cubicCapacity; }
			set { cubicCapacity = value; }
		}

	}
}
