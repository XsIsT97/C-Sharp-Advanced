using System;
using System.Collections.Generic;
using System.Linq;

namespace E03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int> getMinElemnet = numbers => numbers.Min();

            Console.WriteLine(getMinElemnet(numbers));
        }
    }
}
