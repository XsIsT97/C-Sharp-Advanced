using System;
using System.Collections.Generic;
using System.Linq;

namespace E04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            List<int> ordersList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Queue<int> ordersQueue = new Queue<int>(ordersList);

            Console.WriteLine(ordersQueue.Max()); // max order on the line

            // Начало на поръчките
            int countOrders = ordersQueue.Count;
            for (int order = 1; order <= countOrders; order++)
            {
                // Проверка дали наличната храна покрива поръчката
                if (quantityFood >= ordersQueue.Peek())
                {
                    // Изпълняване на поръчката
                    quantityFood -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                }
                else
                {
                    // Прекратява изпълняването на поръчки
                    break;
                }
            }

            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + String.Join(" ", ordersQueue));
            }
        }
    }
}
