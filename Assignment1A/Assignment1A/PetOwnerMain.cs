/* Assignment 1 - Part I by ...KaiserDMC...
   Current date: 2020-09-12
   Date of submission: 2020-09-13 */ 

using System;

namespace PetApplication
{
    //Main class of the program.. calls the methods from pet class
    class PetOwnerMain
    {
        static void Main(string[] args)
        {
            //Console Formatting
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Pet Owner Tab";
            Console.Clear();

            Pet pet = new Pet(); //Creates an object from the Pet class
           
            pet.StartHere(); //Calls the Start method, that calls the other methods
            
            Console.WriteLine(); //Blank line on screen
            Console.WriteLine("Press Enter to exit the application!");
            Console.ReadLine(); //Holds the screen until button press
        }
    }
}
