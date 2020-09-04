using System;

namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main()
        {
            string[] inputArg = Console.ReadLine().Split();

            decimal pricePerDay = decimal.Parse(inputArg[0]);
            int numberOfDays = int.Parse(inputArg[1]);
            string season = inputArg[2];

            string discountType = "None";

            if(inputArg.Length == 4)
            {
                discountType = inputArg[3];
            }     
            
            decimal totalPrice = PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season, discountType);

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
