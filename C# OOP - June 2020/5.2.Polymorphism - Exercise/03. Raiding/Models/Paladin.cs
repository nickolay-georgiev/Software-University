using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {

        private const int BasePower = 100;
        public Paladin(string name)
            : base(name)
        {
        }

        public override int Power => BasePower;

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
