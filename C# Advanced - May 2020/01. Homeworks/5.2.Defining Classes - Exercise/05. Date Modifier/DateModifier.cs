using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public double CalculateDifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime first = DateTime.Parse(firstDate);
            DateTime second = DateTime.Parse(secondDate);

            double result = Math.Abs((second - first).TotalDays);
            return result;
        }
    }
}
