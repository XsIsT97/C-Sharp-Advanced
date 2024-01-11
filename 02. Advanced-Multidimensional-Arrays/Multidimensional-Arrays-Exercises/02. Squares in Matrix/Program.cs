using System;

namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализарене на Матрица
            string[] matrixDemetion = Console.ReadLine().Split(' ');
            int rows = int.Parse(matrixDemetion[0]);
            int cols = int.Parse(matrixDemetion[1]);

            string[,] matrix = new string[rows, cols];

            // Пълнене на Матрица
            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int counter = 0;
            // Калкулация на групите еднакви Матрици в Матрица
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    // Проверка дали в матрица пример [0,0] е еднаква с матрица [0,1] с матрица [1,0] или с матрица [1,1]
                    if (matrix[i,j] == matrix[i,j+1] && matrix[i+1,j] == matrix[i+1,j+1] && matrix[i,j] == matrix[i+1,j+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
