using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _03.__Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfQueries = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < numbersOfQueries; i++)
            {
                List<int> tempListOfElements = new List<int>();
                string[] queryType = Console.ReadLine().Split(' ');

                if (queryType[0] == "1")
                {
                    int elemnetToAdd = int.Parse(queryType[1]);
                    numbers.Push(elemnetToAdd);
                }
                else if (queryType[0] == "2")
                {
                    if (numbers.Count > 0)
                    {
                        numbers.Pop();
                    }
                }
                else if (queryType[0] == "3")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (queryType[0] == "4")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
