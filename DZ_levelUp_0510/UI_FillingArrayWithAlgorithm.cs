using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class UI_FillingArrayWithAlgorithm
    {
        static UserInterface UI = new UserInterface();
        static FillingArrayWithSnake fillingArrayWithSnake = new FillingArrayWithSnake();


        public void FillArray() 
        {
            string str = "Для выбора следующего алгоритма заполенеия нажмите любую кнопку (= \tДля выхода нажмите Esc\n";

            Console.WriteLine(@"Для выбора алгоритма заполнения используйте цифровой блок

1 - With Snake To Diagonal
    1   3   4   10
    2   5   9   11 
    6   8  12   15
    7  13  14   16

2 - With Snake 
    1   2   3   4
    8   7   6   5
    9  10  11  12
   16  15  14  13

3 - Standart 
    1   2   3   4
    5   6   7   8
    9  10  11  12
    13 14  15  16
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
            Console.ResetColor();

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Выберите алгоритма заполнения:");

                int typeFilling = 0;

                typeFilling = UI.DataInput(typeFilling);

                switch (typeFilling)
                {
                    case 1:
                        fillingArrayWithSnake.ArrayWithSnakeToDiagonal();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    case 2:
                        fillingArrayWithSnake.ArrayWithSnake();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;

                    case 3:
                        fillingArrayWithSnake.ArrayWithStandart();

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
