using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersParam = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int N = numbersParam[0];
            int S = numbersParam[1];
            int X = numbersParam[2];

            Queue<int> queue = new Queue<int>();

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int j = 0; j < S; j++)
            {
                if (queue.Any())// chek if queue is empty or not return bool like true or false
                {
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Any() ? queue.Min() : 0);// this check if queue is empty if is
                                                                 // empty return false and return 0 if is
                                                                 // not empty return the smalest element and return true
            }
        }
    }
}
