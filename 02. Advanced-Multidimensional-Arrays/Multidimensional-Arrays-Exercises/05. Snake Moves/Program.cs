using System;
using System.Collections.Generic;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] matrixParam = Console.ReadLine().Split(' ');
            int rows = int.Parse(matrixParam[0]);
            int cols = int.Parse(matrixParam[1]);

            string snake = Console.ReadLine();
            Queue<char> charQueue = new Queue<char>(snake);
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = charQueue.Peek();
                        charQueue.Enqueue(charQueue.Dequeue());
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = charQueue.Peek();
                        charQueue.Enqueue(charQueue.Dequeue());
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
