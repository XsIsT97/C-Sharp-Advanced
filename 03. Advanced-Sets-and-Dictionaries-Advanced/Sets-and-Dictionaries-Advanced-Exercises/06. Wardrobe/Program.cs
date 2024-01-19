using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfColors = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfColors; i++)
            {
                string[] wardrobData = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = wardrobData[0];
                string[] itemOfClothing = wardrobData[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var item in itemOfClothing)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }
                    wardrobe[color][item]++;
                }
            }

            string[] itemToLookFor = Console.ReadLine().Split(' ');
            string serchedColor = itemToLookFor[0];
            string serchedItem = itemToLookFor[1];

            foreach (var (color, item) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (price, count) in item)
                {
                    if (color == serchedColor && price == serchedItem)
                    {
                        Console.WriteLine($"* {price} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {price} - {count}");
                    }
                }
            }
        }
    }
}
