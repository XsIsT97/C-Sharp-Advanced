using System;

namespace Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                { 10, 20 , 30},
                { 40, 50 , 60},
            };

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(matrix[r, c]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
