using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IIdentity> society = new List<IIdentity>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                string[] inputInfo = input.Split().ToArray();

                string name = inputInfo[0];

                if (inputInfo.Length == 2)
                {
                    string id = inputInfo[1];

                    society.Add(new Robot(name, id));
                }
                else if (inputInfo.Length == 3)
                {
                    int age = int.Parse(inputInfo[1]);
                    string id = inputInfo[2];

                    society.Add(new Citizen(name, age, id));
                }
            }

            string fakeId = Console.ReadLine();

            foreach (var citizen in society.Where(x => x.Id.EndsWith(fakeId)))
            {
                Console.WriteLine(citizen.Id);
            }
        }
    }
}
