using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> iterator = null;
            string input = Console.ReadLine();

            while (!input.Contains("END"))
            {
                string[] commands = input.Split(' ');
                string action = commands[0];

                if (action == "Create")
                {
                    List<string> list = commands.Skip(1).ToList();
                    iterator = new ListyIterator<string>(list);
                }
                else if (action == "Move")
                {
                    Console.WriteLine(iterator.Move());
                }
                else if (action == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
                else if (action == "Print")
                {
                    try
                    {
                        iterator.Print();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                    break;
                }

                input = Console.ReadLine();
            }
        }
        public static void Create(List<string> collection)
        {
            var iterator = new ListyIterator<string>(collection);
        }
    }
}
