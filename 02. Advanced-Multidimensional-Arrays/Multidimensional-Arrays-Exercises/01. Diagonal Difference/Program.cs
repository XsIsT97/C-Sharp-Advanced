using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                primaryDiagonalSum += rowData[row];
                secondaryDiagonalSum += rowData[n - row - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
