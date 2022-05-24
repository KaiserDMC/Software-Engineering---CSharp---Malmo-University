/* Assignment 1 - Part II by ...KaiserDMC...
   Current date: 2020-09-12
   Date of submission: 2020-09-13 */

using System;
using System.Globalization;
using System.Xml.Schema;

namespace InstrumentApp
{
    //New Instrument class to hold the data/information from user and display that information later on
    //The questions and information fefatured in the App are meant for "String" Instruments ONLY
    class Instrument
    {

        //Input variables to be used to store the data inputs from the user
        private string instrumentType; //Lets the user to input the type of instrument
        private bool isAcousticOrElectric; //Lets the user select the specific type of the instrument, Acoustic or Electric, TRUE if Acoustic
        private int numberStrings; //number of strings of the instrument
        private string manufacturer; //Type the manufacturer of the instrument
        private string manufactureDate; //Date of manufacturing of the insturment
        private string bodyFinish; //Type of finish on the instument body , i.e. wood, polish, plastic etc.

        public void StartHere() //Start method.. will call all other methods
        {
            Console.WriteLine(); //Formatting
            Console.WriteLine("Please fill in the information about your instrument!");
            Console.WriteLine(); //Formatting

            ReadType();
            ReadSpecificType();
            ReadStrings();
            ReadManufacturer();
            ReadDateOfManufacture();
            ReadBodyFinish();
            DisplayInstrumentInfo();
        }

        /* All methods used/called by StartHere initiation method are "private void".
           This is done so they cannot be called inside the Main method, as shown in the video tutorials... 
           They could of course be "public" and upon need called inside the Main method! */

        private void ReadType()
        {
            //Method to read the Type of the instrument
            Console.WriteLine("Which type of instrument do you have? (only string instruments): "); //Asks the user to provide the type of the instrument
            instrumentType = Console.ReadLine(); //Stores the type/name of the instrument
        }

        private void ReadSpecificType()
        {
            //Method to read the Specific Type of the instrument
            Console.WriteLine("Is your " + instrumentType + " Acoustic (a) or Electric (e)?"); //Asks the user about the more specific instrument type, "acoustic" or "a" for Acoustic, Else Electric
            string answer = Console.ReadLine(); //Convert the save the answer as string
            if (answer.StartsWith("a"))  //Logical check of the string.. A or a for true, others for false (any text starting with A or a will be considered as TRUE)
            {
                isAcousticOrElectric = true;
            }
            else
            { 
                isAcousticOrElectric = false;
            }

        }

        private void ReadStrings()
        {
            //Method to read the number of strings on the instrument
            Console.WriteLine("How many strings does your " + instrumentType + " have?"); //Asks the user to provide the number of strings of the instrument
            string strNumberOfStrings = Console.ReadLine(); //Input from the user will be a string of text, i.e. "6"
            numberStrings = int.Parse(strNumberOfStrings); //Converts the text from the user to an int number for the program to store
        }

        private void ReadManufacturer()
        {
            //Method to read the name of the manufacturer
            Console.WriteLine("Which company manufactured your " + instrumentType + "?"); //Asks the user to provide the name of the manufacturer
            manufacturer = Console.ReadLine(); //Stores the name of the manufacturer inside manufacturer variable
        }

        private void ReadDateOfManufacture()
        {
            //Method to read the date of manufacture of the instrument
            Console.WriteLine("When was your " + instrumentType + " manufactured? (yyyy-MM-dd)"); //Asks the user to provide input about the date of manufacture (specified format has to be followed)
            manufactureDate = Console.ReadLine();
        }

        private void ReadBodyFinish()
        {
            //Method to read the name of the manufacturer
            Console.WriteLine("What type of finish does your " + instrumentType + " have? (ex. wooden, polish, plastic, etc.)"); //Asks the user to provide the type of the instrument finish
            bodyFinish = Console.ReadLine(); //Stores the name of the body finish inside bodyFinish variable
        }


        private void DisplayInstrumentInfo()
        {
            //Method to display the information on screen
            Console.WriteLine(); //Blank line
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"); //Fortmatting
            Console.WriteLine(); //Blank line

            Console.WriteLine("Type of Instrument: " + instrumentType); //Returns the type of the instrument
            if (isAcousticOrElectric == true) //If the answer was TRUE return Acoustic, else Electric
                Console.WriteLine("Specific type: Acoustic"); //Returns the specific type of the instrument if TRUE
            else
                Console.WriteLine("Specific type: Electric"); //Returns the specific type of the instrument if FALSE
            Console.WriteLine("Number of strings: " + numberStrings); //Returns the string number of the instrument
            Console.WriteLine("Manufactured by: " + manufacturer); //Returns the manufacturer of the instrument
            DateTime myDate = DateTime.ParseExact(manufactureDate, "yyyy-MM-dd", CultureInfo.InvariantCulture); //Convert the date string to date type
            Console.WriteLine("Date of manufacturing: " + myDate.ToString("yyyy-MM-dd")); //Returns the date of manufacture
            Console.WriteLine("Instrument body finish: " + bodyFinish); //Returns the body finish of the instrument

            Console.WriteLine(); //Blank line

            if (isAcousticOrElectric == true) //If true display text option 1 for acoustic type, if false text option 2 for electric type
                Console.WriteLine("Be gentle and don't break your " + instrumentType);
            else
                Console.WriteLine("Plug this boy inside an AMP and lets hear it!");

            Console.WriteLine(); //Blank line
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"); //Fortmatting
            Console.WriteLine(); //Blank line

        }
    }
}
