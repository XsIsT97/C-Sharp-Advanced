using System;

namespace _01._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printName = Console.WriteLine;

            string[] name = Console.ReadLine().Split(' ');

            foreach (var item in name)
            {
                printName(item);
            }
        }
    }
}
