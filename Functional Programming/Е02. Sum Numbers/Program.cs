using System;
using System.Linq;

namespace Е02._Sum_Numbers
{
    internal class Program
    {
        static int Parse(string str) => int.Parse(str);

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] nums = input.Split(", ").Select(Parse).ToArray();

            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }
    }
}
