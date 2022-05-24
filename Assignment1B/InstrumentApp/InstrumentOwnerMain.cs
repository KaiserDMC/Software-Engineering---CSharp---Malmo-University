/* Assignment 1 - Part II by ...KaiserDMC...
   Current date: 2020-09-12
   Date of submission: 2020-09-13 */

using System;

namespace InstrumentApp
{
    class InstrumentOwnerMain
    {
        //Main class of the program.. calls the methods from Instrument class
        static void Main(string[] args)
        {
            //Console Formatting
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Instrument Owner Tab";
            Console.Clear();

            Instrument instrumentObj = new Instrument(); //Creates an object from the Instrument class

            instrumentObj.StartHere(); //Calls the Start method, that calls the other methods

            Console.WriteLine(); //Blank line on screen
            Console.WriteLine("Press Enter to exit the application!");
            Console.ReadLine(); //Holds the screen until button press
        }
    }
}
