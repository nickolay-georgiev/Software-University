using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _3_Telephony
{
    internal class Smartphone :  ISmartphone
    {
        public string Call(string number)
        {
            if (number.Any(Char.IsLetter))
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }
    }
}
