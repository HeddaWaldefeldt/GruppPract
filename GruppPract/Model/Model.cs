using System;

namespace GruppPract
{
    public class Model : PropertyChangedBaseClass
    {
        public RecipeManager RecipeManager { get; set; } = new RecipeManager();
        public FileManager FileManager { get; set; } = new FileManager();
        public const string filePath = @"./RecipeList.csv";
        private static Model _model = new Model();
        private UserType _userType = UserType.User;

        public static Model Instance
        {
            get => _model;
        }

        // Set UserType to regular user by default.
        public UserType UserType
        {
            get => _userType;
            set
            {
                _userType = value;
                // Sends notification when property has been changed.
                NotifyPropertyChanged(nameof(UserType));
            }
        }

        public void NewRecipeList()
        {
        }

        public void LoadRecipes()
        {
            RecipeManager.RecipeList = FileManager.LoadRecipeList(filePath);
        }

        public void SaveRecipes()
        {
            FileManager.SaveRecipeList(filePath, RecipeManager.RecipeList);
        }

        public bool AddRecipe(string title, string type, string description)
        {
            // Add validation logic here.
            // RecipeManager.AddRecipe();
            // return true.
            throw new NotImplementedException();
            // Validation fails, return false. Display error message in GUI.
        }

        public void DeleteRecipe(Recipe recipe)
        {
            RecipeManager.DeleteRecipe(recipe);
        }
    }
}
