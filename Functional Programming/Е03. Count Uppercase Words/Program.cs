using System;
using System.Linq;

namespace Е03._Count_Uppercase_Words
{
    internal class Program
    {
        static Func<string, bool> isFirstLetterCapital =
        x => x.Length > 0 && char.IsUpper(x[0]);

            static void Main() =>
                Console.WriteLine(
                    String.Join(
                        "\r\n",
                        Console.ReadLine()
                        .Split(" ")
                        .Where(isFirstLetterCapital)
                    )
                );
    }
}
