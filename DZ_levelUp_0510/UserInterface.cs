using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class UserInterface
    {
        static Random random = new Random();


        public int DataInput(int numbers)
        {
            while (!int.TryParse(Console.ReadLine(), out numbers))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ошибка ввода!!");
                Console.ResetColor();
            }

            return numbers;
        }

        public void CreatArray(int[] Array, int lowRange, int highRange)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(lowRange, highRange);
            }
        }

        public void PrintArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}\t", Array[i]);
            }

            Console.WriteLine();
        }

        public void PrintArray_N_M(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("{0} ", Array[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
