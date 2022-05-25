using System;
using System.Collections.Generic;

namespace Е01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //брой usernames
            HashSet<string> usernames = new HashSet<string>();

            for (int i = 1; i <= n; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }

            Console.WriteLine(string.Join(Environment.NewLine, usernames));
        }
    }
}
