/* Assignment 3 by ...KaiserDMC...
   Current date: 2020-10-10
   Date of submission: 2020-10-11 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    //Class used to calculate the BMR
    class CalorieCalculator
    {
        
        private double weight; //Storage variable for weight
        private double height; //Storage variable for height
        private int age; //Storage variable for age
        private double bmr; ////Storage variable for bmr

        #region BMR Calculations

        public double CalcBMRFemale() //Method to calculate the BMR for Female selection
        {
            if (weight > 0.0 && height > 0.0 && age > 0) //Check input for positive values
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age); //Performs calculation stage 1
                bmr = bmr - 161; //Performs calcualton stage 2
            }
            return bmr; //returns value
        }
        public double CalcBMRMale() //Method to calculate the BMR for Male selection
        {
            if (weight > 0.0 && height > 0.0 && age > 0) //Check input for positive values
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age); //Performs calculation stage 1
                bmr = bmr + 5; //Performs calcualton stage 2
            }
            return bmr; //returns value
        }

        #endregion

        #region Getters and Setters

        //All setters give/set values to the respective storage variable, after the user input is checked from methods called in MainForm
        //The getters access/call these values when calculations are to be performed

        public double GetWeight()
        {
            return weight;
        }

        public double GetHeight()
        {
            return height;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetWeight(double newValue)
        {
            if (newValue > 0.0) //Check for positive value
                weight = newValue;
        }

        public void SetHeight(double newValue)
        {
            if (newValue > 0.0) //Check for positive value
                height = newValue;
        }

        public void SetAge (int newValue)
        {
            if (newValue > 0) //Check for positive value
                age = newValue;
        }

        #endregion
    }
}
