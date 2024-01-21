using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVatFunc = price => price * 1.2;
            var prices = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(addVatFunc)
                .ToArray();

            foreach (var item in prices)
            {
                Console.WriteLine($"{item:F2}");
            }
        }
    }
}
