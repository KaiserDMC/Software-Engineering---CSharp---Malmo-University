/* Assignment 1 - Part I by ...KaiserDMC...
   Current date: 2020-09-12
   Date of submission: 2020-09-13 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PetApplication
{
    //New Pet class to hold the data/information from user and display that information later on
    class Pet
    {
        //Input variables to be used to store the data inputs from the user
        private string name; //name of the pet as text
        private int age; //age of the pet as a whole number
        private bool isFemale; //check mark if the pet is female or not, true if YES, false if NO

        public void StartHere() //Start method.. includes all methods and calls them one by one.. the Main method calls this Start
        {
            Console.WriteLine(); //Formatting
            Console.WriteLine("Please fill in the information about your pet!");
            Console.WriteLine(); //Formatting

            ReadName();
            ReadAge();
            ReadGender();
            DisplayPetInfo();
        }

        /* All methods used/called by StartHere initiation method are "private void".
           This is done so they cannot be called inside the Main method, as shown in the video tutorials of Module 1... 
           They could of course be "public" and upon need called inside the Main method! */

        private void ReadName()
        {
            //Method to read the name of the pet
            Console.WriteLine("What is the name of your pet?: "); //Asks the user to provide the name of the pet
            name = Console.ReadLine(); //Stores the name of the pet inside name variable
        }

        private void ReadAge()
        {
            //Method to read the age of the pet
            Console.WriteLine("How old is " + name + "? (rounded to the nearest full year): "); //Asks the user to provide the age of the pet in whole years
            string strAge = Console.ReadLine(); //Input from the user will be a string of text, i.e. "11"
            age = int.Parse(strAge); //Converts the text from the user to an int number for the program to store
        }

        private void ReadGender()
        {
            //Method to read the gender of the pet
            Console.WriteLine("Is your pet female? (Y/N)"); //Asks the user about the pet gender, YES if true, NO if false
            char answer = char.Parse(Console.ReadLine()); //Convert the text/string to char type
            if ((answer == 'y') || (answer == 'Y')) //Logical check of the char.. Y or y for true, others for false
                isFemale = true;
            else
                isFemale = false;

        }

        private void DisplayPetInfo()
        {
            Console.WriteLine(); //Blank line
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"); //Fortmatting
            Console.WriteLine(); //Blank line

            Console.WriteLine("Name of pet: " + name); //Returns the name of the pet
            Console.WriteLine("Age:" + age); //Returns the age of the pet

            Console.WriteLine(); //Blank line

            if (isFemale == true) //If true(female) display text option 1, if false text option 2
                Console.WriteLine(name + " is a good girl!");
            else
                Console.WriteLine(name + " is a good boy!");

            Console.WriteLine(); //Blank line
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"); //Fortmatting
            Console.WriteLine(); //Blank line
        }
    }
}


