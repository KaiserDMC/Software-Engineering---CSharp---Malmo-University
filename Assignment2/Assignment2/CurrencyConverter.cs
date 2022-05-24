/* Assignment 2 by ...KaiserDMC...
   Current date: 2020-09-25
   Date of submission: 2020-09-26 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class CurrencyConverter
    {
        //Method to convert currency from SEK to user defined currency. Option to sum as many values as wanted.
        //User ends input with 0. User provides Currency name and current exchange rate

        private decimal sum; //Sum of all values
        private decimal rate; //Rate of exchange
        private string currency; //Currency name as string
        private decimal value; //The calculated convertion

        public void Start() //Start method - used to call all sub methods
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResults();
        }

        private void WriteProgramInfo() //Method that gives basic info about the program, what it does and using what function
        {
            //Formatting
            Console.WriteLine(); //Blank line
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("++++++++++ Convert Currency +++++++++++");
            Console.WriteLine("Write the number 0 to stop the input!\n");
            Console.WriteLine("Values to be given in decimal form!\n");
            Console.WriteLine("-----------------------------------\n");
        }

        private void ReadInputAndSumNumbers() //Read user's inputs and sum all values
        {
            bool done = false; //True and False used to stop the loop.. on 0 value turns TRUE and stops the summation
            decimal number; //Storage for numbers

            do
            {
                Console.WriteLine("Amount to be added to the subtotal (write 0 to finish): ");
                number = Input.ReadDecimalConsole(); //Read user's input... must be decimal
                if ((Math.Round(number, 5) == 0)) //Check if input is equal to 0
                {
                    done = true; //If 0 make true
                }
                else sum = sum + number; //If not 0 add the number to the total sum
            } while (!done); //If 0 exit and stop summing
            Console.WriteLine("Which foreign currency are you converting?: ");
            currency = Console.ReadLine(); //User provides the name of the currency as string
            Console.WriteLine("What is the current exchange rate (decimal)?: ");
            rate = Input.ReadDecimalConsole(); //User provides with current exchange rate in decimal form
            value = sum / rate; //Currency convertion
            value = Decimal.Round(value, 2); //Rounding the converted currency to 2 decimals
            Console.WriteLine("-----------------------------------\n");

        }

        private void ShowResults() //Visualize results
        {

            //Formatting
            Console.WriteLine("The sum of all values is: \t{0}", sum + " SEK.\n");
            Console.WriteLine(sum + " SEK is converted to " + value + " " + currency + " at the rate of " + rate + " SEK/" + currency);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------\n");

        }
    }
}