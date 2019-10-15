using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DZ_levelUp_0510
{
    class Program
    {
        static Random random = new Random();
        static UserInterface UI = new UserInterface();

        static Print Print = new Print();

        static ArrayTwoDimensionalSwapMinMax arrayTwoDimensionalSwapMinMax = new ArrayTwoDimensionalSwapMinMax();
       static  ArraySwapMinMax ArraySwapMinMax = new ArraySwapMinMax();

        static void Main(string[] args)
        {
            //Print.ConsolePrint();
            ArraySwapMinMax.ArraySwap();
            arrayTwoDimensionalSwapMinMax.ArrayTwoDimensionalSwap();




















            Console.ReadKey();
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





