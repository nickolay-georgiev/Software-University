using MilitaryElite.Enumerators;
using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
