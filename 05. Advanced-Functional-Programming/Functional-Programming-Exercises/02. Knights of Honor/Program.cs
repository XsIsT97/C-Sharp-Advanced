using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printName = Console.WriteLine;

            string[] names = Console.ReadLine().Split(' ');

            foreach (var name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
