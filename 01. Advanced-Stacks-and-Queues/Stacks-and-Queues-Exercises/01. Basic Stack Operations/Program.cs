using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input =Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < S; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Any() ? stack.Min() : 0);
            }
        }
    }
}
