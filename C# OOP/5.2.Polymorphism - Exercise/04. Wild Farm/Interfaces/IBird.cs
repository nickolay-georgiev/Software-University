using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Interfaces
{
    public interface IBird : IAnimal
    {
        public double WingSize { get; }
    }
}
