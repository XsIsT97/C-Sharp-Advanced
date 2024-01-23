using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetLenght = int.Parse(Console.ReadLine());
            List<string> name = Console.ReadLine().Split(' ').ToList();

            Func<string, bool> function = name => name.Length <= targetLenght;

            name = name.Where(function).ToList();

            Action<List<string>> print = name => Console.WriteLine(string.Join(Environment.NewLine, name));

            print(name);
        }
    }
}
