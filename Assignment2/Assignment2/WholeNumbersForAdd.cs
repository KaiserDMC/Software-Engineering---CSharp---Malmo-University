/* Assignment 2 by ...KaiserDMC...
   Current date: 2020-09-25
   Date of submission: 2020-09-26 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class WholeNumbersForAdd
    {
        //Method to sum a predefined number of values that are all whole numbers.

        private int numbOfInputs; //Number of values to be added
        private int sum; //Sum of all the values

        public void Start() //Start method - used to call all sub methods
        {
            WriteProgramInfo();
            ReadInput();
            SumNumbers();
            ShowResults();
        }

        private void ReadInput() //Translates the user input to a number 
        {
            Console.WriteLine("-----------------------------------\n"); //Formatting
            Console.WriteLine("How many values do you wish to sum? ");
            numbOfInputs = int.Parse(Console.ReadLine()); //Reads the string and converts to int number
            Console.WriteLine(); //Blank line for formatting
        }

        private void WriteProgramInfo() //Method that gives basic info about the program, what it does and using what function
        {
            //Formatting
            Console.WriteLine(); //Blank line
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("++++++++++ Summation of whole numbers +++++++++++");
            Console.WriteLine("+++++++++++  Utilizing for-statement ++++++++++++\n");
        }
        
        private void SumNumbers() //The sum method to sum all the values 
        {
            int index = 0; //Index definition
            int num = 0; //Storage for each number

            for (index=1; index<=numbOfInputs; index++) //For statement to perform the sum
            {
                Console.WriteLine("Value of number no " + index + " (only whole numbers): ");
                num = int.Parse(Console.ReadLine()); //Convert user text/string to number/int
                sum = sum + num; //Perform the sum
            }
        }

        private void ShowResults() //Visualize the results - show the sum
        {
            //Formatting
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("The sum of all values is: \t{0}", sum);
            Console.WriteLine("-----------------------------------\n");
        }

    }
}
