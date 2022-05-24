/* Assignment 2 by ...KaiserDMC...
   Current date: 2020-09-25
   Date of submission: 2020-09-26 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class TemperatureTable
    {
        //Method to show a table for convertion of temperatures. Shows from 0 to 100 in Celsius to Fahrenheit and vice versa

        private double toCelsius; //Stores converted celsius values
        private double toFahrenheit; //Stores converted fahrenheit values

        public void Start() //Start method - used to call all sub methods
        {
            int choice = -1; //Value different than 0 so the menu can be initialized

            while (choice!=0) //Menu stays until user selects 0
            {
                DisplayTempSubMenu(); //Visualize or show the  sub-menu to the user
                choice = Input.ReadIntegerConsole(); //Read user's choice

                switch (choice)
                {
                    case 0:     // do nothing
                        break; // exit switch
                    case 1: //Menu option 1 - Convert Fahrenheit to Celsius
                        FahrenheitToCelsius();
                        break;
                    case 2: //Menu option 2 - Convert Celsius to Fahrenheit
                        CelsiusToFahrenheit();
                        break;
                    default: //Invalid option
                        Console.WriteLine(); //Blank line - formatting
                        Console.WriteLine("Invalid choice, please select and existing option!\n");
                        break;
                }
            }

        }

        private void DisplayTempSubMenu() //Display sub-menu method - used to visualize the Menu
        {
            //Menu formatting
            Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n                TEMPERATURE SUB-MENU                ");
            Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Convert Fahrenheit to Celsius                  :1 ");
            Console.WriteLine(" Convert Celsius to Fahrenheit                  :2 ");
            Console.WriteLine(" Exit to Main menu                              :0 ");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.Write(" Which option would you like to preview?: ");
        }

        private void FahrenheitToCelsius() //Method converting Fahrenheit to Celsius
        {
            int index = 0; //Initial value start at 0
            int maxIndex = 100; //Final value stop at 100

            //Formatting
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("FAHRENHEIT TO CELSIUS CONVERTION TABLE");
            Console.WriteLine("----------------------------------------------\n");
            
            for (index=0; index<=maxIndex; index+=2) //For loop to calculate each temperature convertion... Jump every 2 degrees, i.e. will give 50 results
            {
                toCelsius = 5.0 / 9.0 * (index - 32); //Formula to convert the Fahrenheit degrees to Celsius
                string textOut = string.Format("{0,10}°F    =  {1,8}°C\n", index, Math.Round(toCelsius, 2)); //String formatting - making a simple table
                Console.WriteLine(textOut); //Print of formatted string
            }
            Console.WriteLine("---------------------------------------------");
        }

        private void CelsiusToFahrenheit() //For loop to calculate each temperature convertion... Jump every 2 degrees, i.e. will give 50 results
        {
            int index = 0; //Initial value start at 0
            int maxIndex = 100; //Final value stop at 100

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("CELSIUS TO FAHRENHEIT CONVERTION TABLE");
            Console.WriteLine("---------------------------------------------\n");

            for (index=0; index<=maxIndex; index+=2) //Formula to convert the Celsius degrees to Fahrenheit
            {
                toFahrenheit = 9.0 / 5.0 * index + 32.0; //Formula to convert the Celsius degrees to Fahrenheit
                string textOut = string.Format("{0,8}°C    =  {1,8}°F\n", index, Math.Round(toFahrenheit, 2)); //String formatting - making a simple table
                Console.WriteLine(textOut);
            }
            Console.WriteLine("---------------------------------------------");
        }

    }
}
