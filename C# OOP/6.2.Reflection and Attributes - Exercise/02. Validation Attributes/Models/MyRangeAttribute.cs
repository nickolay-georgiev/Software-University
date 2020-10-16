using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes.Models
{
    class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int MinValue;
        private readonly int MaxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }


        public override bool IsValid(object obj)
        {           

            int value = Convert.ToInt32(obj);

            if (value < MinValue && MaxValue > value)
            {
                return false;
            }

            return true;
        }
    }
}
