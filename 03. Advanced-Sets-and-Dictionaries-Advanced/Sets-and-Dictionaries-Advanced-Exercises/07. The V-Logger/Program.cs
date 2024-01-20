using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var users = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while (!input.Contains("Statistics"))
            {
                string[] command = input.Split(' ');
                string vlogar = command[0];


                if (input.Contains("joined"))
                {
                    if (input.Contains(vlogar))
                    {
                        users[vlogar] = new Dictionary<string, SortedSet<string>>();
                        users[vlogar]["followers"] = new SortedSet<string>();
                        users[vlogar]["following"] = new SortedSet<string>();
                    }
                }
                else if (input.Contains("followed"))
                {
                    string firstVlogger = command[0];
                    string secondVlogger = command[2];

                    if (ChekIfValidUsers(users, firstVlogger, secondVlogger))
                    {
                        users[secondVlogger]["followers"].Add(firstVlogger);
                        users[firstVlogger]["following"].Add(secondVlogger);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {users.Count} vloggers in its logs.");
            var ordered = users.OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(y => y.Value["following"].Count);

            int rank = 1;

            foreach (var (user, data) in ordered)
            {
                int countFollowers = data["followers"].Count;
                int countFollowing = data["following"].Count;
                Console.WriteLine($"{rank}. {user} : {countFollowers} followers, {countFollowing} following");

                if (rank == 1)
                {
                    foreach (var item in data["followers"])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                rank++;
            }
        }

        private static bool ChekIfValidUsers(Dictionary<string, Dictionary<string, SortedSet<string>>> users, string firstVlogger, string secondVlogger)
        {
            return users.ContainsKey(firstVlogger) &&
                   users.ContainsKey(secondVlogger) &&
                   firstVlogger != secondVlogger;
        }
    }
}
