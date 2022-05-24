/* Assignment 2 by ...KaiserDMC...
   Current date: 2020-09-25
   Date of submission: 2020-09-26 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Menu
    {
        //This class will display the menu, read the user's selection and call the method selected.
        //After execution of the selected method the user will return back to the menu

        public void Start() //Start method - used to call all sub methods
        {
            int choice = -1; //Value different than 0 so the menu can be initialized

            while (choice != 0) //Menu stays until user selects 0
            {
                DisplayMenu(); //Visualize or show the Menu to the user
                choice = Input.ReadIntegerConsole(); //Read user's choice


                switch (choice) //Depending on the user's choice go to the selected class
                {
                    case 0:     // do nothing
                        break; // exit switch
                    case 1: //Menu option 1 - Whole numbers sum
                       WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
                       sumObj.Start();
                        break;
                    case 2: //Menu option 2 - Float numbers sum, exit on 0
                        FloatingNumbersWhileAdd floatObj = new FloatingNumbersWhileAdd();
                        floatObj.Start();
                        break;
                    case 3: //Menu option 3 - Currency convertion
                        CurrencyConverter currObj = new CurrencyConverter();
                        currObj.Start();
                        break;
                    case 4: //Menu option 4 - Temperature table
                        TemperatureTable tempObj = new TemperatureTable();
                        tempObj.Start();
                        break;
                    case 5: //Menu option 5 - Work schedule
                        WorkingSchedule workObj = new WorkingSchedule();
                        workObj.Start();
                        break;
                    default: //Invalid option
                        Console.WriteLine(); //Blank line - formatting
                        Console.WriteLine("Invalid choice, please select and existing option!\n");
                        break;

                }
            }


        }

        private void DisplayMenu() //Display menu method - used to visualize the Menu
        {
            //Menu formatting
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n                        MENU                        ");
            Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Whole Numbers Sum (with For-loop)              :1 ");
            Console.WriteLine(" Floating Point Numbers Sum (with While-loop)   :2 ");
            Console.WriteLine(" Currency Converter (with Do-while loop)        :3 ");
            Console.WriteLine(" Temperature Table                              :4 ");
            Console.WriteLine(" Work Schedule                                  :5 ");
            Console.WriteLine(" Exit the program                               :0 ");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.Write(" Which program would you like to access?: ");
        }


        /* This section was removed after the utilization of Input.cs class.
         Since the check for valid input from the user was moved there! */
       
        /* private int UserChoice()
        {
            bool goodNum = false;
            int choice = 0;

            do
            {
                Console.WriteLine("Choose an option from the menu:");
                string strInput = Console.ReadLine();
                goodNum = int.TryParse(strInput, out choice);
                if (goodNum) // if (goodNum == true)
                {
                    if ((choice < 0) || (choice > 5))
                        goodNum = false;
                }
                if (!goodNum) // if (goodNum == false)
                    Console.WriteLine("Invalid choice, please select and existing option!\n");
            } while (!goodNum);

            return choice;
        } */

    }
}
