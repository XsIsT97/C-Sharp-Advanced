using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.__SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var statistic = new SortedDictionary<string, int>();
            var studentResults = new SortedDictionary<string, int>();

            string command = Console.ReadLine();

            while (command != "exam finished")
            {
                string[] data = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string username = data[0];
                string language = data[1];

                if (language != "banned")
                {
                    int point = int.Parse(data[2]);
                    if (!studentResults.ContainsKey(username))
                    {
                        studentResults[username] = point;
                    }
                    else if (studentResults[username] < point)
                    {
                        studentResults[username] = point;
                    }

                    if (!statistic.ContainsKey(language))
                    {
                        statistic[language] = 0;
                    }
                    statistic[language]++;
                }
                else
                {
                    if (studentResults.ContainsKey(username))
                    {
                        studentResults.Remove(username);
                    }
                }

                command = Console.ReadLine(); 
            }
            var ordered = studentResults.OrderByDescending(user => user.Value);

            Console.WriteLine("Results:");
            if (ordered.Any())
            {
                foreach (var (student, point) in ordered)
                {
                    Console.WriteLine($"{student} | {point}");
                }
            }

            Console.WriteLine("Submissions:");
            foreach (var (item, entries) in statistic.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item} - {entries}");
            }
        }
    }
}
