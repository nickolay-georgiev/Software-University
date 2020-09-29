using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWokerd)
        {
            this.PartName = partName;
            this.HoursWokerd = hoursWokerd;
        }

        public string PartName { get; }

        public int HoursWokerd { get; }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWokerd}";
        }
    }
}
