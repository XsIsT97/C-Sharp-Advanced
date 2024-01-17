using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, decimal>> shops = new SortedDictionary<string, Dictionary<string, decimal>>();

            string command = Console.ReadLine();
            while (command != "Revision")
            {
                string[] shopData = command.Split(", ");
                string shop = shopData[0];
                string product = shopData[1];
                decimal price = decimal.Parse(shopData[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, decimal>();
                }
                shops[shop][product] = price;

                command = Console.ReadLine(); 
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value:F2}");
                }
            }
        }
    }
}
