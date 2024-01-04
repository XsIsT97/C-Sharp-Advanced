using System;
using System.Collections.Generic;

namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> chars = new Stack<string>();

            foreach (var c in input)
            {
                chars.Push(c.ToString());
            }

            while (chars.Count > 0)
            {
                Console.Write(chars.Pop());
            }
            Console.WriteLine();
        }
    }
}
