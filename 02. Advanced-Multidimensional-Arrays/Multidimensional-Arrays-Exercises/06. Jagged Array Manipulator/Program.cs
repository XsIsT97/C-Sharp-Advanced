using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                jaggedArray[row] = new double[numbers.Length];

                for (int col = 0; col < numbers.Length; col++)
                {
                    jaggedArray[row][col] = numbers[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x * 2).ToArray();
                    jaggedArray[row +1] = jaggedArray[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x / 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(x => x / 2).ToArray();
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int val = int.Parse(command[3]);

                if (!ChekCoordinatesValidite(row, col, val, jaggedArray))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (action == "Add")
                {
                    jaggedArray[row][col] += val;
                }
                else if (action == "Subtract")
                {
                    jaggedArray[row][col] -= val;
                }
                input = Console.ReadLine();
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }

        private static bool ChekCoordinatesValidite(int row, int col, int val, double[][] jaggedArray)
        {
            return row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length;
        }
    }
}
