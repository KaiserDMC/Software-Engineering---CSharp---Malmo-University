/* Assignment 4 - by ...KaiserDMC...
   Current date: 2020-11-04
   Date of submission: 2020-11-06 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class RecipeManager
    {
        //Manager class used to store all recipes inside an array of strings by utilizing the methods inside it
        private Recipe[] recipeList; //An array to store the recipes as strings

        public RecipeManager (int maxNumOfElements) //Initialization of the Manager
        {
            recipeList = new Recipe[maxNumOfElements]; //Dimentionalizes the array
        }

        private int FindVacantPosition() //Method used to find an empty position inside the array
        {
            for(int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] == null)
                    return index;
            }

            return -1;
        }

        public Recipe GetRecipeAt(int index) //Assign a recipe at certain index
        {
            if (CheckIndex(index))
                return recipeList[index];
            else
                return null;
        }

        public string[] GetIngredients(int index) //Assign the ingredients for the searched/selected (same recipe as GetRecipeAt) recipe
        {
            if (CheckIndex(index))
                return recipeList[index].Ingredients;
            else
                return null;
        }


        public string[] RecipeListToString() //Formats each string inside the array of recipes... Each string is formatted individually
        {
            string[] recipesAsString = new string[GetCurrentNumOfItems()];
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                    break;

                recipesAsString[i] = recipeList[i].ToString();
            }

            return recipesAsString;
        }

        public bool CheckIndex(int index) //Index check... To make sure we are not out of range
        {
            bool goodIndex = false;
            if ((index >= 0) && index <= recipeList.Length)
                goodIndex = true;
            return goodIndex;
        }

        public bool Add(Recipe newRecipe) //Add a recipe inside an empty position
        {
            bool ok = false;
            int indexPosition = FindVacantPosition();
            ok = indexPosition >= 0;
            if (ok)
            {
                this.recipeList[indexPosition] = newRecipe;
            }
            return ok;
        }

        //Override of the Add method... Again adds a recipe inside the same empty position, but this time with various properties, such as name, category, etc.
        public bool Add(string name, FoodCategory category, string[] ingredients) 
        {
            bool ok = false;

            int index = FindVacantPosition();

            if(index >= 0)
            {
                Recipe recipe = new Recipe(ingredients.Length);
                recipe.Name = name;
                recipe.Ingredients = ingredients;
                recipe.Category = category;

                recipeList[index] = recipe;
                ok = true;
            }

            return ok;
        }

        public bool ChangeElement(int index, Recipe recipe) //Find the position where a recipe is to be changed/edited
        {
            bool edit = true;
            if (CheckIndex(index))
                recipeList[index] = recipe;
            else
                edit = false;
            return edit;
        }

        public bool DeleteElement(int index) //Find the position where a recipe is to be deleted
        {
            bool delete = true;
            if (CheckIndex(index))
                recipeList[index] = null;
            else
                delete = false;
            return delete;
        }

        public int GetCurrentNumOfItems() //Counts the number of recipes and returns the value
        {
            int count = 0;
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] != null)
                    count++;
            }
            return count;
        }


    }
}
