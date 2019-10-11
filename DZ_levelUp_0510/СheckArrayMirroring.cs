using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class СheckArrayMirroring 
    {
        static UserInterface UI = new UserInterface();

        public void ArrayMirroring()
        {
            int sizeArray = 0;
            Console.Write("Задайте размер массива: ");

            sizeArray = UI.dataInput(sizeArray);

            int[] Array = new int[sizeArray];

            FillArray(Array);

            Console.Write("Array:\t");

            UI.PrintArray(Array);

            Console.WriteLine();
            Console.WriteLine(CompareArray(Array));
            Console.WriteLine();
        }

        static void FillArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; ++i)
            {
                Console.Write($"Array [{i}] = ");

                while (!int.TryParse(Console.ReadLine(), out Array[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Ошибка ввода!!");
                    Console.ResetColor();

                    Console.Write($"Array [{i}] = ");
                }
            }
        }

        static string CompareArray(int[] Array)
        {
            int count = Array.Length / 2;
            string str = string.Empty;

            if (Array.Length > 1)
            {
                for (int i = 0; i < (Array.Length / 2); i++)
                {
                    if (Array[i] != Array[Array.Length - i - 1])
                    {
                        str = "Массив НЕ является зеркальным";
                        break;
                    }
                    else
                    {
                        count -= 1;
                        if (count == 0)
                        {
                            str = "Массив зекальынй";
                        }
                    }
                }
            }
            else
            {
                str = "Длина массива равна 1";
            }

            return str;
        }
    }
}
