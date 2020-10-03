using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }

        string FavoriteFood { get; }

        string ExplainSelf();
    }
}
