using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GruppPract
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public RecipeManager RecipeManager { get; set; } = new RecipeManager();
        public FileManager FileManager { get; set; } = new FileManager();
        public string FilePath { get; set; } = "";

        public void NewRecipeList()
        {
            RecipeManager = new RecipeManager();
            ResetGUI();
        }

        private void ResetGUI()
        {
            // Clear textboxes, selections, etc.
        }

        public void LoadRecipes()
        {
            RecipeManager.RecipeList = FileManager.LoadRecipeList(FilePath);
        }

        public void SaveRecipes()
        {

        }
    }
}
