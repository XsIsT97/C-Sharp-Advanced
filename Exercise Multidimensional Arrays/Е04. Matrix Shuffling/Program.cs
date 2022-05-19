using System;

namespace Е04._Matrix_Shuffling
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

            string command = Console.ReadLine();

            while (command != "END")
            {
                //проверка дали командата е валидна
                //проверка дали редовете или колоните
                if (!ValidateCommand(command, rows, cols))
                {
                    //make invalid command
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    //take all valid commands
                    string[] commandParts = command.Split();
                    int row1 = int.Parse(commandParts[1]);
                    int col1 = int.Parse(commandParts[2]);
                    int row2 = int.Parse(commandParts[3]);
                    int col2 = int.Parse(commandParts[4]);
                    //take first element row
                    string firstElement = matrix[row1, col1];
                    //takes second element col
                    string secondElement = matrix[row2, col2];
                    //swap elements
                    matrix[row2, col2] = firstElement;
                    matrix[row1, col1] = secondElement;

                    PrintMatrix(matrix);
                }
                command = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            //Print Matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool ValidateCommand(string command, int rows, int cols)
        {
            //true or false 
            //if command is swap
            //if command have 5 pieses

            string[] commandParts = command.Split();

            if (commandParts[0] == "swap" && commandParts.Length == 5)
            {
                //valid command
                int row1 = int.Parse(commandParts[1]);
                int col1 = int.Parse(commandParts[2]);
                int row2 = int.Parse(commandParts[3]);
                int col2 = int.Parse(commandParts[4]);

                if (row1 >= 0 && row1 < rows
                    && col1 >= 0 && col1 < cols
                    && row2 >= 0 && row2 < rows
                    && col2 >= 0 && col2 < cols)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
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
