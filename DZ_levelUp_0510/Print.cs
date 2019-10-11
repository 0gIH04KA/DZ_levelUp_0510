using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class Print
    {
        static UserInterface UI = new UserInterface();

        static ArraySortTypes arraySortTypes = new ArraySortTypes();                    // dz 1
        static СheckArrayMirroring сheckArrayMirroring = new СheckArrayMirroring();     // dz 2
        static ArraySwapMinMax arraySwap = new ArraySwapMinMax();                       // dz 3
        

        static string str = "Для выбора ЗАДАНИЯ нажмите ЛЮБУЮ кнопку (= \nДля ВЫХОДА нажмите Esc\n";

        public void ConsolePrint()
        {
            Console.WriteLine(@"Для выбора задания используйте цифровой блок (:
Первое Задание: Реализовать различные виды сортирвки
Второе Задание: Проверить массив на зеркальность
Третье Задание: Найти в массиве Min и Max значение и поменять их местами
");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
            Console.ResetColor();

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Выберите задание для проверки:");

                int selectionHomeWork = 0;

                selectionHomeWork = UI.dataInput(selectionHomeWork);

                switch (selectionHomeWork)
                {
                    case 1:
                        Console.WriteLine("Первое Задание: Реализовать различные виды сортирвки\n");

                        arraySortTypes.SortArray();
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.WriteLine("Второе Задание: Проверить массив на зеркальность\n");
                        
                        сheckArrayMirroring.ArrayMirroring();
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    case 3:
                        Console.WriteLine("Третье Задание: Найти в массиве Min и Max значение и поменять их местами\n");
                        
                        arraySwap.ArraySwap();
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("Для ВЫХОДА нажмите Esc");
                        break;
                }
            }
        }
    }
}
