using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (!symbols.ContainsKey(symbol))
                {
                    symbols[symbol] = 0;
                }
                symbols[symbol]++;
            }

            foreach (var (symbol, count) in symbols)
            {
                Console.WriteLine($"{symbol}: {count} time/s");
            }
        }
    }
}
