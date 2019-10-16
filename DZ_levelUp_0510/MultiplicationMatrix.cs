using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class MultiplicationMatrix
    {
        static UserInterface UI = new UserInterface();


        int firstMatrixLength = 0;
        int firstMatrixHeight = 0;

        int secondMatrixLength = 0;
        int secondMatrixHeight = 0;

        public void MatrixMultiplication()
        {
            Console.WriteLine("Введите размерность первой матрицы: ");
            Console.Write("Матрица А [N,*] = ");

            firstMatrixLength = UI.DataInput(firstMatrixLength);

            Console.Write("Матрица А [*,M] = ");

            firstMatrixHeight = UI.DataInput(firstMatrixHeight);

            int[,] firstMatrix = new int[firstMatrixLength, firstMatrixHeight];

            UI.GetFillingTwoDimensionalArray(firstMatrix);

            Console.WriteLine("Введите размерность второй матрицы: ");
            Console.Write("Матрица B [N,*] = ");

            secondMatrixLength = UI.DataInput(secondMatrixLength);

            Console.Write("Матрица B [*,M] = ");

            secondMatrixHeight = UI.DataInput(secondMatrixHeight);

            int[,] secondMatrix = new int[secondMatrixLength, secondMatrixHeight];

            UI.GetFillingTwoDimensionalArray(secondMatrix);

            Console.WriteLine("\nМатрица A:");
            UI.PrintTwoDimensionalArray(firstMatrix);

            Console.WriteLine("\nМатрица B:");
            UI.PrintTwoDimensionalArray(secondMatrix);

            Console.WriteLine("\nМатрица C = A * B:");
            int[,] resultArray = GetMultiplicationMatrix(firstMatrix, secondMatrix);
            UI.PrintTwoDimensionalArray(resultArray);
        }

        static int[,] GetMultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
            {
                int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
                for (int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < secondMatrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < secondMatrix.GetLength(0); k++)
                        {
                            result [i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                        }
                    }
                }

                return result;
            }
            else
            {
                Console.WriteLine("Невозможно умножить матрицы!");

                int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
                
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = 0;
                    }
                }

                return result;
            }
        }
    }
}
