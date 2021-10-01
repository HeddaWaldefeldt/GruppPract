using System;
using System.ComponentModel;

namespace GruppPract
{
    public class FileManager
    {
        public BindingList<Recipe> LoadRecipeList(string filePath)
        {
            throw new NotImplementedException();
            // Load from .csv-file
            //return new BindingList<Recipe>();
        }

        public void SaveRecipeList(string filePath, BindingList<Recipe> recipeList)
        {
            throw new NotImplementedException();
            // Save to .csv-file.
        }
    }
}
