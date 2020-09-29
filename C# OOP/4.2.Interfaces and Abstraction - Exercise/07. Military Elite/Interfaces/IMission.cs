using MilitaryElite.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        State CompleteMission(string mission);
    }
}
