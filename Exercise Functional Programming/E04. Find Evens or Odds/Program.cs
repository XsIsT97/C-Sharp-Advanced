using System;
using System.Collections.Generic;

namespace E04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int startNumber = int.Parse(input.Split()[0]);
            int endNumber = int.Parse(input.Split()[1]);

            List<int> numbers = new List<int>();
            for (int number = startNumber; number <= endNumber; number++)
            {
                numbers.Add(number);
            }

            Predicate<int> isEven = number => number % 2 == 0;

            string type = Console.ReadLine();
            if (type == "even")
            {
                foreach (int number in numbers)
                {
                    if (isEven(number))
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            else if (type == "odd")
            {
                foreach (int number in numbers)
                {
                    if (!isEven(number))
                    {
                        Console.Write(number + " ");
                    }
                }
            }
        }
    }
}
