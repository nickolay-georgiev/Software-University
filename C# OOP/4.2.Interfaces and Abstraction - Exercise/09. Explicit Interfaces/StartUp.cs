using System;
using System.Collections.Generic;
using System.Linq;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("End"))
                {
                    break;
                }

                string[] input = command.Split().ToArray();

                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                Citizen citizen = new Citizen(name, country, age);
                citizens.Add(citizen);
            }

            foreach (var citizen in citizens)
            {

                IPerson temp1 = citizen as IPerson;
                Console.WriteLine(temp1.GetName());

                IResident temp = citizen as IResident;
                Console.WriteLine(temp.GetName());
            }

        }
    }
}
