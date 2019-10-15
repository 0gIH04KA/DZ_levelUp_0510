using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class ArrayTwoDimensionalSwapMinMax
    {
        static UserInterface UI = new UserInterface();

        const int LOW_RANGE = -100,
                  HIGH_RANGE = 100;

        int indexMax_i = 0;
        int indexMax_j = 0;

        int indexMin_i = 0;
        int indexMin_j = 0;

        int matrixLength = 0;
        int matrixHeight = 0;

        public void ArrayTwoDimensionalSwap()
        {
            Console.WriteLine("Задайте размер Матрицы: ");

            Console.Write("Длина матрицы [N,*] = ");

            matrixLength = UI.DataInput(matrixLength);

            Console.Write("Высота матрицы [*,M] = ");

            matrixHeight = UI.DataInput(matrixHeight);

            int[,] Matrix = new int[matrixLength, matrixHeight];

            int[,] ArraySwap = new int[matrixLength, matrixHeight];

            UI.CreatTwoDimensionalArray(Matrix, LOW_RANGE, HIGH_RANGE);

            Console.WriteLine("Mатрица до:");
            UI.PrintTwoDimensionalArray(Matrix);

            int minValue = MinElem(Matrix, ref indexMin_i, ref indexMin_j);
            int maxValue = MaxElem(Matrix, ref indexMax_i, ref indexMax_j);

            ArraySwap = Swap(Matrix, indexMin_i, indexMin_j, minValue, indexMax_i, indexMax_j, maxValue);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Mатрица после:");

            UI.PrintTwoDimensionalArray(ArraySwap);

            Console.ResetColor();
#if true
            Console.WriteLine($"min = {minValue}, IndexMin_i = {indexMin_i}, IndexMin_j = {indexMin_j}");
            Console.WriteLine($"min = {maxValue}, IndexMax_i = {indexMax_i}, IndexMax_j = {indexMax_j}");
#endif
        }

        static int MinElem(int[,] Array, ref int indexMin_i, ref int indexMin_j)
        {
            int min = int.MaxValue;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] < min)
                    {
                        min = Array[i, j];
                        indexMin_i = i;
                        indexMin_j = j;
                    }
                }
            }

            return min;
        }

        static int MaxElem(int[,] Array, ref int indexMax_i, ref int indexMax_j)
        {
            int max = int.MinValue;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] > max)
                    {
                        max = Array[i, j];
                        indexMax_i = i;
                        indexMax_j = j;
                    }
                }
            }

            return max;
        }

        static int[,] Swap(int[,] Array, int indexMin_i, int indexMin_j, int min, int indexMax_i, int indexMax_j, int max)
        {
            Array[indexMin_i, indexMin_j] = max;
            Array[indexMax_i, indexMax_j] = min;

            return Array;
        }
    }
}
