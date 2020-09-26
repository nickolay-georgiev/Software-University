using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Telephony
{
    public interface ISmartphone : IStationaryPhone
    {
        string Browse(string number);
    }
}
