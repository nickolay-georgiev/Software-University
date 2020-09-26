using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Call(string number)
        {
            if (number.Any(Char.IsLetter))
            {
                return "Invalid number!";
            }
            return $"Dialing... {number}";
        }
    }
}
