/* Assignment 4 - by Kristian Attila Fodor, DoB 1993-04-20
   Current date: 2020-10-30
   Date of submission: 2020-11-01 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Recipe
    {
        //List of variables used to save ingrediats
        private string[] ingredientArray;
        private string name; //name of the recipe
        private string description; //Cooking instructions and other information

        public int MaxNumOfIngredients //Capacity f the array - maximum size
        {
            get { return ingredientArray.Length; }
        }

        public FoodCategory Category { get;  set; }

        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        public string[] Ingredients
        {
            get { return ingredientArray; }

            set
            {
                ingredientArray = value;
            }
        }

        private const int numOfIngredients = 20;
        private Recipe currRecipe = new Recipe(numOfIngredients);

        public Recipe (int maxNumOfIngredients)
        {
            ingredientArray = new string[maxNumOfIngredients];
            DefaultValues();
        }

        public void DefaultValues()
        {
            for (int index = 0; index < ingredientArray.Length; index++)
                ingredientArray[index] = string.Empty;

            name = string.Empty;
            Category = FoodCategory.Meat;
            description = string.Empty;
        }

        public int FindVacantPosition(string searchPosition)
        {
            int foundPos = -1;

            for (int index = 0; index < ingredientArray.Length; index++)
            {
                if (ingredientArray[index].Equals(searchPosition))
                {
                    foundPos = index;
                    break;
                }
            }
            return foundPos;
        }

        public bool AddIgredients(string ingredient)
        {
            bool ok = false;
            int indexPosition = FindVacantPosition(string.Empty);
            ok = indexPosition >= 0;
            if(ok)
            {
                this.ingredientArray[indexPosition] = ingredient;
            }
            return ok;
        }

        public bool CheckIndex(int index)
        {
            bool goodIndex = false;
            if ((index >= 0) && index <= ingredientArray.Length)
                goodIndex = true;
            return goodIndex;
        }

        public int GetCurrentNumOfIngredients()
        {
            int count = 0;
            for (int index = 0; index < ingredientArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[index]))
                    count++;
            }
            return count;
        }

        public override string ToString()
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

        public bool ChangeIngredientAt(int index, string value)
        {
            bool edit = true;
            if (CheckIndex(index))
                ingredientArray[index] = value;
            else
                edit = false;
            return edit;
        }

        public bool DeleteIngredientAt(int index)
        {
            bool delete = true;
            if (CheckIndex(index))
                ingredientArray[index] = string.Empty;
            else
                delete = false;
            return delete;
        }
    }
}
