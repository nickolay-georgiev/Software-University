using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Interfaces
{
    interface IMammal : IAnimal
    {
        public string LivingRegion { get;}
    }
}
