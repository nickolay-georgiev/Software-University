using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using MilitaryElite.Models;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Core
{
    public class Engine
    {
        List<ISoldier> army = new List<ISoldier>();
        public void Run()
        {

            while (true)
            {
                string command = Console.ReadLine().TrimEnd();

                if (command.Equals("End"))
                {
                    break;
                }

                string[] input = command.Split().ToArray();

                string type = input[0];
                string id = input[1];
                string firstName = input[2];
                string lastName = input[3];
                decimal salary = decimal.Parse(input[4]);

                if (type.Equals("Private"))
                {
                    Private privateSoldier = new Private(id, firstName, lastName, salary);

                    army.Add(privateSoldier);
                }
                else if (type.Equals("LieutenantGeneral"))
                {
                    LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    string[] privates = input.Skip(5).ToArray();

                    for (int i = 0; i < privates.Length; i++)
                    {
                        ISoldier current = army.First(x => x.Id == privates[i]);

                        lieutenantGeneral.AddSoldier(current);
                    }

                    army.Add(lieutenantGeneral);
                }
                else if (type.Equals("Engineer"))
                {
                    string corp = input[5];

                    try
                    {
                        Engineer engineer = null;

                        engineer = new Engineer(id, firstName, lastName, salary, corp);

                        string[] repairs = input.Skip(6).ToArray();

                        for (int i = 0; i < repairs.Length; i += 2)
                        {
                            string partName = repairs[i];
                            int hoursWorked = int.Parse(repairs[i + 1]);

                            Repair repair = new Repair(partName, hoursWorked);

                            engineer.AddRepair(repair);
                        }

                        army.Add(engineer);
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex.Message);
                    }
                }
                else if (type.Equals("Commando"))
                {
                    string corp = input[5];

                    try
                    {
                        Comando comando = new Comando(id, firstName, lastName, salary, corp);

                        string[] missions = input.Skip(6).ToArray();

                        for (int i = 0; i < missions.Length; i += 2)
                        {
                            try
                            {
                                string missionCodeName = missions[i];
                                string missionState = missions[i + 1];

                                Mission mission = new Mission(missionCodeName, missionState);

                                comando.AddMission(mission);
                            }
                            catch (Exception ex)
                            {
                                //Console.WriteLine(ex.Message);
                            }
                        }

                        army.Add(comando);
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex.Message);
                    }
                }
                else if (type.Equals("Spy"))
                {
                    Spy spy = new Spy(id, firstName, lastName, (int)salary);

                    army.Add(spy);
                }
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
