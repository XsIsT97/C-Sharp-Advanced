using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> calculate = new Stack<string>(Console.ReadLine().Split(' ').Reverse());

            while (calculate.Count > 1)
            {
                int firsNumber = int.Parse(calculate.Pop());
                string command = calculate.Pop();
                int secondNumber = int.Parse(calculate.Pop());

                if (command == "-")
                {
                    var subtract = (firsNumber - secondNumber).ToString();
                    calculate.Push(subtract);
                }
                else if (command == "+")
                {
                    var addition = (firsNumber + secondNumber).ToString();
                    calculate.Push(addition);
                }
            }
            Console.WriteLine(calculate.Peek());
        }
    }
}
