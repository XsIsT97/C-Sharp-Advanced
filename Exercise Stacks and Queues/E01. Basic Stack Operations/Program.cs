using System;
using System.Collections.Generic;
using System.Linq;

namespace E01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            List<int> numberList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>();
            // count Pusht elements

            for (int i = 0; i < n; i++)
            {
                stack.Push(numberList[i]);
            }

            // count Pop elements

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            // count Contains elements

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min()); // steck min element
            }
        }
    }
}
