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

        static ArraySortTypes arraySortTypes = new ArraySortTypes(); // dz 1
        static СheckArrayMirroring сheckArrayMirroring = new СheckArrayMirroring(); //dz 2
        static ArraySwapMinMax arraySwap = new ArraySwapMinMax(); // dz3



        static void Main(string[] args)
        {
            
            
            
            arraySortTypes.SortArray();
            сheckArrayMirroring.ArrayMirroring();
            arraySwap.ArraySwap();







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





