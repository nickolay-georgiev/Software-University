using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            Dictionary<string, List<string>> reservationList = new Dictionary<string, List<string>>();
            reservationList.Add("vip", new List<string>());
            reservationList.Add("regular", new List<string>());

            while (true)
            {
                string guest = Console.ReadLine();

                if (guest.Equals("PARTY"))
                {
                    break;
                }

                if (guest.Length != 8)
                {
                    continue;
                }

                if (char.IsDigit(guest[0]))
                {
                    if (!reservationList["vip"].Contains(guest))
                    {
                        reservationList["vip"].Add(guest);
                    }
                }

                else
                {
                    if (!reservationList["regular"].Contains(guest))
                    {
                        reservationList["regular"].Add(guest);
                    }
                }
            }

            while (true)
            {
                string guest = Console.ReadLine();

                if (guest.Equals("END"))
                {
                    break;
                }

                if (reservationList["vip"].Contains(guest))
                {
                    reservationList["vip"].Remove(guest);
                }
                else if (reservationList["regular"].Contains(guest))
                {
                    reservationList["regular"].Remove(guest);
                }
            }

            var count = reservationList.Sum(x => x.Value.Count());

            Console.WriteLine(count);
            foreach (var person in reservationList)
            {
                foreach (var personReservationNumber in person.Value.OrderBy(x => x == "vip"))
                {
                    Console.WriteLine($"{personReservationNumber}");
                }
            }
        }
    }
}
