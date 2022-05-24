/* Assignment 2 by ...KaiserDMC...
   Current date: 2020-09-25
   Date of submission: 2020-09-26 */


using System;

namespace Assignment2
{
    class MainProgram
    {
        // Main method, used to start the application
        static void Main(string[] args)
        {

            //Console Formatting
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Assignment 2 - AB";
            Console.Clear();

            Menu menu = new Menu();
            menu.Start(); // Starts the program

        }
    }
}
