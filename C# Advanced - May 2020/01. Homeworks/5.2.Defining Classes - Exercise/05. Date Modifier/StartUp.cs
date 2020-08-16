using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier date = new DateModifier();

            Console.WriteLine(date.CalculateDifferenceBetweenTwoDates(firstDate, secondDate));
        }
    }
}
