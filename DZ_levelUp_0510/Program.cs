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

       
        static void Main(string[] args)
        {
            Print.ConsolePrint();
            
            Console.ReadKey();
        }
    }
}





