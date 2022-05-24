/* Assignment 4 - by ...KaiserDMC...
   Current date: 2020-11-04
   Date of submission: 2020-11-06 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    //Class used for the Recipe Form section. All methods here are handling various tasks needed for the Recipe Form
    public partial class FormMain : Form
    {
        private const int numOfIngredients = 50; //defines maximum number of ingredients
        private const int maxNumOfElements = 200; //defines maximum number of elements/recipes

        Recipe currRecipe = new Recipe(numOfIngredients);

        RecipeManager recipeMngr = new RecipeManager(maxNumOfElements);

        public FormMain() //Form initialization
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI() //GUI Initialization... Assigns the default values for all fields
        {
            cboxCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            cboxCategory.SelectedItem = currRecipe.Category;
            txtName.Text = currRecipe.Name;
            txtDescription.Text = currRecipe.Description;
            lstRecipes.Font = new Font(FontFamily.GenericMonospace, lstRecipes.Font.Size, FontStyle.Regular); //List box text formatting
        }

        public void UpdateGUI() //GUI Update... Used to refresh/update the GUI information afte add/edit/delete of each recipe
        {
            cboxCategory.SelectedItem = currRecipe.Category;
            txtName.Text = currRecipe.Name;
            txtDescription.Text = currRecipe.Description;

            string[] recipeListStrings = recipeMngr.RecipeListToString();
            lstRecipes.Items.Clear();
            lstRecipes.Items.AddRange(recipeListStrings);

        }

        private void btnAddIngredients_Click(object sender, EventArgs e) //Execute on clicking button "Add Ingredients"
        {
            //Calls the Ingredients Form and lets the user fill in the ingredients section of the recipe
            FormIngredients dlg = new FormIngredients(currRecipe);
            DialogResult dlgResult = dlg.ShowDialog();

            if(dlgResult == DialogResult.OK)
            {
                if(currRecipe.GetCurrentNumOfIngredients() <= 0)
                {
                    MessageBox.Show("No igredients specified!");
                }
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e) //Execute on clicking button "Add Recipe"
        {
            if (!CheckInput()) //Input check... If name of recipe is empty or not
                return;

            //Takes in the selected category, name and description and adds them inside the Recipe Manager as a newly added recipe
            currRecipe.Category = (FoodCategory)cboxCategory.SelectedIndex;
            currRecipe.Name = txtName.Text.Trim();
            currRecipe.Description = txtDescription.Text.Trim();

            recipeMngr.Add(currRecipe);

            //Needs to reinitialize Recipe again as otherwise we will always edit the same recipe... For example upon editing recipe 2 all other recipes will obtain
            //the same new value as recipe 2 if this line is not here, as all recipes will be under 1 instance... This way only recipe 2 will be affected by any changes
            currRecipe = new Recipe(numOfIngredients); 
            currRecipe.DefaultValues(); //Restore default values

            UpdateGUI(); //Update GUI
        }


        public bool CheckInput() //Input check if the recipe name is empty or not
        {
            bool goodIndex = false;
            string value = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(value))
                goodIndex = true;
            return goodIndex;
        }

        private void btnEdit_Click(object sender, EventArgs e) //Execute on clicking button "Edit Recipe"
        {
            int editIndex = lstRecipes.SelectedIndex;
            if (editIndex >= 0)
            {
                currRecipe = recipeMngr.GetRecipeAt(editIndex);
                txtName.Text = currRecipe.Name; //Get the new recipe name
                txtDescription.Text = currRecipe.Description; //Get the new recipe description
                cboxCategory.SelectedItem = currRecipe.Category; //Get the new recipe category
            }
            else
                MessageBox.Show("Please select a Recipe from the list before you press the \"Edit Recipe\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no recipe is selected by the user
        }

        private void btnDelete_Click(object sender, EventArgs e) //Execute on clicking button "Delete Recipe"
        {

            int deleteIndex = lstRecipes.SelectedIndex;
            if (deleteIndex >= 0)
            {
                lstRecipes.Items.RemoveAt(deleteIndex); //Delete recipe inside list box
                recipeMngr.DeleteElement(deleteIndex); //Delete recipe inside the recipe database
            }
            else
                MessageBox.Show("Please select a Recipe from the list before you press the \"Delete Recipe\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no recipe is selected by the user
        }

        private void btnSaveChngRecipe_Click(object sender, EventArgs e) //Execute on clicking button "Confirm Edit"
        {
            //Save the new name/description/category after edit
            currRecipe.Name = txtName.Text.Trim();
            currRecipe.Description = txtDescription.Text.Trim();
            currRecipe.Category = (FoodCategory)cboxCategory.SelectedItem;
            
            currRecipe = new Recipe(numOfIngredients); //Re-initialize recipe... Else it will change all recipes as they will have same index
            currRecipe.DefaultValues(); //Restore default values

            UpdateGUI(); //Calls UpdateGUI method
        }
    }

}
