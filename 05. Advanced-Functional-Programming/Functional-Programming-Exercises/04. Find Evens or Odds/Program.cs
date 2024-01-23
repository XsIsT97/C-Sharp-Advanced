using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = input[0];
            var end = input[1];

            var targetNumbers = Console.ReadLine().Trim().ToLower();
            Predicate<int> predicate;

            switch (targetNumbers)
            {
                case "odd":
                    predicate = n => n % 2 != 0;
                    break;
                case "even":
                    predicate = n => n % 2 == 0;
                    break;
                default:
                    predicate = null;
                    break;
            }

            var result = EvenOrOdds(start, end, predicate);
            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> EvenOrOdds(int lowerBound, int upperBound, Predicate<int> filter)
        {
            var numbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (filter(i))
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }
    }
}
