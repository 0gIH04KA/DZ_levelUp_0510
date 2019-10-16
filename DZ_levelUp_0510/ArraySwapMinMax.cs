   using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class ArraySwapMinMax
    {
        static UserInterface UI = new UserInterface();


        const int LOW_RANGE = -100,
                  HIGH_RANGE = 100;

        int sizeArray = 0;
        int indexMax = 0;
        int indexMin = 0;

        public void ArraySwap()
        {
            Console.Write("Задайте длину массива: ");

            sizeArray = UI.DataInput(sizeArray);

            int[] Array = new int[sizeArray];
            int[] ArraySwap = new int[sizeArray];

            UI.CreatArray(Array, LOW_RANGE, HIGH_RANGE);
            UI.PrintArray(Array);

            int minValue = MinElem(Array, ref indexMin);
            int maxValue = MaxElem(Array, ref indexMax);

            ArraySwap = Swap(Array, indexMin, minValue, indexMax, maxValue);
                        
            Console.ForegroundColor = ConsoleColor.Red;

            UI.PrintArray(ArraySwap);
            
            Console.ResetColor();

#if true
            Console.WriteLine($"min = {minValue}, IndexMin = {indexMin}");
            Console.WriteLine($"min = {maxValue}, IndexMax = {indexMax}");
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
    }
}
