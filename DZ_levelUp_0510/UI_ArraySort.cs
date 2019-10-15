using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class UI_ArraySort
    {
        static UserInterface UI = new UserInterface();
        static ArraySortTypes arraySortTypes = new ArraySortTypes();

        public void SortArray()
        {
            string str = "Для выбора следующего алгортима сортирвки нажмите любую кнопку (= \tДля выхода нажмите Esc\n";
            const int ARRAY_SIZE = 10;

            int[] Array = new int[ARRAY_SIZE];

            Console.WriteLine(@"Для выбора сортировки используйте цифровой блок

1 - Quick Sort Array
2 - Bubble Sort
3 - Shell Sort
4 - Shaker Sort
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
            Console.ResetColor();

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Выберите алгорит сортировки:");

                int typeSort = 0;

                typeSort = UI.DataInput(typeSort);

                switch (typeSort)
                {
                    case 1:
                        arraySortTypes.QuickSortArray(Array);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    case 2:
                        arraySortTypes.BubbleSort(Array);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    case 3:
                        arraySortTypes.ShellSort(Array);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    case 4:
                        arraySortTypes.ShakerSort(Array);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("Для завершения выбора сортировок нажмите Esc");
                        break;
                }
            }
        }
    }
}
