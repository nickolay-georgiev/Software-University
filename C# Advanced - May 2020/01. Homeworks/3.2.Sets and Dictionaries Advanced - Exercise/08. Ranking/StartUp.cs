using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> contestsPasswors = new Dictionary<string, string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("end of contests"))
                {
                    break;
                }

                GetContestAndPassword(contestsPasswors, command);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("end of submissions"))
                {
                    break;
                }

                string[] input = command.Split("=>");
                string contest = input[0];
                string password = input[1];
                string user = input[2];
                int points = int.Parse(input[3]);

                AddNewUser(users, contestsPasswors, contest, password, user, points);
            }

            KeyValuePair<string, int> bestCandidate = GetBestStudent(users);

            PrintUsersStats(users, bestCandidate);
        }

        private static void PrintUsersStats(Dictionary<string, Dictionary<string, int>> users, KeyValuePair<string, int> bestCandidate)
        {
            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value} points.");
            Console.WriteLine($"Ranking:");

            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");

                foreach (var (contest, points) in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }

        private static KeyValuePair<string, int> GetBestStudent(Dictionary<string, Dictionary<string, int>> users)
        {
            KeyValuePair<string, int> bestCandidate = new KeyValuePair<string, int>();

            int maxSum = int.MinValue;
            foreach (var (user, contest) in users)
            {
                int previousSum = contest.Values.Sum();

                if (previousSum > maxSum)
                {
                    maxSum = previousSum;
                    bestCandidate = new KeyValuePair<string, int>(user, maxSum);
                }
            }

            return bestCandidate;
        }

        private static void AddNewUser(Dictionary<string, Dictionary<string, int>> users, Dictionary<string, string> contestsPasswors, string contest, string password, string user, int points)
        {
            if (contestsPasswors.ContainsKey(contest) && contestsPasswors[contest].Equals(password))
            {
                if (!users.ContainsKey(user))
                {
                    users.Add(user, new Dictionary<string, int>());
                }
                if (!users[user].ContainsKey(contest))
                {
                    users[user].Add(contest, points);
                }

                if (points > users[user][contest])
                {
                    users[user][contest] = points;
                }
            }
        }

        static void GetContestAndPassword(Dictionary<string, string> contestsPasswors, string command)
        {
            string[] input = command.Split(":");
            string contest = input[0];
            string password = input[1];

            if (!contestsPasswors.ContainsKey(contest))
            {
                contestsPasswors.Add(contest, string.Empty);
            }
            contestsPasswors[contest] = password;
        }
    }
}
