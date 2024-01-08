using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> boxes = new Stack<int>(clothes);

            int countOfRacks = 1;
            int spaceAvailbleOnRack = rackCapacity;

            while (boxes.Count > 0)
            {
                int currentPileOfClothes = boxes.Peek();

                if (currentPileOfClothes <= spaceAvailbleOnRack)
                {
                    boxes.Pop();
                    spaceAvailbleOnRack -= currentPileOfClothes;
                }
                else
                {
                    countOfRacks++;
                    spaceAvailbleOnRack = rackCapacity;
                }
            }
            Console.WriteLine(countOfRacks);
        }
    }
}
