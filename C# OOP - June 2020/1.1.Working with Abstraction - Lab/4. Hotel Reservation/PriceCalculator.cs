using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StudentSystem
{
    enum Season
    {
        Def = 0,
        Autumn = 1,
        Spring = 2,
        Winter = 3,
        Summer = 4,
    }

    enum Discount
    {
        None = 0,
        VIP = 20,
        SecondVisit = 10,

    }
    static class PriceCalculator
    {
        public static decimal GetTotalPrice(decimal pricePerDay, int numberOfDays, string season, string discountType)
        {
            decimal totalPrice = 0;           

            Season temp = Enum.Parse<Season>(season);
            int seasonInteger = (int)temp;

            Discount discountInteger = Enum.Parse<Discount>(discountType);
            int discountPercent = (int)discountInteger;

            totalPrice = pricePerDay * numberOfDays * seasonInteger;
            totalPrice = totalPrice - (totalPrice * (discountPercent / 100.00M));

            return totalPrice;
        }
    }
}

