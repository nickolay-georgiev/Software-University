using MilitaryElite.Interfaces;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<ISoldier> Privates { get; }

        void AddSoldier(ISoldier soldier);
    }
}
