using System.ComponentModel;

namespace GruppPract
{
    public class FileManager
    {
        public string FilePath { get; set; }

        public BindingList<Recipe> LoadRecipeList(string filePath)
        {
            // Load from .csv-file

            return new BindingList<Recipe>();
        }

        public void SaveRecipeList(string filePath, BindingList<Recipe> recipeList)
        {
            // Save to .csv-file.
        }
    }
}
