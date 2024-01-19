using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> element = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elemnts = Console.ReadLine().Split(' ');

                foreach (var item in elemnts)
                {
                    element.Add(item);
                }
            }

            var orderedElements = element.OrderBy(el => el);

            Console.WriteLine(string.Join(' ', orderedElements));
        }
    }
}
