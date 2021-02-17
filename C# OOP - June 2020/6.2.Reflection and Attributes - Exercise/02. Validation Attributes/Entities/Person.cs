using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Models;

namespace ValidationAttributes.Entities
{
    public class Person
    {
        private const int RequiredMinValue = 12;
        private const int RequiredMaxValue = 90;
        public Person(string firstName, int age)
        {
            FirstName = firstName;
            Age = age;
        }

        [MyRequired]
        public string FirstName { get; private set; }

        [MyRange(RequiredMinValue, RequiredMaxValue)]
        public int Age { get; private set; }
    }
}
