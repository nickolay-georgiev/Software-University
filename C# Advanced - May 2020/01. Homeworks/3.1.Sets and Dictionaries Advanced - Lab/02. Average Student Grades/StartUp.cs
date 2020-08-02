using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var studentRecord = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < num; i++)
            {
                var nameAndGrades = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!studentRecord.ContainsKey(nameAndGrades[0]))
                {
                    studentRecord[nameAndGrades[0]] = new List<decimal>();
                }
                studentRecord[nameAndGrades[0]].Add(decimal.Parse(nameAndGrades[1]));
            }

            foreach (var (name, grade) in studentRecord)
            {
                var avrageSum = grade.Sum() / grade.Count();

                Console.Write($"{name} -> ");

                foreach (var val in grade)
                {
                    Console.Write($"{val:f2} ");
                }

                Console.WriteLine($"(avg: {avrageSum:f2})");
            }
        }
    }
}
