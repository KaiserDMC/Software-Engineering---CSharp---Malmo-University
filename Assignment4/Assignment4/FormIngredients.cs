/* Assignment 4 - by ...KaiserDMC...
   Current date: 2020-11-04
   Date of submission: 2020-11-06 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    //Class used for the Igredients Form section. All methods here are handling various tasks needed for the Ingredients Form
    public partial class FormIngredients : Form
    {
        Recipe m_recipe; //Creates m_recipe variable of type Recipe to be used for the ingredients storage

        public FormIngredients(Recipe recipe) //Initialization of the Ingredients Form
        {
            InitializeComponent();

            m_recipe = recipe;

            if (string.IsNullOrEmpty(recipe.Name))
                this.Text = "No Recipe Name";
            else
                this.Text = recipe.Name + "Add ingredients";

            InitializeGUI();
        }

        public void InitializeGUI() //GUI Initialization... Default values for all fields
        {
            if (m_recipe.Ingredients == null)
                m_recipe.Ingredients = new string[m_recipe.MaxNumOfIngredients];
            else if(m_recipe.GetCurrentNumOfIngredients() > 0) //Additional loop to go thru the array of ingredients so the user can edit them later if needed
            {
                for(int index = 0; index < m_recipe.GetCurrentNumOfIngredients(); index++)
                {
                    lstIngredient.Items.Add(m_recipe.Ingredients[index]);
                }
            }

            toolTip1.SetToolTip(txtIngredient, "Example: 2 dl milk"); //Tool tip text
            lblMaxNumber.Text = m_recipe.GetCurrentNumOfIngredients().ToString(); //Update number of ingredients as label
        }

        private void btnAdd_Click(object sender, EventArgs e) //Execute on clicking button "Add"
        {
            if (!CheckInput()) //Input check.. If field is empty the method will exit w/o execution
                return;

            m_recipe.AddIgredients(txtIngredient.Text.Trim()); //Adds ingredient to the database/array
            lstIngredient.Items.Add(txtIngredient.Text.Trim()); //Adds ingredient to the list
            txtIngredient.Clear(); //Clears the text field where the ingredient name is typed by the user

            UpdateGUI(); //Calls UpdateGUI method
        }

        public void UpdateGUI() //Used to update the count/number of ingredients
        {
            lblMaxNumber.Text = lstIngredient.Items.Count.ToString();
        }


        public bool CheckInput() //Input data check... Checks if the field where the user is to give ingredient name is empty or not
        {
            bool goodIndex = false;
            string value = txtIngredient.Text.Trim();
            if (!string.IsNullOrEmpty(value))
                goodIndex = true;
            return goodIndex;
        }

        private void btnEdit_Click(object sender, EventArgs e) //Execute on clicking button "Edit" 
        {
            int editIndex = lstIngredient.SelectedIndex; //Find which ingredient index is to be edited
            if (editIndex >= 0)
            {
                if (!m_recipe.ChangeIngredientAt(editIndex, lstIngredient.Items[editIndex].ToString())) //Checks if the selected index is inside the ingredient array
                    return;
                txtIngredient.Text = lstIngredient.Items[editIndex].ToString(); //returns the ingredient inside the editable box
            }
            else
                MessageBox.Show("Please select an Ingredient from the list before you press the \"Edit\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no ingredient is selected by the user
        }

        private void btnDelete_Click(object sender, EventArgs e) //Execute on clicking button "Delete"
        {
            if (lstIngredient.SelectedIndex >= 0)
            {
                lstIngredient.Items.RemoveAt(lstIngredient.SelectedIndex); //Removes the item that is selected with its index from the Ingredients list
                txtIngredient.Clear(); //Clears the editable field

                UpdateGUI(); //Calls UpdateGUI method - to update the number of ingredients
            }
            else
                MessageBox.Show("Please select an Ingredient from the list before you press the \"Delete\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no ingredient is selected by the user
        }

        private void btnSaveChngIngredient_Click(object sender, EventArgs e) //Execute on clicking button "Confirm Edit"
        {
            //After the user has finished with the editing of the ingredient name, they must click "Confirm Edit" button to save the changes
            //This is done with a separate button as to not create multiple/switch cases that will have to call subroutines from the "Add" button
            int index = lstIngredient.SelectedIndex;
            if (index >= 0)
            {
                    m_recipe.Ingredients[index] = txtIngredient.Text.Trim(); //The selected item is assigned with a new name inside the array/database
                    lstIngredient.Items[index] = txtIngredient.Text.Trim(); //The selected item is assigned with a new name inside the list
                    txtIngredient.Clear(); //Clears the text field for editing

                    UpdateGUI(); //Calls the UpdateGUI method
            }
            else
                MessageBox.Show("Please select an Ingredient from the list before you press the \"Confirm Edit\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no ingredient is selected by the user
        }
    }
}
