using System;
using System.Linq;

namespace Е01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // напълваме матрицата
            int[,] numbers = new int[n, n];

            FillMatrix(numbers);
            // сума от главния диагонал ред == колона
            int sumPrimaryDiagonal = 0;
            // сума от второстепенния диафонал ред + колона = n - 1
            int sumSecondaryDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int number = numbers[row, col];

                    if (row == col)
                    {
                        // числото е на главния диагонал
                        sumPrimaryDiagonal += number;
                    }
                    
                    if (row + col == n - 1)
                    {
                        // числото е на второстепенния
                        sumSecondaryDiagonal += number;
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
        }

        private static void FillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < rowData.Length; col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
}
