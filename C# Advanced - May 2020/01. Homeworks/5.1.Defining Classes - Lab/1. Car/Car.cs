using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //Create a class named Car.The class should have private fields for:
        //•	make: string
        //•	model: string
        //•	year: int
        //The class should also have public properties for:
        //•	Make: string
        //•	Model: string
        //•	Year: int.

        private string make;
        private string model;
        private int year;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        
        public int Year
        {
            get { return year; }
            set { year = value; }
        }




    }
}
