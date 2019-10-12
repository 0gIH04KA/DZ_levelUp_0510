using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class MultiplicationMatrix
    {
        static UserInterface UI = new UserInterface();

        int A_N = 0;
        int A_M = 0;
        int B_N = 0;
        int B_M = 0;

        public void MatrixMultiplication()
        {
            Console.WriteLine("Введите размерность первой матрицы: ");
            Console.Write("Матрица А [N,*] = ");
            
            A_N = UI.DataInput(A_N);

            Console.Write("Матрица А [*,M] = ");

            A_M = UI.DataInput(A_M);

            int[,] A = new int[A_N, A_M];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}] = ");

                    A[i, j] = UI.DataInput(A[i, j]);
                }
            }

            Console.WriteLine("Введите размерность второй матрицы: ");
            Console.Write("Матрица B [N,*] = ");

            B_N = UI.DataInput(B_N);

            Console.Write("Матрица B [*,M] = ");

            B_M = UI.DataInput(B_M);

            int[,] B = new int[B_N, B_M];

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"B[{i},{j}] = ");

                    B[i, j] = UI.DataInput(B[i, j]);
                }
            }

            Console.WriteLine("\nМатрица A:");
            UI.PrintArray_N_M(A);
            
            Console.WriteLine("\nМатрица B:");
            UI.PrintArray_N_M(B);
           
            Console.WriteLine("\nМатрица C = A * B:");
            int[,] C = Multiplication(A, B);
            UI.PrintArray_N_M(C);

        }
        static int[,] Multiplication(int[,] arrayA, int[,] arrayB)
        {
            if (arrayA.GetLength(1) == arrayB.GetLength(0))
            {
                int[,] result = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
                for (int i = 0; i < arrayA.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayB.GetLength(1); j++)
                    {
                        for (int k = 0; k < arrayB.GetLength(0); k++)
                        {
                            result [i, j] += arrayA[i, k] * arrayB[k, j];
                        }
                    }
                }

                return result;
            }
            else
            {
                Console.WriteLine("Невозможно умножить матрицы!");

                int[,] result = new int[2, 2] { { 0, 0}, { 0, 0 } };

                return result;
            }
        }
    }
}
