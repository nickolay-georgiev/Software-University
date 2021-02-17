namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StudentSystem
    {
        public StudentSystem()
        {
            this.Repository = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Repository { get; private set; }

        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();
            string command = args[0];

            if (command == "Create")
            {
                CreateNewStudent(args);
            }
            else if (command == "Show")
            {
                var name = args[1];
                if (Repository.ContainsKey(name))
                {
                    PrintStudentStatus(name);
                }

            }
            else if (command == "Exit")
            {
                Environment.Exit(0);
            }
        }

        private void PrintStudentStatus(string name)
        {
            var student = Repository[name];

            StringBuilder sb = new StringBuilder();

            sb.Append($"{student.Name} is {student.Age} years old. ");

            if (student.Grade >= 5.00)
            {
                sb.Append("Excellent student.");
            }
            else if (student.Grade < 5.00 && student.Grade >= 3.50)
            {
                sb.Append("Average student.");
            }
            else
            {
                sb.Append("Very nice person.");
            }

            Console.WriteLine(sb);
        }

        private void CreateNewStudent(string[] args)
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);

            if (!Repository.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                Repository[name] = student;
            }
        }
    }

    public class Student
    {
        public double Grade { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    }
}