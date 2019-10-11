using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class UserInterface
    {
        static Random random = new Random();


        public int dataInput(int numbers)
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

    }
}
