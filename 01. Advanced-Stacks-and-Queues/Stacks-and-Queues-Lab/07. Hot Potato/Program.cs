﻿using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split(' '));
            int numbersOfTrols = int.Parse(Console.ReadLine());

            while (kids.Count > 1)
            {
                for (int i = 1; i < numbersOfTrols; i++)
                {
                    string tempKid = kids.Dequeue();
                    kids.Enqueue(tempKid);
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }
            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}
