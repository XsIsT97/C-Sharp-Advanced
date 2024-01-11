using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] matrixDetails = Console.ReadLine().Split(' ');
            int rows = int.Parse(matrixDetails[0]);
            int cols = int.Parse(matrixDetails[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int hightSum = int.MinValue;
            int hightRow = 0;
            int hightCol = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int subMatrix = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            subMatrix += matrix[row + i, col + j];
                        }
                    }

                    if (subMatrix > hightSum)
                    {
                        hightSum = subMatrix;
                        hightRow = row;
                        hightCol = col;
                    }
                }
            }

            Console.WriteLine("Sum = " + hightSum);

            for (int row = hightRow; row < hightRow + 3; row++)
            {
                for (int col = hightCol;  col < hightCol + 3;  col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
