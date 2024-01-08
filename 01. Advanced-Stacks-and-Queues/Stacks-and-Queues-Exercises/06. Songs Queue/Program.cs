using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> playlist = new Queue<string>(Console.ReadLine().Split(", "));

            while (playlist.Count > 0)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                string action = command[0];

                if (action == "Play")
                {
                    playlist.Dequeue();
                }
                else if (action == "Add")
                {
                    string songToAdd = string.Join(" ", command.Skip(1));

                    if (playlist.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        playlist.Enqueue(songToAdd);
                    }
                }
                else if (action == "Show")
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
