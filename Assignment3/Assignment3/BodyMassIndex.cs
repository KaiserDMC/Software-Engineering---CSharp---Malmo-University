/* Assignment 3 by ...KaiserDMC...
   Current date: 2020-10-10
   Date of submission: 2020-10-11 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    //Class used to calculate the BMI
    class BodyMassIndex
    {
        
        private double bodyMassIndex; //Storage variable for BMI
        private double weight; //Storage variable for weight
        private double height; //Storage variable for height

        #region BMI Calculations

        public double CalcBMIMetric() //Method to calculate the BMI for Metric selection
        {
            if ((weight > 0.0) && (height > 0.0)) //Check input for positive values
                bodyMassIndex = weight / ((height * height)/10000); //Perform calculation
            
            return bodyMassIndex; //returns value
        }

        public double CalcBMIImperial() //Method to calculate the BMI for Imperial (U.S.) selection
        {

            if ((weight > 0.0) && (height > 0.0)) //Check input for positive values
                bodyMassIndex = (703.0 * weight) / (height * height); //Perform calculation

            return bodyMassIndex; //returns value
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


        public void SetWeight (double newValue)
        {
            if (newValue > 0.0) //Check for positive value
                weight = newValue;
        }

        public void SetHeight (double newValue)
        {
            if (newValue > 0.0) //Check for positive value
                height = newValue;
        }

        #endregion
    }
}
