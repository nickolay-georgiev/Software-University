using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(
                 Console.ReadLine()
                 .Split(", "));

            while (songs.Count > 0)
            {
                string[] inputArg = Console.ReadLine().Split();
                string command = inputArg[0];

                switch (command)
                {
                    case "Play":
                        songs.Dequeue();
                        break;

                    case "Add":
                        string songToAdd = string.Empty;

                        for (int i = 1; i < inputArg.Length; i++)
                        {
                            songToAdd += inputArg[i] + " ";
                        }
                        songToAdd = songToAdd.TrimEnd();

                        if (songs.Contains(songToAdd))
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(songToAdd);
                        }
                        break;

                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
