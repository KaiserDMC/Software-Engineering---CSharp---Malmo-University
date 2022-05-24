/* Assignment 4 - by ...KaiserDMC...
   Current date: 2020-11-04
   Date of submission: 2020-11-06 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4
{
    //Class used for the Recipe Form section. All methods here are handling various tasks needed for the Recipe Form
    //This class serves more as a template for how the different recipes should be read and stored inside the Recipe Manager
    //All methods here tackle tasks for single recipe only.
    public class Recipe
    {
        private string[] ingredientsArray; //Declaration of a new array used for storage space for the ingredients... Auto property could be utilized, however it is not as to be idential to example from lectures
        private string name; //Name of the recipe
        private string description; //Cooking instructions and other information

        #region Properties
        public int MaxNumOfIngredients //Capacity of the array - maximum size
        {
            get { return ingredientsArray.Length; }
        }

        public FoodCategory Category { get;  set; } //Category Property

        public string Description //Description Property
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public string Name //Name Property
        {
            get { return name; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        public string[] Ingredients //Ingredients Property
        {
            get { return ingredientsArray; }

            set
            {
                ingredientsArray = value;
            }

        }
        #endregion

        private Recipe currRecipe; //Creates private variable currRecipe of type Recipe... All recipe information is to be stored there

        public Recipe (int maxNumOfIngredients)
        {
            ingredientsArray = new string[maxNumOfIngredients]; //Initializes the ingredientsArray
            currRecipe = this;
            DefaultValues(); //Calls DefaultValues method
        }

        public void DefaultValues() //Used to assign default values to various fields
        {
            for (int index = 0; index < ingredientsArray.Length; index++)
                ingredientsArray[index] = string.Empty;

            name = string.Empty;
            Category = FoodCategory.Vegetarian;
            description = string.Empty;
        }

        public int FindVacantPosition(string searchPosition) //Method used to find an empty position inside the array
        {
            int foundPos = -1;

            for (int index = 0; index < ingredientsArray.Length; index++)
            {
                if (ingredientsArray[index].Equals(searchPosition))
                {
                    foundPos = index;
                    break;
                }
            }
            return foundPos;
        }

        public bool AddIgredients(string ingredient) //Find the position where ingredient is to be added
        {
            bool ok = false;
            int indexPosition = FindVacantPosition(string.Empty);
            ok = indexPosition >= 0;
            if(ok)
            {
                this.ingredientsArray[indexPosition] = ingredient;
            }
            return ok;
        }

        public bool CheckIndex(int index) //Check if the index is inside the array and not outside
        {
            bool goodIndex = false;
            if ((index >= 0) && index <= ingredientsArray.Length)
                goodIndex = true;
            return goodIndex;
        }

        public int GetCurrentNumOfIngredients() //Counts the number of ingredients and returns the value
        {
            int count = 0;
            for (int index = 0; index < ingredientsArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(ingredientsArray[index]))
                    count++;
            }
            return count;
        }

        public override string ToString() //Overrides the ToString() method inside c# and formats the recipe in a specific user defined way
        {
            int CurrentNumOfIngredients = GetCurrentNumOfIngredients();
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description!";

            string textOut = string.Format("{0, -20} {1,4}        {2, -12}    {3, -15}",
                name, CurrentNumOfIngredients, Category.ToString(), descriptionText);

            return textOut;
        }

        public bool ChangeIngredientAt(int index, string value) //Find the position where ingredient is to be changed/edited
        {
            bool edit = true;
            if (CheckIndex(index))
                ingredientsArray[index] = value;
            else
                edit = false;
            return edit;
        }

        public bool DeleteIngredientAt(int index) //Find the position where ingredient is to be deleted
        {
            bool delete = true;
            if (CheckIndex(index))
                ingredientsArray[index] = string.Empty;
            else
                delete = false;
            return delete;
        }
    }
}
