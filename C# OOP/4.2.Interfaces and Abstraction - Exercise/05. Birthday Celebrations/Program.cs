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

            List<IBirthdate> test = new List<IBirthdate>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                string[] inputInfo = input.Split().ToArray();

                string type = inputInfo[0];

                if (type == "Robot")
                {
                    string model = inputInfo[1];
                    string id = inputInfo[2];

                    society.Add(new Robot(model, id));
                }
                else if (type == "Citizen")
                {
                    string name = inputInfo[1];
                    int age = int.Parse(inputInfo[2]);
                    string id = inputInfo[3];
                    string birthDate = inputInfo[4];

                    society.Add(new Citizen(name, age, id, birthDate));
                    test.Add(new Citizen(name, age, id, birthDate));
                }
                else if (type == "Pet")
                {
                    string name = inputInfo[1];
                    string birthDate = inputInfo[2];

                    test.Add(new Pet(name, birthDate));
                }
            }

            string year = Console.ReadLine();

            //var filterdCitizens = test.Where(x => x.Birthdate.Contains(year));

            //if (filterdCitizens.Count() == 0)
            //{
            //    Console.WriteLine("<empty output>");
            //}
            //else
            //{
                foreach (var citizen in test.Where(x => x.Birthdate.Contains(year)))
                {
                    Console.WriteLine(citizen.Birthdate);
                }
            
        }
    }
}
