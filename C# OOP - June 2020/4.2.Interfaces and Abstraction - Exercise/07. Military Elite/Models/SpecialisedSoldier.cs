using MilitaryElite.Enumerators;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corp)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = GetCorpType(corp);
        }

        public Corps Corps { get; }

        public Corps GetCorpType(string corp)
        {
            Corps currentCorp;

            bool isValidCorp = Corps.TryParse(corp, out currentCorp);

            if(!isValidCorp)
            {
                throw new ArgumentException("Invalid type of corp!");
            }

            return currentCorp;
        }
    }
}
