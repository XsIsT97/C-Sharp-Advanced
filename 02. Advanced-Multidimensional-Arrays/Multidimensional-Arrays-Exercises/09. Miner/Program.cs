using System;
using System.Linq;

namespace _09._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[,] field = new char[fieldSize, fieldSize];

            int minerRow = 0, minerCol = 0, totalCoals = 0;
            for (int row = 0; row < fieldSize; row++)
            {
                char[] rowElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = rowElements[col];
                    if (field[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    if (field[row, col] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }

            int collectedCoals = 0;
            foreach (var command in commands)
            {
                int newRow = minerRow, newCol = minerCol;
                if (command == "up") newRow--;
                else if (command == "down") newRow++;
                else if (command == "left") newCol--;
                else if (command == "right") newCol++;

                if (newRow < 0 || newRow >= fieldSize || newCol < 0 || newCol >= fieldSize)
                    continue;

                minerRow = newRow;
                minerCol = newCol;

                if (field[minerRow, minerCol] == 'c')
                {
                    collectedCoals++;
                    field[minerRow, minerCol] = '*';
                    if (collectedCoals == totalCoals)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        return;
                    }
                }
                else if (field[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    return;
                }
            }

            Console.WriteLine($"{totalCoals - collectedCoals} coals left. ({minerRow}, {minerCol})");
        }
    }
}
