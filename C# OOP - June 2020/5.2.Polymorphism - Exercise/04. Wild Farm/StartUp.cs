using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Interfaces;
using WildFarm.Models;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string command = Console.ReadLine();

                if(command.Equals("End"))
                {
                    break;
                }

                string[] inputInfo = command.Split().ToArray();

                string animalType = inputInfo[0];
                string name = inputInfo[1];
                double weight = double.Parse(inputInfo[2]);

                string[] food = Console.ReadLine().Split().ToArray();
                string foodType = food[0];
                int quantity = int.Parse(food[1]);

                IFood currentFood = null;
                Animal animal = null;

                if(foodType.Equals("Vegetable"))
                {
                    currentFood = new Vegetable(quantity);
                }
                else if (foodType.Equals("Fruit"))
                {
                    currentFood = new Fruit(quantity);
                }
                else if (foodType.Equals("Meat"))
                {
                    currentFood = new Meat(quantity);
                }
                else if (foodType.Equals("Seeds"))
                {
                    currentFood = new Seeds(quantity);
                }


                if (animalType.Equals("Hen"))
                {
                    double wingSize = double.Parse(inputInfo[3]);

                    animal = new Hen(name, weight, wingSize);
                }
                else if (animalType.Equals("Owl"))
                {
                    double wingSize = double.Parse(inputInfo[3]);

                    animal = new Owl(name, weight, wingSize);
                }
                else if (animalType.Equals("Mouse"))
                {
                    string livingRegion = inputInfo[3];

                    animal = new Mouse(name, weight, livingRegion);
                }
                else if (animalType.Equals("Dog"))
                {
                    string livingRegion = inputInfo[3];

                    animal = new Dog(name, weight, livingRegion);
                }
                else if (animalType.Equals("Cat"))
                {
                    string livingRegion = inputInfo[3];
                    string breed = inputInfo[4];

                    animal = new Cat(name, weight, livingRegion, breed);
                }
                else if (animalType.Equals("Tiger"))
                {
                    string livingRegion = inputInfo[3];
                    string breed = inputInfo[4];

                    animal = new Tiger(name, weight, livingRegion, breed);
                }

                animals.Add(animal);

                animal.ProduceSound();
                try
                {
                animal.Eating(currentFood);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
