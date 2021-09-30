namespace GruppPract
{
    public class Model
    {
        public RecipeManager RecipeManager { get; set; } = new RecipeManager();
        public FileManager FileManager { get; set; } = new FileManager();
        public const string filePath = @"./RecipeList.csv";

        public void NewRecipeList()
        {
            RecipeManager = new RecipeManager();
        }

        public void LoadRecipes()
        {
            RecipeManager.RecipeList = FileManager.LoadRecipeList(filePath);
        }

        public void SaveRecipes()
        {

        }
    }
}
