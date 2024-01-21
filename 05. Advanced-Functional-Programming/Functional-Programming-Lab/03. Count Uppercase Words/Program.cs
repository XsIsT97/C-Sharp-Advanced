using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(word => char.IsUpper(word[0]))
                .ToArray();

            foreach (string item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
