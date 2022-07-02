using System;
using System.Collections.Generic;
using System.Linq;

namespace Е01.Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създавам си Белите плочки

            int[] whiteTails = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Създавам си Сивите плочки

            int[] greyTails = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            // Създаваме си нови Stack and Queue

            Stack<int> whiteStack = new Stack<int>(whiteTails);
            Queue<int> greyQueue = new Queue<int>(greyTails);

            //Правим Sorted Dictionery зарави (sorted ascending alphabetically)

            SortedDictionary<string, int> locations = new SortedDictionary<string, int>()
            {
                {"Countertop" , 0 },
                {"Floor" , 0 },
                {"Oven" , 0 },
                {"Sink" , 0 },
                {"Wall" , 0 }
            };

            //Правим While цикъл

            while (whiteStack.Count > 0 && greyQueue.Count > 0)
            {
                //Намирам моментната стойност на Белите и Сивите плочки
                int currWhite = whiteStack.Peek();
                int currGrey = greyQueue.Peek();

                int sum = currGrey + currWhite;

                if (currWhite == currGrey)
                {
                    // обработвам наличната информация спрямо получените плочки
                    if (sum == 40)
                    {
                        locations["Sink"]++;
                        whiteStack.Pop();
                        greyQueue.Dequeue();
                    }
                    else if (sum == 50)
                    {
                        locations["Oven"]++;
                        whiteStack.Pop();
                        greyQueue.Dequeue();
                    }
                    else if (sum == 60)
                    {
                        locations["Countertop"]++;
                        whiteStack.Pop();
                        greyQueue.Dequeue();
                    }
                    else if (sum == 70)
                    {
                        locations["Wall"]++;
                        whiteStack.Pop();
                        greyQueue.Dequeue();
                    }
                    else
                    {
                        locations["Floor"]++;
                        whiteStack.Pop();
                        greyQueue.Dequeue();
                    }
                }
                else
                {
                    int newWhite = currWhite / 2;
                    whiteStack.Pop();
                    greyQueue.Dequeue();
                    whiteStack.Push(newWhite);
                    greyQueue.Enqueue(currGrey);
                }
            }

            // Отсявам останалите Бели и Сиви плочки
            if (whiteStack.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteStack)}");
            }

            if (greyQueue.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyQueue)}");
            }

            //Сортирам (ordered descending by number)
            foreach (var location in locations.OrderByDescending(key => key.Value).Where(bake => bake.Value > 0))
            {
                string type = location.Key;
                int count = location.Value;
                Console.WriteLine($"{type}: {count}");
            }
        }
    }
}
