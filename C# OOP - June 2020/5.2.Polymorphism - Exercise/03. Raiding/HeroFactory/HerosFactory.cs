using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.HeroFactory
{
    public class HerosFactory
    {
        public BaseHero CreateHero(string name, string type)
        {
            BaseHero hero;

            if (type.Equals("Druid"))
            {
                hero = new Druid(name);
            }
            else if (type.Equals("Paladin"))
            {
                hero = new Paladin(name);
            }
            else if (type.Equals("Rogue"))
            {
                hero = new Rogue(name);
            }
            else if (type.Equals("Warrior"))
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }

            return hero;
        }
    }
}
