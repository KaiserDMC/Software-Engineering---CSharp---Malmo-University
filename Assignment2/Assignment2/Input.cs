/* Assignment 2 by ...KaiserDMC...
   Current date: 2020-09-25
   Date of submission: 2020-09-26 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Assignment2
{
    class Input
    {

        //Method used to check user's inputs. Converts the strings to int, double or decimal and checks if they fulfill
        //the requirements for the incoming parameters expected from the method. Double value will give error if int is expected, etc.

        public static int ReadIntegerConsole() //Check if the user has given a valid value INTEGER
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.WriteLine("Wrong input. The value is not a whole number (int). Please try again: ");
            return ReadIntegerConsole();
        }

        public static double ReadDoubleConsole() //Check if the user has given a valid value DOUBLE
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.WriteLine("Wrong input. The value must be a number (double). Please try again: ");
            return ReadDoubleConsole();
        }

        public static decimal ReadDecimalConsole() //Check if the user has given a valid value DECIMAL
        {
            decimal input;
            if (decimal.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.WriteLine("Wrong input. The value must be a decimal (decimal). Please try again: ");
            return ReadDecimalConsole();
        }

    }
}
