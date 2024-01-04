using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] argument = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = argument[0];

                if (action == "add")
                {
                    numbers.Push(int.Parse(argument[1]));
                    numbers.Push(int.Parse(argument[2]));
                }
                else if (action == "remove")
                {
                    int numberToRemove = int.Parse(argument[1]);

                    if (numberToRemove <= numbers.Count)
                    {
                        for (int i = 0; i < numberToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
