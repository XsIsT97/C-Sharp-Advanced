using System;

namespace E02.Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int rows = 0;
            int cols = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElems = Console.ReadLine().Replace(" ", "").ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElems[col];
                    if (matrix[row, col] == 'V')
                    {
                        rows = row;
                        cols = col;
                    }
                }
            }
            string direction;
            int numOfHoles = 1;
            int numOfRods = 0;

            while ((direction = Console.ReadLine()) != "End")
            {
                if (direction == "up")
                {
                    if (rows - 1 >= 0 && rows - 1 < matrix.GetLength(0) &&
                   cols >= 0 && cols < matrix.GetLength(1))
                    {

                        if (matrix[rows - 1, cols] == '-')
                        {
                            matrix[rows, cols] = '*';
                            matrix[rows - 1, cols] = '*';
                            rows = rows - 1;
                            numOfHoles++;
                        }
                        else if (matrix[rows - 1, cols] == 'R')
                        {
                            numOfRods++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (matrix[rows - 1, cols] == 'C')
                        {
                            numOfHoles++;
                            matrix[rows - 1, cols] = 'E';
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {numOfHoles} hole(s).");
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write(matrix[row, col]);
                                }

                                Console.WriteLine();
                            }
                            return;

                        }
                        else if (matrix[rows - 1, cols] == '*')
                        {
                            rows = rows - 1;
                            Console.WriteLine($"The wall is already destroyed at position [{rows}, {cols}]!");
                        }
                    }
                }
                else if (direction == "down")
                {
                    if (rows + 1 >= 0 && rows + 1 < matrix.GetLength(0) &&
                   cols >= 0 && cols < matrix.GetLength(1))
                    {

                        if (matrix[rows + 1, cols] == '-')
                        {
                            matrix[rows, cols] = '*';
                            matrix[rows + 1, cols] = '*';
                            rows = rows + 1;
                            numOfHoles++;
                        }
                        else if (matrix[rows + 1, cols] == 'R')
                        {
                            numOfRods++;
                            Console.WriteLine("Vanko hit a rod!");
                            continue;
                        }
                        else if (matrix[rows + 1, cols] == 'C')
                        {
                            numOfHoles++;
                            matrix[rows + 1, cols] = 'E';
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {numOfHoles} hole(s).");
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write(matrix[row, col]);
                                }

                                Console.WriteLine();
                            }
                            return;

                        }
                        else if (matrix[rows + 1, cols] == '*')
                        {
                            rows = rows + 1;
                            Console.WriteLine($"The wall is already destroyed at position [{rows}, {cols}]!");
                        }
                    }
                }
                else if (direction == "left")
                {
                    if (rows >= 0 && rows < matrix.GetLength(0) &&
                   cols - 1 >= 0 && cols - 1 < matrix.GetLength(1))
                    {

                        if (matrix[rows, cols - 1] == '-')
                        {
                            matrix[rows, cols] = '*';
                            matrix[rows, cols - 1] = '*';
                            cols = cols - 1;
                            numOfHoles++;
                        }
                        else if (matrix[rows, cols - 1] == 'R')
                        {
                            numOfRods++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (matrix[rows, cols - 1] == 'C')
                        {
                            numOfHoles++;
                            matrix[rows, cols - 1] = 'E';
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {numOfHoles} hole(s).");
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write(matrix[row, col]);
                                }

                                Console.WriteLine();
                            }
                            return;

                        }
                        else if (matrix[rows, cols - 1] == '*')
                        {
                            cols = cols - 1;
                            Console.WriteLine($"The wall is already destroyed at position [{rows}, {cols}]!");
                        }
                    }
                }
                else
                {
                    if (rows >= 0 && rows < matrix.GetLength(0) &&
                   cols + 1 >= 0 && cols + 1 < matrix.GetLength(1))
                    {

                        if (matrix[rows, cols + 1] == '-')
                        {
                            matrix[rows, cols] = '*';
                            matrix[rows, cols + 1] = '*';
                            cols = cols + 1;
                            numOfHoles++;
                        }
                        else if (matrix[rows, cols + 1] == 'R')
                        {
                            numOfRods++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (matrix[rows, cols + 1] == 'C')
                        {
                            numOfHoles++;
                            matrix[rows, cols + 1] = 'E';
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {numOfHoles} hole(s).");
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write(matrix[row, col]);
                                }
                                Console.WriteLine();
                            }
                            return;

                        }
                        else if (matrix[rows, cols + 1] == '*')
                        {
                            cols = cols + 1;
                            Console.WriteLine($"The wall is already destroyed at position [{rows}, {cols}]!");
                        }
                    }
                }
            }
            matrix[rows, cols] = 'V';
            Console.WriteLine($"Vanko managed to make {numOfHoles} hole(s) and he hit only {numOfRods} rod(s).");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }   
    }
}
