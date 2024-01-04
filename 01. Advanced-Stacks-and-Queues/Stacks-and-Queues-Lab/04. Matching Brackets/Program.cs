using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exprecion = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < exprecion.Length; i++)
            {
                if (exprecion[i] == '(')
                {
                    stack.Push(i);
                }
                else if (exprecion[i] == ')')
                {
                    int openBracketIndex = stack.Pop();
                    int closeBracketIndex = i;

                    Console.WriteLine(exprecion.Substring(openBracketIndex, closeBracketIndex - openBracketIndex + 1));
                }
            }
        }
    }
}
