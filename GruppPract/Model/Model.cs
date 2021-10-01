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

        public string AddRecipe(string title, string type, string description)
        {
            Regex regex = new Regex("[A-Öa-ö]");
            bool containsNumOrSpecialCharacter = regex.IsMatch(type); 
            
            string message= "";

            if (string.IsNullOrEmpty(title))
            {
                message = "Du måste fylla i en recepttitel";
                return message;
            }
            else if (string.IsNullOrEmpty(type))
            {
               return message= "Du måste fylla i en kategori";
            }
            else if (!containsNumOrSpecialCharacter)
            {
                return message = "Kategorin får inte innehålla specialtecken eller nummer";
            }
            else if (string.IsNullOrEmpty(description))
            {
                return message = "Du måste fylla i en beskrvning";    
            }
            else 
            {
                Recipe recipe = new Recipe();
                recipe.Title = title;
                recipe.Type = type;
                recipe.Description = description;
                RecipeManager.AddRecipe(recpie);

                return message = "Ditt recept är nu uppladdat!";  
            }

            
        }
            // Add validation logic here.
            // RecipeManager.AddRecipe();
            // return true.
            //throw new NotImplementedException();
            // Validation fails, return false. Display error message in GUI.
        }

        public void DeleteRecipe(Recipe recipe)
        {
            RecipeManager.DeleteRecipe(recipe);
        }
    }
}
