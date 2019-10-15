using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_levelUp_0510
{
    class FillingArrayWithSnake
    {
        static UserInterface UI = new UserInterface();


        public void ArrayWithSnakeToDiagonal()
        {
            int sizeOfMatrix = 0,
                value = 1,
                xy = 0,
                yx = 0;

            Console.Write("Введите размерность массива : ");

            sizeOfMatrix = UI.DataInput(sizeOfMatrix);

            int[,] array = new int[sizeOfMatrix, sizeOfMatrix];

            FiilArrayToMainDiagonal(sizeOfMatrix, ref value, ref xy, ref yx, array);
            FillArrayAfterDiagonal(sizeOfMatrix, ref value, ref xy, ref yx, array);

            UI.PrintTwoDimensionalArray(array);
        }

        public void ArrayWithSnake()
        {
            int sizeOfMatrix = 0,
                value = 1;

            Console.Write("Введите размерность массива : ");

            sizeOfMatrix = UI.DataInput(sizeOfMatrix);

            int[,] array = new int[sizeOfMatrix, sizeOfMatrix];

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < sizeOfMatrix; j++)
                    {
                        array[i, j] = value++;
                    }
                }
                else
                {
                    for (int j = sizeOfMatrix - 1; j >= 0; j--)
                    {
                        array[i, j] = value++;
                    }
                }
            }

            UI.PrintTwoDimensionalArray(array);
        }
        public void ArrayWithStandart()
        {
            int sizeOfMatrix = 0,
               value = 1;

            Console.Write("Введите размерность массива : ");

            sizeOfMatrix = UI.DataInput(sizeOfMatrix);

            int[,] array = new int[sizeOfMatrix, sizeOfMatrix];

            for (int i = 0; i < sizeOfMatrix; i++)
            {

                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    array[i, j] = value++;
                }
            }

            UI.PrintTwoDimensionalArray(array);
        }



        private static void FiilArrayToMainDiagonal(int sizeOfMatrix, ref int value, ref int xy, ref int yx, int[,] array)
        {
            for (int x = 0; x < sizeOfMatrix; x++)
            {
                if (x % 2 == 0)
                {
                    value = Even_X(value, out xy, out yx, array, x);
                }

                else
                {
                    value = UnEven_X(value, out xy, out yx, array, x);
                }
            }
        }

        private static void FillArrayAfterDiagonal(int sizeOfMatrix, ref int value, ref int xy, ref int yx, int[,] array)
        {
            if (sizeOfMatrix % 2 == 1)
            {
                for (int y = 1; y < sizeOfMatrix; y++)
                {
                    if (y % 2 == 1)
                    {
                        value = UnEven_Y(sizeOfMatrix, value, out xy, out yx, array, y);
                    }

                    else
                    {
                        value = Even_Y(sizeOfMatrix, value, out xy, out yx, array, y);
                    }
                }
            }
            else
            {
                for (int x = 1; x < sizeOfMatrix; x++)
                {
                    if (x % 2 == 1)
                    {
                        value = UnEven_X(sizeOfMatrix, value, out xy, out yx, array, x);
                    }

                    else
                    {
                        value = Even_X(sizeOfMatrix, value, out xy, out yx, array, x);
                    }
                }
            }
        }

        /// to Main Diagonal
        
        private static int Even_X(int value, out int xy, out int yx, int[,] array, int x) 
        {
            yx = x;
            xy = 0;

            while (yx >= 0)
            {
                value = AppropriationNextValue(value, xy, yx, array);
                xy++;
                yx--;
            }

            return value;
        }

        private static int UnEven_X(int value, out int xy, out int yx, int[,] array, int x)
        {
            yx = 0;
            xy = x;

            while (xy >= 0)
            {
                value = AppropriationNextValue(value, xy, yx, array);
                yx++;
                xy--;
            }

            return value;
        }   

        /// after Main Diagonal

        private static int Even_X(int sizeOfMatrix, int value, out int xy, out int yx, int[,] array, int x)
        {
            yx = x;
            xy = sizeOfMatrix - 1;

            while (xy >= x)
            {
                value = AppropriationNextValue(value, xy, yx, array);
                xy--;
                yx++;
            }

            return value;
        }  

        private static int Even_Y(int sizeOfMatrix, int value, out int xy, out int yx, int[,] array, int y)
        {
            xy = y;
            yx = sizeOfMatrix - 1;

            while (yx >= y)
            {
                value = AppropriationNextValue(value, xy, yx, array);
                xy++;
                yx--;
            }

            return value;
        }

        private static int UnEven_X(int sizeOfMatrix, int value, out int xy, out int yx, int[,] array, int x)
        {
            yx = sizeOfMatrix - 1;
            xy = x;

            while (yx >= x)
            {
                value = AppropriationNextValue(value, xy, yx, array);
                xy++;
                yx--;
            }

            return value;
        }

        private static int UnEven_Y(int sizeOfMatrix, int value, out int xy, out int yx, int[,] array, int y)
        {
            yx = y;
            xy = sizeOfMatrix - 1;

            while (xy >= y)
            {
                value = AppropriationNextValue(value, xy, yx, array);
                xy--;
                yx++;
            }

            return value;
        }

        private static int AppropriationNextValue(int value, int xy, int yx, int[,] array)
        {
            array[xy, yx] = value;
            value++;
            return value;
        }
    }
}
