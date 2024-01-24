using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rangeOfNumbers = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1, rangeOfNumbers).ToList();
            List<int> dividers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            foreach (var divider in dividers)
            {
                Func<int, bool> predicate = num => num % divider == 0;

                numbers = numbers.Where(predicate).ToList();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
