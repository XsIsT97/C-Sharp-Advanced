using System;

namespace Е02.__2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);

            string[,] matrix = new string[rows, cols];
            FillMatrix(matrix);

            int count = 0; // брой на матриците 2 x 2

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] 
                        && matrix[row, col] == matrix[row + 1, col] 
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        // Матрица 2x2, на която всички елементи са еднакви
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
