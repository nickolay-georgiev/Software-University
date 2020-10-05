using System;
using System.Collections.Generic;
using Raiding.HeroFactory;
using Raiding.Models;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            HerosFactory factory = new HerosFactory();

            List<BaseHero> heros = new List<BaseHero>();

            int counter = 0;

            while (lines != counter)
            {            
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();

                try
                {
                    var hero = factory.CreateHero(name, heroType);
                    heros.Add(hero);
                    counter++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalHeroPower = 0;
            foreach (var hero in heros)
            {
                Console.WriteLine(hero.CastAbility());

                totalHeroPower += hero.Power;
            }

            if(bossPower <= totalHeroPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}

//3
//Mike
//Paladin
//Josh
//Druid
//Scott
//Warrior
//250

//2
//Mike
//Warrior
//Tom
//Rogue
//200
