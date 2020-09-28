using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<ICitizen> citizens = new List<ICitizen>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                if(input.Length == 3)
                {
                    string groupName = input[2];

                    citizens.Add(new Rebel(name, age, groupName));
                }
                else if(input.Length == 4)
                {
                    string id = input[2];
                    string birthDate = input[3];

                    citizens.Add(new Citizen(name, age, id, birthDate));
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input.Equals("End"))
                {
                    break;
                }

                if(citizens.Any(x=>x.Name == input))
                {
                    var curretnCitizen = citizens.FirstOrDefault(x=>x.Name == input);

                    curretnCitizen.BuyFood();
                }
            }

            Console.WriteLine(citizens.Sum(x=>x.Food));

        }
    }
}
