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
    //Class used to calculate the Fuel efficiency/consumption
    class FuelCalculator
    {

        private double currReading; //Storage variable for current odometer reading
        private double fuelAmount; //Storage variable for amount of fuel tanked
        private double prevReading; //Storage variable for previous odometer reading
        private double unitPrice; //Storage variable for fuel price
        private double distance; //Storage variable for distance
        private double kmPerLit; //Storage variable for kilometer per liter result
        private double litPerKM; ////Storage variable for liter per kilometer result

        #region Consumption and Cost Calculations

        public double CalcFuelConsumptionLiterPerKm() //Method to calculate the fuel comsumption in liters per kilometer
        {
            if (currReading - prevReading > 0.0) //Input check
                distance = currReading - prevReading; //Calculate distance
            litPerKM = fuelAmount / distance; //Calculate consumption

            return litPerKM; //returns value
        }

        public double CalcConsumptionKilometerPerLiter() //Method to calculate the fuel comsumption in kilometers per liter
        {
            if (fuelAmount > 0.0) //Input check
                kmPerLit = distance / fuelAmount; //Calculate consumption

            return kmPerLit; //returns value
        }

         public double CalcConsumptionPerMetericMile() //Method to calculate the fuel comsumption in liters per miles
        {
            const double kmToMileFactor = 0.621371192; //Declare constant for unit conversion
            double litPerMetricMile = litPerKM / kmToMileFactor; //Calculate consumption

            return litPerMetricMile; //returns value
        }
        public double CalcFuelConsumptionPerSweMil() //Method to calculate the fuel comsumption in liters per swedish mil
        {
            double literPerSwedMil = litPerKM * 10; //Calculate consumption

            return literPerSwedMil; //returns value

        }

        public double CalcCostPerKM() //Method to calculate the fuel cost per kilometer
        {
            double costPerKM = litPerKM * unitPrice; //Calculate cost

            return costPerKM; //returns value
        }

        #endregion

        #region Getters and Setters

        //All setters give/set values to the respective storage variable, after the user input is checked from methods called in MainForm
        //The getters access/call these values when calculations are to be performed
        public double GetCurrentReading()
        {
            return currReading;

        }

        public double GetFuelAmount()
        {
            return fuelAmount;
        }

        public double GetPreviousReading()
        {
            return prevReading;
        }

        public double GetUnitPrice()
        {
            return unitPrice;
        }

        public void SetCurrentReading (double newValue)
        {
            if (newValue > 0.0) //Check for positive value
                currReading = newValue;
        }

        public void SetFuelAmount (double newValue)
        {
            if (newValue > 0.0) //Check for positive value
                fuelAmount = newValue;

        }

        public void SetPreviousReading (double newValue)
        {
            if (newValue >= 0.0) //Check for positive or 0 value
                prevReading = newValue;
        }

        public void SetUnitPrice (double newValue)
        {
            if (newValue > 0.0) //Check for positive value
                unitPrice = newValue;
        }

        #endregion

        //Validation of Odometer values. The current reading has to be bigger than the previous reading.
        //If that is not the case returns false and that will give error to the user when MainForm checks the condition.
        public bool ValidateOdometerValues()
        {
            if (currReading > prevReading)
                return true;
            else
                return false;
        }

    }
}
