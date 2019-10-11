using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class ArraySortTypes
    {
        static UserInterface UI = new UserInterface();

        const int LOW_RANGE = -100,
                  HIGH_RANGE = 100;

        const int ARRAY_SIZE = 10;

        static string str = "Для выбора нажмите Enter (= \nДля выхода нажмите Esc\n";

        public void SortArray()
        {
            int[] Array = new int[ARRAY_SIZE];
            Console.WriteLine(@"Для выбора сортировки используйте цифровой блок
1 - QuickSortArray
2 - BubbleSort
3 - ShellSort
4 - ShakerSort");
            Console.WriteLine(str);


            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Выберите алгорит сортировки:");

                int typeSort = 0;

                typeSort = UI.dataInput(typeSort);

                switch (typeSort)
                {
                    case 1:
                        QuickSortArray(Array);
                        Console.ResetColor();
                        Console.WriteLine(str);
                        break;

                    case 2:
                        BubbleSort(Array);
                        Console.ResetColor();
                        Console.WriteLine(str);
                        break;

                    case 3:
                        ShellSort(Array);
                        Console.ResetColor();
                        Console.WriteLine(str);
                        break;

                    case 4:
                        ShakerSort(Array);
                        Console.ResetColor();
                        Console.WriteLine(str);
                        break;

                    default:
                        Console.WriteLine("Для выхода нажмите Esc");
                        break;
                }
            }
        }

        static void QuickSortArray(int[] Arr)
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

        static void BubbleSort(int[] Arr)
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

        static void ShellSort(int[] Arr)
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

            const int SHELL_INTERVAL = 2;   // первоначально используемая Шеллом последовательность длин промежутков: N / 2
                                            // const int STEP_INTERVAL_3 = 3;   // длинa промежутков: N / 3
                                            // const int STEP_INTERVAL_5 = 5;   // длинa промежутков: N / 5


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

        static void ShakerSort(int[] Arr)
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
            int left = 0,
                right = Arr.Length - 1;


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
            int glass = Arr[i];
            Arr[i] = Arr[j];
            Arr[j] = glass;
        }

       
    }
}
