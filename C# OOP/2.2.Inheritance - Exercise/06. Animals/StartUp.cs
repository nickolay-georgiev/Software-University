using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string firstLine = Console.ReadLine();

                if (firstLine == "Beast!")
                {
                    break;
                }

                string[] secondLineTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // Spravka tuk: https://softuni.bg/forum/15928/problem-s-06-animals-ot-oop-basics-inheritance
                try
                {
                    switch (firstLine)
                    {
                        case "Dog":
                            var dog = new Dog(secondLineTokens[0], int.Parse(secondLineTokens[1]), secondLineTokens[2]);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            var frog = new Frog(secondLineTokens[0], int.Parse(secondLineTokens[1]), secondLineTokens[2]);
                            animals.Add(frog);
                            break;
                        case "Cat":
                            var cat = new Cat(secondLineTokens[0], int.Parse(secondLineTokens[1]), secondLineTokens[2]);
                            animals.Add(cat);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(secondLineTokens[0], int.Parse(secondLineTokens[1]));
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(secondLineTokens[0], int.Parse(secondLineTokens[1]));
                            animals.Add(tomcat);
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
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