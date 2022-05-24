/* Assignment 2 by ...KaiserDMC...
   Current date: 2020-09-25
   Date of submission: 2020-09-26 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class FloatingNumbersWhileAdd
    {
        //Method to sum a non defined number of values that are of type double. User stops input with 0.

        private double sum; //Sum of all values

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
            Console.WriteLine("++++++++++ Summation of whole numbers +++++++++++");
            Console.WriteLine("++++++++++  Utilizing while-statement +++++++++++\n");
            Console.WriteLine("Write the number 0 to finish the summation!\n"); //Reminder for user to end with 0
            Console.WriteLine("-----------------------------------\n");
        }

        private void ReadInputAndSumNumbers() //Read user's inputs and perform the sum calculation
        {
            bool done = false; //True and False used to stop the loop.. on 0 value turns TRUE and stops the summation
            double number; //Storage for numbers
            
            while(!done)
            {
                Console.WriteLine("Give a number to be added to the sum (write 0 to finish): ");
                number = Input.ReadDoubleConsole(); //Read user's input... must be double

                if ((Math.Round(number, 5) == 0.0)) //Check if input is equal to 0
                {
                    done = true; //If 0 make true
                }
                else
                    sum = sum + number; //If not 0 add the number to the total sum
            }
        }

        private void ShowResults() //Visualize the results
        {
            //Formatting
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("The sum of all values is: \t{0}", Math.Round(sum, 3)); //Show the end sum result... Round the number to 3rd decimal
            Console.WriteLine("-----------------------------------\n");
        }


        /* This section was removed after the utilization of Input.cs class.
           Since the check for valid input from the user was moved there! */

        //private double ReadInput()
        //{
        //    Console.WriteLine("Give a number to be added to the sum (write 0 to finish): ");
        //    double num = double.Parse(Console.ReadLine());
        //    return num;
        //}
    }
}
