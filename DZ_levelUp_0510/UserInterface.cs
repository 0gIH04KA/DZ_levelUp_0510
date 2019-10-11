using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class UserInterface
    {
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

    }
}
