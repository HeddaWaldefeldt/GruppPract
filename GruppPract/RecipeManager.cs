using System.ComponentModel;

namespace GruppPract
{
    public class RecipeManager
    {
        public BindingList<Recipe> RecipeList { get; set; }

        public void AddRecipe(Recipe recipe)
        {
            RecipeList.Add(recipe);
        }

        public void DeleteRecipe(Recipe recipe)
        {
            RecipeList.Remove(recipe);
        }

        public void EditRecipe(Recipe recipe)
        {

        }
    }
}
