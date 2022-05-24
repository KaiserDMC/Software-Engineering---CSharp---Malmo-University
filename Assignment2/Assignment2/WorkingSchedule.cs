/* Assignment 2 by ...KaiserDMC...
   Current date: 2020-09-25
   Date of submission: 2020-09-26 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{

    /// <summary>
    /// ALthough it is possible to create this method in a single loop, using for example a do-while structure with a few if and for statements,
    /// the decision to separate the method into small parts and for loops was taken.
    /// The breakdown into smaller methods makes the program easily readable and understandable. 
    /// As the number of iterations is known (the weeks in one year are only 52) the for-loop is a great match for the task given.
    /// The simple for loops also keep the structure clean, so others can easily comprehend the code.
    /// </summary>

    class WorkingSchedule
    {
        //Method to show a "table" for days the employee has to work weekends and night shifts.

        private int weekend; //Stores numbers of weeks where the user has to work during the weekend
        private int night; //Stores numbers of weeks where the user has to work night shift

        public void Start() //Start method - used to call all sub methods
        {
            int choice = -1; //Value different than 0 so the menu can be initialized

            while (choice != 0) //Menu stays until user selects 0
            {
                DisplayWeekSubMenu(); //Visualize or show the  sub-menu to the user
                choice = Input.ReadIntegerConsole(); //Read user's choice

                switch (choice)
                {
                    case 0:     // do nothing
                        break; // exit switch
                    case 1: //Menu option 1 - Weekend Schedule
                        WeekendSchedule();
                        break;
                    case 2: //Menu option 2 - Night Shift Schedule
                        NightSchedule();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please select and existing option!\n");
                        break;
                }
            }

        }

        private void DisplayWeekSubMenu() //Display sub-menu method - used to visualize the Menu
        {
            //Formatting
            Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n             SCHEDULE PROGRAM SUB-MENU              ");
            Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" List of weekends to go to work                 :1 ");
            Console.WriteLine(" List of night shifts to go to work             :2 ");
            Console.WriteLine(" Exit to Main menu                              :0 ");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.Write(" Which option would you like to preview?: ");
        }

        private void WeekendSchedule() //Method used to calculate and display the weekend schedule of the user
        {
            int index = 0; //Initialization of index value
            int numberOfWeeks = 52; //Maximum number of week in 1 year
            int p = 0; //Used for formatting 
            int columns = 6; //Used for formatting

            //Formatting
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("List of Weekends to work");
            Console.WriteLine("----------------------------------------------\n");

            for (index = 1; index <= numberOfWeeks; index += 3) //For-loop calculating each week the user has to work weekend.. Increment is +3 as employee works every 3rd week starting week 1
            {
                weekend = index; //Number of week the user has to work weekend

                string textOut = string.Format("Week {0,-7} ", weekend ); //Formatting of the results
                Console.Write(textOut);
                
                //Formatting into columns
                p++;
                if ((p % columns == 0) && (p >= columns))
                    Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------"); //End line
        }


        private void NightSchedule() //Method used to calculate and display the night shift schedule of the user
        {
            int index = 0; //Initialization of index value
            int numberOfWeeks = 52; //Maximum number of week in 1 year
            int p = 0; //Used for formatting 
            int columns = 5; //Used for formatting


            //Formatting
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("List of Nights to work");
            Console.WriteLine("----------------------------------------------\n");

            for (index = 6; index <= numberOfWeeks; index += 5) //For-loop calculating each week the user has to work night shift.. Increment is +5 as employee works every 5th week starting week 6
            {
                night = index; //Number of week the user has to work night shift
                string textOut = string.Format("Week {0,-7} ", night); //Formatting of the results
                Console.Write(textOut);

                //Formatting into columns
                p++;
                if ((p % columns == 0) && (p >= columns))
                    Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------"); //End line
        }

    }

}
