using System;
using System.Linq;

namespace Е01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseStringToInt = x => int.Parse(x);

            Func<int, bool> isEven = x => x % 2 == 0;

            Func<int, int> identity = n => n;

            string input = Console.ReadLine();
            string[] token = input.Split(", ");
            int[] nums = token.Select(parseStringToInt).ToArray();
            int[] evenNumbers = nums.Where(isEven).ToArray();
            int[] orderNumbers = evenNumbers.OrderBy(identity).ToArray();

            Console.WriteLine(String.Join(", ", orderNumbers));
        }
    }
}
