﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace E02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, string> addPrefix = name => "Sir " + name;

            //names.ForEach(name => Console.WriteLine(addPrefix));

            foreach (var name in names)
            {
                Console.WriteLine(addPrefix(name));
            }
        }
    }
}
