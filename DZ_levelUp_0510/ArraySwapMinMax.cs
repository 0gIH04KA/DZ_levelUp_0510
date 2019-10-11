using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class ArraySwapMinMax
    {
        static Random random = new Random();
        static UserInterface UI = new UserInterface();

        const int LOW_RANGE = -100,
                  HIGH_RANGE = 100;

        int indexMax = 0;
        int indexMin = 0;

        public void ArraySwap()
        {
            int sizeArray = 0;
            Console.Write("Задайте размер массива: ");

            sizeArray = UI.dataInput(sizeArray);

            int[] Array = new int[sizeArray];
            int[] ArraySwap = new int[sizeArray];

            CreatArray(Array, LOW_RANGE, HIGH_RANGE);
            PrintArray(Array);

            int min = MinElem(Array, ref indexMin);
            int max = MaxElem(Array, ref indexMax);

            ArraySwap = Swap(Array, indexMin, min, indexMax, max);
                        
            Console.ForegroundColor = ConsoleColor.Red;

            PrintArray(ArraySwap);
            
            Console.ResetColor();

#if true
            Console.WriteLine($"min = {min}, IndexMin = {indexMin}");
            Console.WriteLine($"min = {max}, IndexMax = {indexMax}");
#endif

        }

        static int MaxElem(int[] Array, ref int indexMax)
        {
            int max = int.MinValue;

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                    indexMax = i;
                }
            }

            return max;
        }

        static int MinElem(int[] Array, ref int indexMin)
        {
            int min = int.MaxValue;

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] < min)
                {
                    min = Array[i];
                    indexMin = i;
                }
            }

            return min;
        }

        static int[] Swap(int[] Array, int indexMin, int min, int indexMax, int max)
        {
            Array[indexMin] = max;
            Array[indexMax] = min;

            return Array;
        }


        static void CreatArray(int[] Array, int lowRange, int highRange)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(lowRange, highRange);
            }
        }

        static void PrintArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}\t", Array[i]);
            }
            Console.WriteLine();
        }
    }
}
