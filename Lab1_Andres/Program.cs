﻿using System;

namespace Lab1_Andres
{
    class Program
    {
        static void Main(string[] args)
        {

            static void showMenu() //used method to print a text menu for user to see
            {
                Console.WriteLine("\t\tMain Menu\n"); //use of \t to tabulate string and \n to jump to next line and make it more appealing
                Console.WriteLine("Make your selection from the following options:");
                Console.WriteLine("(To make selection just enter the number)\n"); //use of \n to jump to next line and make it more appealing
                Console.WriteLine("Option 1: Show all grades");
                Console.WriteLine("Option 2: Add grades");
                Console.WriteLine("Option 3: Get grade average from class");
                Console.WriteLine("Option 4: Show top grade");
                Console.WriteLine("Option 5: Show bottom grade");
                Console.WriteLine("Option 6: Remove student grade");
                Console.WriteLine("Option 7: Edit student grade");
                Console.WriteLine("Option 8: Exit");
            }




        }
    }
}
