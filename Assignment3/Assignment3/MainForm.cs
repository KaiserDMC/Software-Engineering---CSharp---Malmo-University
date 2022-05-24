/* Assignment 3 by ...KaiserDMC...
   Current date: 2020-10-10
   Date of submission: 2020-10-11 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        //Declare and create an instance of the Fuel Calculator class
        private FuelCalculator carMileage = new FuelCalculator();

        //Declare and create and instacce of the BMI Calculator class
        private BodyMassIndex bmiCalc = new BodyMassIndex();

        //Declare and create and instance of the Calorie Calculator class
        private CalorieCalculator bmrCalc = new CalorieCalculator();

        private string name = string.Empty; //Declares name variable which is to be used later on

        /// <summary>
        /// Initialization part of the Form. This includes the MainForm method which does the initialization itself.
        /// The InitializeGUI method which sets the default state of the Form once it is started. 
        /// The ClearLabelsAndListBox method which sets all fields to empty and clears them of text.
        /// And ClearTextBoxes method which sets all textboxes to empty string upon start.
        /// </summary>

        #region Initialization

        public MainForm() //Initialization method
        {
            InitializeComponent(); //Calls method
            InitializeGUI(); //Callst the method
        }


        public void InitializeGUI() //Sets default values for the Form(GUI)
        {
            rbtnMetric.Checked = true; //Sets Unit's radio button to default value Metric
            rbtnFemale.Checked = true; //Sets Gender's radio button to default value Female

            ClearLabelsAndListBox(); //Calls method to clear labels and boxes
            ClearTextBoxes(); //Calls method to clear text boxes
        }

        private void ClearLabelsAndListBox() //Method to set all labels and the list box fields to empty strings
        {
            lblBMIOUT.Text = string.Empty;
            lblCostKMOUT.Text = string.Empty;
            lblFuelConsKLOUT.Text = string.Empty;
            lblFuelConsLKOUT.Text = string.Empty;
            lblFuelConsLMMOUT.Text = string.Empty;
            lblFuelConsLSMOUT.Text = string.Empty;
            lblWCategoryOUT.Text = string.Empty;
            lblNormalBMI.Text = string.Empty;
            lblListBoxItem.Text = string.Empty;
            lboxBMR.Text = string.Empty;
        }

        private void ClearTextBoxes() //Method to set all text boxes to empty strings
        {
            txtAge.Text = string.Empty;
            txtCurrFuel.Text = string.Empty;
            txtCurrReading.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrevReading.Text = string.Empty;
            txtPriceFuel.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        #endregion

        /// <summary>
        /// Fuel calculator section. In this section all methods used to calculate the fuel efficiency/consumption are presented.
        /// This includes the on click routines of the calculate button and the user input control section included in ReadInputFuel method.
        /// After all input is validated and Calculate button is selected the fuel consumption is calculated. User is pressented with values.
        /// User is provided with error messages in case the input is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #region Fuel Calculation Methods

        private void btnFuelCalc_Click(object sender, EventArgs e) //On click button Calculate for Fuel section perform the following
        {

            bool valueOK = true; //Variable declaration


            valueOK = ReadInputFuel(); //Assign value to the variable. If ReadInputFuel is true will be true, if false will be false

            bool validateOK = carMileage.ValidateOdometerValues();//Declare and assign value to the variable. If ValidateOdometerValues is true will be true, else false

            if (valueOK && validateOK) //If both previous values are true, aka validation of inputs is complete and OK execute
            {
                double litPerKm = carMileage.CalcFuelConsumptionLiterPerKm(); //Assigns the calculated value from FuelCalculator class to a local variable
                lblFuelConsLKOUT.Text = litPerKm.ToString("0.00"); //Updates the respective label with output for the user with a converted string using the local variable

                double kmPerLitre = carMileage.CalcConsumptionKilometerPerLiter(); //Assigns the calculated value from FuelCalculator class to a local variable
                lblFuelConsKLOUT.Text = kmPerLitre.ToString("0.00"); //Updates the respective label with output for the user with a converted string using the local variable

                double litPerMetricMile = carMileage.CalcConsumptionPerMetericMile(); //Assigns the calculated value from FuelCalculator class to a local variable
                lblFuelConsLMMOUT.Text = litPerMetricMile.ToString("0.00"); //Updates the respective label with output for the user with a converted string using the local variable

                double litPerSwedMil = carMileage.CalcFuelConsumptionPerSweMil(); //Assigns the calculated value from FuelCalculator class to a local variable
                lblFuelConsLSMOUT.Text = litPerSwedMil.ToString("0.00"); //Updates the respective label with output for the user with a converted string using the local variable

                double unitCost = carMileage.CalcCostPerKM(); //Assigns the calculated value from FuelCalculator class to a local variable
                lblCostKMOUT.Text = unitCost.ToString("0.00"); //Updates the respective label with output for the user with a converted string using the local variable
            }
            else if ((valueOK) && (!validateOK))
                MessageBox.Show("Invalid current odometer value has to be bigger than previous value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case odometer values are wrong

        }

        private bool ReadInputFuel() //Reads the user input for the Fuel calculation section
        {
            double value = 0.0; //Variable declaration

            if (double.TryParse(txtCurrReading.Text, out value)) //Tries to convert the user's input from text to double, if convertion is OK, gives value to current reading, if not returns error message
            {
                carMileage.SetCurrentReading(value);
            }
            else
            {
                MessageBox.Show("Invalid current odometer value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (double.TryParse(txtPrevReading.Text, out value)) //Tries to convert the user's input from text to double, if convertion is OK, gives value to previous reading, if not returns error message
            {
                carMileage.SetPreviousReading(value);
            }
            else
            {
                MessageBox.Show("Invalid previous odometer value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (double.TryParse(txtCurrFuel.Text, out value)) //Tries to convert the user's input from text to double, if convertion is OK, gives value to current fuel tanked, if not returns error message
            {
                carMileage.SetFuelAmount(value);
            }
            else
            {
                MessageBox.Show("Invalid fuel tanked value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (double.TryParse(txtPriceFuel.Text, out value)) //Tries to convert the user's input from text to double, if convertion is OK, gives value to price of fuel, if not returns error message
            {
                carMileage.SetUnitPrice(value);
            }
            else
            {
                MessageBox.Show("Invalid price value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion

        /// <summary>
        /// BMI calculator section. In this section all methods used to calculate the BMI - body mass index are presented.
        /// This includes the on click routines of the calculate button and the user input control section included in ReadName and ReadWeightAndHeight methods.
        /// After all input is validated and Calculate button is selected the BMI is calculated. User is pressented with values.
        /// User is provided with error messages in case the input is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #region BMI Calculation Methods

        private void btnBMICalc_Click(object sender, EventArgs e) //On click button Calculate for BMI section perform the following
        {
            bool valueOK = false; //Variable declaration and value assignment

            ReadName(); //Call ReadName method

            valueOK = ReadWeightAndHeight(); //Assign value to the variable. If ReadWeightAndHeight is true will be true, if false will be false

            if (valueOK) //If previous check is TRUE perform thhe following
            {
                if (rbtnMetric.Checked) //In case the Metric Radio button is selected
                {
                    double bodyMassMetric = bmiCalc.CalcBMIMetric(); //Assigns the calculated value from FuelCalculator class to a local variable
                    lblBMIOUT.Text = bodyMassMetric.ToString("0.00"); //Updates the respective label with output for the user with a converted string using the local variable

                    //Checks the calculated BMI values and displays Weight Category based on the value. For METRIC units
                    if (bodyMassMetric < 18.5)
                        lblWCategoryOUT.Text = "Underweight";
                    else if (bodyMassMetric >= 18.5 && bodyMassMetric < 25)
                        lblWCategoryOUT.Text = "Normal Weight";
                    else if (bodyMassMetric >= 25 && bodyMassMetric < 30)
                        lblWCategoryOUT.Text = "Overweight (Pre-obesity)";
                    else if (bodyMassMetric >= 30 && bodyMassMetric < 35)
                        lblWCategoryOUT.Text = "Obesity class I";
                    else if (bodyMassMetric >= 35 && bodyMassMetric < 40)
                        lblWCategoryOUT.Text = "Obesity class II";
                    else if (bodyMassMetric > 40)
                        lblWCategoryOUT.Text = "Obesity class III";
                }
                else
                {
                    double bodyMassImperial = bmiCalc.CalcBMIImperial(); //Assigns the calculated value from BodyMassIndex class to a local variable
                    lblBMIOUT.Text = bodyMassImperial.ToString("0.00"); //Updates the respective label with output for the user with a converted string using the local variable

                    //Checks the calculated BMI values and displays Weight Category based on the value. For Imperial (U.S.) units
                    if (bodyMassImperial < 18.5)
                        lblWCategoryOUT.Text = "Underweight";
                    else if (bodyMassImperial >= 18.5 && bodyMassImperial < 25)
                        lblWCategoryOUT.Text = "Normal Weight";
                    else if (bodyMassImperial >= 25 && bodyMassImperial < 30)
                        lblWCategoryOUT.Text = "Overweight (Pre-obesity)";
                    else if (bodyMassImperial >= 30 && bodyMassImperial < 35)
                        lblWCategoryOUT.Text = "Obesity class I";
                    else if (bodyMassImperial >= 35 && bodyMassImperial < 40)
                        lblWCategoryOUT.Text = "Obesity class II";
                    else if (bodyMassImperial > 40)
                        lblWCategoryOUT.Text = "Obesity class III";
                }

            }

            lblNormalBMI.Text = "Normal BMI is between 18.5 and 24.9"; //Displays information text to user about the NORMAL values of BMI
        }


        private void ReadName() //Method to check the Name input from the user
        {
            lboxBMR.Font = new Font(FontFamily.GenericMonospace, lboxBMR.Font.Size, FontStyle.Regular); //List box text formatting

            txtName.Text.Trim();
            if (string.IsNullOrEmpty(txtName.Text)) //In case no name is provided from the user types in "NoName"
            {
                name = "NoName";
                grboxResultsBMI.Text = "Results for NoName";
                lboxBMR.Items.Add("BMR RESULTS FOR NoName"); //List Box 1st line with title and name assignment is done here so later this function is just called again
            }
            else
            {
                name = txtName.Text; //If name if provided by the user use that name
                grboxResultsBMI.Text = "Results for " + name;
                lboxBMR.Items.Add("BMR RESULTS FOR " + name.ToUpper()); //List Box's 1st line with title and name assignment is done here so later this function is just called again
            }
        }

        private bool ReadWeightAndHeight() //Method to check the Weight and Height inputs from the user
        {
            double value = 0.0; //Variable declaration

            if (double.TryParse(txtWeight.Text, out value)) //Tries to convert the user's input from text to double, if convertion is OK, gives value to weight for both BMI and BMR calculations, if not returns error message
            {
                bmiCalc.SetWeight(value);
                bmrCalc.SetWeight(value);
            }
            else
            {
                MessageBox.Show("Invalid weight value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (double.TryParse(txtHeight.Text, out value)) //Tries to convert the user's input from text to double, if convertion is OK, gives value to height for both BMI and BMR calculations, if not returns error message
            {
                bmiCalc.SetHeight(value);
                bmrCalc.SetHeight(value);
            }
            else
            {
                MessageBox.Show("Invalid height value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion

        /// <summary>
        /// BMR calculator section. In this section all methods used to calculate the BMR - basak netabikuc rate are presented.
        /// This includes the on click routines of the calculate button and the user input control section included in ReadName, 
        /// ReadWeightAndHeight and ReadInputBMR methods. After all input is validated and Calculate button is selected the BMR is calculated. 
        /// User is pressented with values. User is provided with error messages in case the input is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #region BMR Calculation Methods

        private void btnBMRCalc_Click(object sender, EventArgs e) //On click button Calculate for BMR section perform the following
        {
            bool valueOK = false; //Variable declaration
            int group = -1; //Gives default value to variable, later used in switch cases

            lboxBMR.Items.Clear(); //Clears the List box text. Previously had the TITLE of the List box with the user provided name written inside

            ReadName(); //Calls the ReadName function again to write the TITLE line including the user provided name once again

            //The List box is cleared and then ReadName fuction is called again instead of using the commented line specified below.
            //This is done to ensure that the Name can be updated every time the BMR Calculate button is pressed or the gender radio button
            //is swapped between Female and Male. If the line below was used the BMI Calculate button has to be pressed before the name is updated.
            //This was deemed NOT user friendly hence the change of solution.

            //lboxBMR.Items.Add("BMR RESULTS FOR " + name.ToUpper());

            lboxBMR.Items.Add(Environment.NewLine); //Empty line inside the List Box for formatting purposes

            valueOK = ReadInputBMR() && ReadWeightAndHeight(); //Declare and assign value to the variable. If ReadInputBMR and ReadWeightAndsHeight are true will be true, else false

            if (valueOK) //If both previous values are true, aka validation of inputs is complete and OK execute
            {

                //Declaration of local variables
                double maintainweightCalories = 0.0;
                double toLose500;
                double toLose1000;
                double toGain500;
                double toGain1000;
                double basalMetabolicRate;


                //Assigns values to group, which is to be used for switch cases based on the Radio button selection for Activity Level
                if (rbtnSedetary.Checked)
                    group = 0;
                else if (rbtnLightly.Checked)
                    group = 1;
                else if (rbtnModerately.Checked)
                    group = 2;
                else if (rbtnVeryActive.Checked)
                    group = 3;
                else if (rbtnExtraActive.Checked)
                    group = 4;

                if (rbtnFemale.Checked) //If Radio button Female is selected
                {

                    basalMetabolicRate = bmrCalc.CalcBMRFemale(); //Assigns the calculated value from CalorieCalculator class to a local variable
                    string bmr = basalMetabolicRate.ToString("0.0"); //Converts the variable from double to string
                    lboxBMR.Items.Add("Your BMR (calories/day) \t\t" + bmr); //Adds line with output for the user with a converted string using the local variable
                }
                else
                {
                    basalMetabolicRate = bmrCalc.CalcBMRMale(); //Assigns the calculated value from CalorieCalculator class to a local variable
                    string bmr = basalMetabolicRate.ToString("0.0"); //Converts the variable from double to string
                    lboxBMR.Items.Add("Your BMR (calories/day) \t\t" + bmr); //Adds line with output for the user with a converted string using the local variable
                }


                //Depending on the Radio button selection pick a case to calculate the calories needed to maintain YOUR weight
                switch (group)
                {
                    case 0:
                        maintainweightCalories = basalMetabolicRate * 1.2;
                        break;
                    case 1:
                        maintainweightCalories = basalMetabolicRate * 1.375;
                        break;
                    case 2:
                        maintainweightCalories = basalMetabolicRate * 1.550;
                        break;
                    case 3:
                        maintainweightCalories = basalMetabolicRate * 1.725;
                        break;
                    case 4:
                        maintainweightCalories = basalMetabolicRate * 1.9;
                        break;
                    default:
                        MessageBox.Show("Please select activity level from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //If no button is selected give error
                        return;
                }

                //Calculates the calories needed to lose or gain weight based on the previously calculated calories to maintain the weight.
                //Every calculation is displayed in different line inside the List box
                lboxBMR.Items.Add("Calories to maintain your weight \t" + maintainweightCalories.ToString("0.0"));
                toLose500 = maintainweightCalories - 500;
                lboxBMR.Items.Add("Calories to lose 0,5 kg per week  \t" + toLose500.ToString("0.0"));
                toLose1000 = maintainweightCalories - 1000;
                lboxBMR.Items.Add("Calories to lose 1 kg per week  \t" + toLose1000.ToString("0.0"));
                toGain500 = maintainweightCalories + 500;
                lboxBMR.Items.Add("Calories to gain 0,5 kg per week  \t"+ toGain500.ToString("0.0"));
                toGain1000 = maintainweightCalories + 1000;
                lboxBMR.Items.Add("Calories to gain 1 kg per week  \t" + toGain1000.ToString("0.0"));

                lboxBMR.Items.Add(Environment.NewLine); //Empty line for formatting
                lboxBMR.Items.Add("Losing more than 1000 calories per day is to be avoided."); //Information message to the user
            }

        }

        protected void lboxBMR_SelectedIndexChanged(object sender, EventArgs e) //When the user selects a line from the list box
        {
                lblListBoxItem.Text = ("Selected item: " + lboxBMR.SelectedIndex); //Update label to state which line was selected by user
        }


        private bool ReadInputBMR() //Method to check the inputs for BMR calculation
        {
            int value = 0; //Variable declaration

            if (int.TryParse(txtAge.Text, out value)) //Tries to convert the user's input from text to int, if convertion is OK, gives value to age for BMR calculations, if not returns error message
            {
                bmrCalc.SetAge(value);
            }
            else
            {
                MessageBox.Show("Invalid age value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnUnselect_Click(object sender, EventArgs e) //When unselect button is clicked
        {
            lboxBMR.ClearSelected(); //Unselects the line selected in the list box by the user
        }

        #endregion
    }
}
