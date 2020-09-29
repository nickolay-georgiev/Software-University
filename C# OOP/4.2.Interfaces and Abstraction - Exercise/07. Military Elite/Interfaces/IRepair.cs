using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface IRepair 
    {
        string PartName { get; }

        int HoursWokerd { get; }
    }
}
