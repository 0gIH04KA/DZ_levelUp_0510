﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class ArraySortTypes
    {
        static UserInterface UI = new UserInterface();


        const int LOW_RANGE = -100,
                  HIGH_RANGE = 100;

        public void QuickSortArray(int[] Arr)
        {
            Console.WriteLine("Quick Sort: \n");
            Console.WriteLine("Array: ");

            UI.CreatArray(Arr, LOW_RANGE, HIGH_RANGE);
            UI.PrintArray(Arr);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Quick Sort Array: ");

            Array.Sort(Arr);
            UI.PrintArray(Arr);
        }

        public void BubbleSort(int[] Arr)
        {
            Console.WriteLine("Bubble Sort: \n");
            Console.WriteLine("Array: ");

            UI.CreatArray(Arr, LOW_RANGE, HIGH_RANGE);
            UI.PrintArray(Arr);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bubble Sort Array");

            GetBubbleSort(Arr);
            UI.PrintArray(Arr);
        }

        static void GetBubbleSort(int[] Arr)
        {
            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
        }

        public void ShellSort(int[] Arr)
        {
            Console.WriteLine("ShellSort: \n");
            Console.WriteLine("Array: ");

            UI.CreatArray(Arr, LOW_RANGE, HIGH_RANGE);
            UI.PrintArray(Arr);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Shell Sort Array");

            GetShellSort(Arr);
            UI.PrintArray(Arr);
        }

        static void GetShellSort(int[] Arr)
        {
            const int SHELL_INTERVAL = 2;       // первоначально используемая Шеллом последовательность длин промежутков: N / 2
         // const int STEP_INTERVAL_3 = 3;      // длинa промежутков: N / 3
         // const int STEP_INTERVAL_5 = 5;      // длинa промежутков: N / 5

            int step = Arr.Length / SHELL_INTERVAL;

            while (step > 0)
            {
                int i, j;

                for (i = step; i < Arr.Length; i++)
                {
                    int value = Arr[i];

                    for (j = i - step; (j >= 0) && (Arr[j] > value); j -= step)
                    {
                        Arr[j + step] = Arr[j];
                    }

                    Arr[j + step] = value;
                }

                step /= SHELL_INTERVAL;
            }
        }

        public void ShakerSort(int[] Arr)
        {
            Console.WriteLine("Shaker Sort: \n");
            Console.WriteLine("Array: ");

            UI.CreatArray(Arr, LOW_RANGE, HIGH_RANGE);
            UI.PrintArray(Arr);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Shaker Sort Array");

            GetShakerSort(Arr);
            UI.PrintArray(Arr);
        }

        static void GetShakerSort(int[] Arr)
        {
            int left = 0;
            int right = Arr.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (Arr[i] > Arr[i + 1])
                    {
                        Swap(Arr, i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (Arr[i - 1] > Arr[i])
                    {
                        Swap(Arr, i - 1, i);
                    }
                }

                left++;
            }
        }

        static void Swap(int[] Arr, int i, int j)
        {
            int temp = Arr[i];
            Arr[i] = Arr[j];
            Arr[j] = temp;
        }
    }
}
